using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canopee.Web.Migrations
{
    /// <inheritdoc />
    public partial class FirstModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameLa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardinessZone = table.Column<float>(type: "real", nullable: false),
                    Exposition = table.Column<int>(type: "int", nullable: false),
                    Growth = table.Column<int>(type: "int", nullable: false),
                    Disease = table.Column<int>(type: "int", nullable: false),
                    Insects = table.Column<int>(type: "int", nullable: false),
                    Roots = table.Column<int>(type: "int", nullable: false),
                    MaxHeight = table.Column<float>(type: "real", nullable: false),
                    MaxWidth = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trees");
        }
    }
}
