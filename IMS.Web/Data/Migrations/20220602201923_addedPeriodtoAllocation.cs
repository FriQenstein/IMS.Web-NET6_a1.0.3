using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Web.Data.Migrations
{
    public partial class addedPeriodtoAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                column: "ConcurrencyStamp",
                value: "de0b6c14-c37e-4e07-98c0-d9cbcf89e919");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                column: "ConcurrencyStamp",
                value: "61df48c8-34d7-4ddb-a503-4a2e1ad29b99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1100acdc2-c69c-abba-bac2-d5f719ffffaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17447ae-74f1-46da-ab26-ecf160bbda12", "AQAAAAEAACcQAAAAELwkNtIpi6qg2o33KnVLs4k5FpSQgIiLrMZwtMFRnmCDt65IEQCHCz6bXjZKkAlebw==", "0de361a6-e0d5-4f2f-bacb-4a1cb12ffc86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6a3758-0e70-4086-bc75-adb547515fe3", "AQAAAAEAACcQAAAAEBcfk9wrcM/OOjQeGxpBrrql9kWyr8X9qXRv/8OgOpxAQm0FafQQcC2TfNyPhMNr0Q==", "4aec9967-fbe0-491e-8ce4-b4d6cd2903ff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocation");

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
    }
}
