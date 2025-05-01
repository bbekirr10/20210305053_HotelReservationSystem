using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRoomReservationRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
