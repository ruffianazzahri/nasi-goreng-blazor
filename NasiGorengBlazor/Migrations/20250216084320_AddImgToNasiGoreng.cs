using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NasiGorengBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddImgToNasiGoreng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "NasiGorengs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "NasiGorengs");
        }
    }
}
