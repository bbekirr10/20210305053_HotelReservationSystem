using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationIdToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReservationRoom",
                columns: table => new
                {
                    ReservationsReservationId = table.Column<int>(type: "int", nullable: false),
                    RoomsRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRoom", x => new { x.ReservationsReservationId, x.RoomsRoomId });
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Reservations_ReservationsReservationId",
                        column: x => x.ReservationsReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationRoom_Rooms_RoomsRoomId",
                        column: x => x.RoomsRoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReservationId",
                table: "Customers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_RoomsRoomId",
                table: "ReservationRoom",
                column: "RoomsRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "ReservationRoom");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ReservationId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ReservationId",
                table: "Payments",
                column: "ReservationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
