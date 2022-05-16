using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addedDefaultUsersandRolesEdits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "f9059467-cfd8-400d-ac19-4dea9fec5cbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "2049921a-caba-4893-88c9-1bd751bb2f44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b59e7f0c-7c9b-4983-af28-19d4e08c1151", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHtw5GiDmtFryMxnQP1+FZif7DekkW9fJRY5XtvYc/NxNGIPQFYbFtruR00M5TnxOw==", "a3f1ee6e-30aa-442a-8b4e-648feb259342", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c6332c6f-a7dc-4ac0-94e3-85f14bf8cb3c", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEG/awasRfo1Remido2ArS1vudaXreEOXAggKv4L9TuVWlnxDE+aSEvZONbLYDkRh1g==", "096ab0f9-4aa1-4a72-9a78-7652ac240ee0", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "de78c3aa-0918-4a5d-83a3-c446c768c887");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "58a59b83-533e-48b6-9ee7-1067e2ce1802");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2a856fd1-2824-4238-a99d-4245bdaa01c9", false, null, "AQAAAAEAACcQAAAAEC84Vn1W7SOf7ikKcAP7SH3IBymFUuKvCUIlq6UZflQlQ2wqvkPf/5rNHzzuUaqXtw==", "1a764430-9ae4-4344-9b67-b2fdccd498a9", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "adf3d30e-7a85-4234-9feb-d42ce0913461", false, null, "AQAAAAEAACcQAAAAED2R46pma4XiCr92hlJR7mps8JGsgVEPKU3m/fqRDF9QrTIcUbD3VCQvP/DTJBCzDg==", "c7a5be34-8fda-49f7-91f3-9a42c1b5081e", null });
        }
    }
}
