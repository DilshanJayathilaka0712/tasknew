using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class notation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3125), new DateTime(2024, 2, 10, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3145), new DateTime(2024, 2, 7, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 2, 6, 13, 8, 18, 691, DateTimeKind.Local).AddTicks(3148) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 7, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 2, 4, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 2, 2, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 2, 3, 21, 23, 35, 160, DateTimeKind.Local).AddTicks(813) });
        }
    }
}
