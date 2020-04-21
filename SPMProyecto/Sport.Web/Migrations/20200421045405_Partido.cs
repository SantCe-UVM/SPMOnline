using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Web.Migrations
{
    public partial class Partido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matchs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Sport = table.Column<string>(maxLength: 25, nullable: false),
                    MatchDate = table.Column<DateTime>(nullable: false),
                    MatchLocation = table.Column<string>(maxLength: 25, nullable: false),
                    MatchHours = table.Column<int>(maxLength: 25, nullable: false),
                    MatchMinutes = table.Column<int>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matchs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matchs");
        }
    }
}
