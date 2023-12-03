using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingAttendanceAutomation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c28f281-3f36-4f98-b1cc-8c9a5a2ecde9"));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("437617ce-4f3e-44e9-8d8d-a9412d4a3d0a"), new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(7938), 1, new DateTime(2023, 9, 4, 21, 40, 24, 649, DateTimeKind.Local).AddTicks(7939), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("437617ce-4f3e-44e9-8d8d-a9412d4a3d0a"));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("7c28f281-3f36-4f98-b1cc-8c9a5a2ecde9"), new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8360), 1, new DateTime(2023, 9, 4, 21, 21, 23, 426, DateTimeKind.Local).AddTicks(8361), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });
        }
    }
}
