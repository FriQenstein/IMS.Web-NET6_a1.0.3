using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class updatedRequestCommentstoNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "096e2c19-cc6b-4a2f-8e4e-e527ba8ce21e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "f0e668ec-94f4-4fd7-9409-6801d6e09b17");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc87eb21-b4a1-47b4-b022-f5796ee09c67", "AQAAAAEAACcQAAAAEInTvyY0s544BtwXfwA9wwttklPGkwjpFwnqmJWFKHuT2Z8a3VhT7jjRzysF7Z/whw==", "3eeb1559-0d72-4045-9dcf-c598ed8e6c42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c34ee49f-4b1b-4252-b990-af2424a311d4", "AQAAAAEAACcQAAAAEFMH+COrCGQPBLT/ru2ADJ6qAZR1q5464eWtMIWyoDdjU1rhTKRlO8eYYvxcstYEWQ==", "1d0d5972-7126-4291-b607-a16fb8768c29" });
        }
    }
}
