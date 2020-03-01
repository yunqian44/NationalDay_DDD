using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalDay_DDD.Infrastruct.Context
{
    public partial class AppDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 11, nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", maxLength: 20, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Address_Province = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_County = table.Column<string>(nullable: true),
                    Address_Street = table.Column<string>(nullable: true)
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
