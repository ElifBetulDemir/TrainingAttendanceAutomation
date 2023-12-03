using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingAttendanceAutomation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbContext2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Users_UsersId",
                table: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_Branch_UsersId",
                table: "Branch");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa4114ad-4516-4b2a-9b59-7dd95d9ee612"));

            migrationBuilder.AlterColumn<string>(
                name: "UsersId",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UsersId" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4846), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("2a051eb2-5db2-45a0-a007-a95c1dab7139"), new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4640), 1, new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4641), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId",
                unique: true,
                filter: "[BranchId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BranchId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a051eb2-5db2-45a0-a007-a95c1dab7139"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UsersId",
                table: "Branch",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UsersId" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(3514), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("aa4114ad-4516-4b2a-9b59-7dd95d9ee612"), new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(3296), 1, new DateTime(2023, 9, 3, 17, 23, 57, 56, DateTimeKind.Local).AddTicks(3298), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_UsersId",
                table: "Branch",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Users_UsersId",
                table: "Branch",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
