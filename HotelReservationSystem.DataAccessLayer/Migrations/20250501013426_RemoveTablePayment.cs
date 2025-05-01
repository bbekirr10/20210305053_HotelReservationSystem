using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTablePayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Reservations_ReservationId",
                table: "Payments");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: true);

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
                principalColumn: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Reservations_ReservationId",
                table: "Payments",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
