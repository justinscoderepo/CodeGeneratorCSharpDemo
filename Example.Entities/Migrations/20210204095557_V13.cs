using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Example.Entities.Migrations
{
    public partial class V13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ml_category",
                columns: table => new
                {
                    ca_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ca_name = table.Column<string>(maxLength: 20, nullable: false),
                    ca_description = table.Column<string>(maxLength: 100, nullable: true),
                    ca_createddate = table.Column<DateTime>(nullable: true),
                    ca_modifieddate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ml_category", x => x.ca_id);
                });

            migrationBuilder.InsertData(
                table: "ml_category",
                columns: new[] { "ca_id", "ca_createddate", "ca_description", "ca_modifieddate", "ca_name" },
                values: new object[] { 1, null, "category desc", null, "Category 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ml_category");
        }
    }
}
