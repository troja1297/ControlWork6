using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contact = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    InstitutionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    CafeId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clents",
                columns: new[] { "Id", "Contact", "Name" },
                values: new object[] { 1, "0556566611", "Vlad" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "InstitutionId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Пельмени1Пельмени1", 2, "Пельмени1", 100.0m },
                    { 2, "Пельмени2Пельмени2", 3, "Пельмени2", 200.0m },
                    { 3, "Пельмени3Пельмени3", 2, "Пельмени3", 300.0m },
                    { 4, "Пельмени4Пельмени4", 1, "Пельмени4", 400.0m }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "cafe1", "Кафе1" },
                    { 2, "cafe2", "Кафе2" },
                    { 3, "cafe3", "Кафе3" },
                    { 4, "cafe4", "Кафе4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CafeId", "Date", "DishId" },
                values: new object[] { 1, 0, new DateTime(1997, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clents");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
