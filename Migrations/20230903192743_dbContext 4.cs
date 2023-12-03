using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingAttendanceAutomation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbContext4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdc00bb8-315b-4a48-b0b4-291bc3ce8187"));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("b3f8339d-7e4b-4a4f-b2e2-f91520dc2071"), new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(5397), 1, new DateTime(2023, 9, 3, 22, 27, 43, 436, DateTimeKind.Local).AddTicks(5399), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3f8339d-7e4b-4a4f-b2e2-f91520dc2071"));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("fdc00bb8-315b-4a48-b0b4-291bc3ce8187"), new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8667), 1, new DateTime(2023, 9, 3, 17, 45, 14, 473, DateTimeKind.Local).AddTicks(8670), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });
        }
    }
}
