using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingAttendanceAutomation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbContext3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BranchUsers",
                columns: table => new
                {
                    BranchesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchUsers", x => new { x.BranchesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BranchUsers_Branch_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchUsers_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BranchUsers_UsersId",
                table: "BranchUsers",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchUsers");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdc00bb8-315b-4a48-b0b4-291bc3ce8187"));

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 17, 29, 15, 755, DateTimeKind.Local).AddTicks(4846));

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
    }
}
