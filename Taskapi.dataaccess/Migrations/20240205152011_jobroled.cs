using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class jobroled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Joberole",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 1,
                column: "Joberole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 2,
                column: "Joberole",
                value: "Accountant");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 3,
                column: "Joberole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 4,
                column: "Joberole",
                value: "Driver");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 2, 10, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4969), new DateTime(2024, 2, 7, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 2, 6, 20, 50, 10, 732, DateTimeKind.Local).AddTicks(4972) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Joberole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 2, 10, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9626), new DateTime(2024, 2, 7, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9629), new DateTime(2024, 2, 6, 20, 47, 45, 143, DateTimeKind.Local).AddTicks(9629) });
        }
    }
}
