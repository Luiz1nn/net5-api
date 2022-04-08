using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d13923a6-079e-4a20-8e3b-d75b8c84804d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "a6018582-74b9-4d03-af90-302b3dd73abd", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aae7c32-fbe2-4954-bbbf-165b0bbefb18", "AQAAAAEAACcQAAAAEDsShEFm3mgs5GYzGm4MdTvtBX6syIogMcky2fdiqOqTF+lc79IamTHbBkYF3gAfuw==", "546b3ebc-0bcf-49e2-81be-e540c78d49b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "f235f319-29f8-4613-942b-abc7eb8f1a5f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f69a49-4201-4d5f-ad27-0e6895f5a157", "AQAAAAEAACcQAAAAEDV2mjg/4phb2SlResBmLiQDSkYc1ecBv+MMEte4r+iScNzWtaYTLd9d2PKzFhuJ1Q==", "5b120f7c-31fa-4183-9999-4a75a6f196a2" });
        }
    }
}
