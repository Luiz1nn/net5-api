using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "4e5409d6-8c9c-494e-90ec-3fc08e6efc48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "7c082b1c-abc2-4e34-9095-e594cc87ca5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8206141-c4c3-466d-ac55-2dde1d9b6faa", "AQAAAAEAACcQAAAAEGSiw08N1AFd+0m6QFU+qADZgnoj/fRR5ofmtA+g0MdbTiWKe9Ery9PCbXi5nuaMfg==", "31d3b326-d12b-4b83-80b5-918bd95d638f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "a6018582-74b9-4d03-af90-302b3dd73abd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d13923a6-079e-4a20-8e3b-d75b8c84804d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aae7c32-fbe2-4954-bbbf-165b0bbefb18", "AQAAAAEAACcQAAAAEDsShEFm3mgs5GYzGm4MdTvtBX6syIogMcky2fdiqOqTF+lc79IamTHbBkYF3gAfuw==", "546b3ebc-0bcf-49e2-81be-e540c78d49b7" });
        }
    }
}
