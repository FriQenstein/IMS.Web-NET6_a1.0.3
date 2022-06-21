using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class amendedLeaveAllocationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "7c370819-3cd2-4843-897f-fd3b950911c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "9e713a52-084d-4b7d-a95c-61caa4be3398");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ac9d7a-e842-4edd-a948-cf948e2bb33b", "AQAAAAEAACcQAAAAEMcXpQmwYPlmW9MgHCEhRER4fjMdvyU5a3QvgbKlaOkNq+h+vzBqj6r5WCKbpYpwiw==", "ef8785ec-9ba5-4064-a84d-06c48fe8be5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c152fe7b-23d0-4559-9c1c-4add8672851f", "AQAAAAEAACcQAAAAELUQLXRCdU2lFLxETADoSSll99hpCR1PL9yFqLKVadyGdCKV4ubxctpkTaRIevVJiA==", "20571f0d-722a-4df8-bc54-78f0f724e5e8" });
        }
    }
}
