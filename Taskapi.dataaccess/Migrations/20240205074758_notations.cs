using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taskapi.dataaccess.Migrations
{
    /// <inheritdoc />
    public partial class notations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Addressno",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 1,
                columns: new[] { "Addressno", "city", "street" },
                values: new object[] { "31", "Hanguranketha", "Maliyadda" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 2,
                columns: new[] { "Addressno", "city", "street" },
                values: new object[] { "48", "Welimada", "Perawella" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 3,
                columns: new[] { "Addressno", "city", "street" },
                values: new object[] { "23", "kaluthara", "mathugama" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AId",
                keyValue: 4,
                columns: new[] { "Addressno", "city", "street" },
                values: new object[] { "31", "Hanguranketha", "Maliyadda" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addressno",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
    }
}
