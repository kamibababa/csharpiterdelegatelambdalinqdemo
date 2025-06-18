using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppReady0616.Migrations
{
    /// <inheritdoc />
    public partial class add_room_no_on_class_table2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomNo",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomNo",
                table: "Classes");
        }
    }
}
