using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4327), "get some text books for school", new DateTime(2024, 2, 7, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4338), 0, "Get books for school-DB" },
                    { 2, new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4344), "get vegetable for week", new DateTime(2024, 2, 4, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4345), 0, "Get Vegetable" },
                    { 3, new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4346), "Wter the plant quickly", new DateTime(2024, 2, 3, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4347), 0, "Water the plants" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
