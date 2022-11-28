using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canopee.Web.Migrations
{
    /// <inheritdoc />
    public partial class changedHardinessDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HardinessZone",
                table: "Trees",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "HardinessZone",
                table: "Trees",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
