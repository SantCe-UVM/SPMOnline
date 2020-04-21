using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Web.Migrations
{
    public partial class Equipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(nullable: false),
                    TeamName = table.Column<string>(maxLength: 50, nullable: false),
                    FoundationDate = table.Column<DateTime>(nullable: false),
                    HomeCountry = table.Column<string>(maxLength: 25, nullable: false),
                    Location = table.Column<string>(maxLength: 25, nullable: false),
                    Sport = table.Column<string>(maxLength: 25, nullable: false),
                    Coach = table.Column<bool>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
