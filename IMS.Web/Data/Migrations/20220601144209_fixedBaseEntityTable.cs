using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class fixedBaseEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "c969ab24-bd81-4f83-a497-53111f637b60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "6543692f-94f0-47e2-a2af-eb1e34e719a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03c3cfd7-ff45-472b-81fe-57db72f4f6c5", "AQAAAAEAACcQAAAAEKx6E6gA2k4KfMMsZOLZX+mkQcxCbzCYEUJI/Vz0v6sH6cedNPgQdo3HGG2IXz3BQQ==", "c7617c83-02a7-4092-97ae-b22979433dba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fe62e31-757e-4125-a285-167ca20dd06f", "AQAAAAEAACcQAAAAEHBgaUpn8HrpDgSPminPbFiUxjOQMdk1vBT+D7KedSIA2DFGv829ZWS6ttUafbb2QQ==", "39504b7b-61f5-48ad-8097-510e5e1dfecf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "7686afe8-cc28-4592-b3c4-0095a760ee6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "0a0f2c08-87c3-4dbb-a966-fa4d988a96e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f9c01c-c792-4216-ad82-72d92528ff5e", "AQAAAAEAACcQAAAAEBTUBcwLtRXIYAgWej+aTltbBMpNSvYg371lybwpUoCc6QITeYiNDliS1cGEsrSq2g==", "1a152257-9f69-43da-8a75-8d4dede2b04a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fffe2a65-aa3e-4858-9a6c-533789208bef", "AQAAAAEAACcQAAAAEDBThpYmxGwRtjkKeammusgBE+pMaDMfeM8oVITo4xfGPuKB9p1QUapbwQN5KTC8Yg==", "08a75aee-17e5-416a-959b-d868b7d34f62" });
        }
    }
}
