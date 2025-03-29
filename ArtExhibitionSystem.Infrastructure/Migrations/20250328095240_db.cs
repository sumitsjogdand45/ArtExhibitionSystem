using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 3, 28, 15, 22, 36, 903, DateTimeKind.Local).AddTicks(5757));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 3, 28, 13, 20, 44, 180, DateTimeKind.Local).AddTicks(1297));
        }
    }
}
