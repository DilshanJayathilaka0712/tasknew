using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class authorenadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "authorAId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AId);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AId", "FullName" },
                values: new object[,]
                {
                    { 1, "Thilina Dilshan" },
                    { 2, "Saduni Madubhashini" },
                    { 3, "Charith vishan" },
                    { 4, "Punsara Nishanga" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due", "authorAId" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 7, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(800), 1 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due", "authorAId" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 4, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(811), 1 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due", "authorAId" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 2, 3, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(813), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_authorAId",
                table: "Todos",
                column: "authorAId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_authorAId",
                table: "Todos",
                column: "authorAId",
                principalTable: "Authors",
                principalColumn: "AId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_authorAId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_authorAId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "authorAId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 2, 7, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4344), new DateTime(2024, 2, 4, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4346), new DateTime(2024, 2, 3, 17, 47, 15, 955, DateTimeKind.Local).AddTicks(4347) });
        }
    }
}
