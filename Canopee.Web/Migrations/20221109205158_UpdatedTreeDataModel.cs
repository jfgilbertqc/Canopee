using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canopee.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTreeDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Disease",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Exposition",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Growth",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "HardinessZone",
                table: "Companies",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Insects",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "MaxHeight",
                table: "Companies",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MaxWidth",
                table: "Companies",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Roots",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disease",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Exposition",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Growth",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "HardinessZone",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Insects",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "MaxHeight",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "MaxWidth",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Roots",
                table: "Companies");
        }
    }
}
