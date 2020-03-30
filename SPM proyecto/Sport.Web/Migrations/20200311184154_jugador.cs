using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Web.Migrations
{
    public partial class jugador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<float>(maxLength: 2, nullable: false),
                    HomeCountry = table.Column<string>(maxLength: 25, nullable: false),
                    Health = table.Column<string>(maxLength: 10, nullable: false),
                    Position = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
