using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.RoomTypeAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateRoomTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
