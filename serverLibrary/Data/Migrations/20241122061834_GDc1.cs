using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace serverLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class GDc1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SanctionId",
                table: "Sanctions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SanctionId",
                table: "Sanctions");
        }
    }
}
