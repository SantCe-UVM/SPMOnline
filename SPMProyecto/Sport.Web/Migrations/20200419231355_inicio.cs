using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Web.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<float>(maxLength: 2, nullable: false),
                    HomeCountry = table.Column<string>(maxLength: 25, nullable: false),
                    Location = table.Column<string>(maxLength: 25, nullable: false),
                    Height = table.Column<float>(maxLength: 2, nullable: false),
                    Weight = table.Column<float>(maxLength: 2, nullable: false),
                    Health = table.Column<string>(maxLength: 10, nullable: false),
                    Sport = table.Column<string>(maxLength: 25, nullable: false),
                    Coach = table.Column<bool>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
