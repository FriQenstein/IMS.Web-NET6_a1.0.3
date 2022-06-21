using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addingRemoteAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "3c9644f4-ff60-4c91-b442-3c2cd963be7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "03ac6e6c-a6ca-48be-9e6d-95e8c851c7a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be451d82-fcc2-492a-9204-cb7c4706b608", "AQAAAAEAACcQAAAAEFw48kyispGy/bacW7Qkh5Gw7rvpsUu0lm/jOq9l/9DhE4n02IJqd+f9S0LS8QfWFA==", "b9d6e8b8-37dc-4f98-85f8-1609c05a90e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef61aa9a-794e-4af2-8a2d-d907c07007af", "AQAAAAEAACcQAAAAENUxkQLGCSTOuBzKyeVuQ6Q4hNqgvPv0NTvFfeT8gfM1J+PSQCOMCDBV0m9M1SHbdw==", "1a30ee00-3b38-447b-b0a8-8ce9bda7bf9c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "4af83f4b-8f3e-4790-8159-fa2df7c7a73e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "80d823ab-7079-4781-b05f-059f16256a41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3d0c697-a328-4ed9-acf0-99568462eb0b", "AQAAAAEAACcQAAAAECJq4MFVstSArMYh8MjTVAZHJGVC0W0rthAErP0YT5AHI0uVXRV6sLk1PT+za2Cp6g==", "435a2205-04a1-4d15-9226-716ff73f3370" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a5283d-7820-4898-8cea-db32a8d6b3b2", "AQAAAAEAACcQAAAAEMkZnj1TVlDH6idr8XZBt4+GXCRjKuiiroKSDYFBdZUFvUOyr94qQfz72F6C0eFu7w==", "fcb86119-8983-4a00-a2e3-1085b9659c36" });
        }
    }
}
