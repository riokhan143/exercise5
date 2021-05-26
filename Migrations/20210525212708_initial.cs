using Microsoft.EntityFrameworkCore.Migrations;

namespace excercise5v2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shrooms",
                columns: table => new
                {
                    ScientificName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPsychoactive = table.Column<bool>(type: "bit", nullable: false),
                    isPoisonous = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hymenophore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Veil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SporePrintColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GillColor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shrooms", x => x.ScientificName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shrooms");
        }
    }
}
