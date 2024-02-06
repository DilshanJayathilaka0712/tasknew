using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class jobrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 2, 10, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 2, 7, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 2, 6, 13, 17, 57, 757, DateTimeKind.Local).AddTicks(141) });
        }
    }
}
