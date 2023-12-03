using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingAttendanceAutomation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbContext1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchUsers");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("275c5432-c078-4c70-bc75-fe6bc0a428d5"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Branch",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Branch");

            migrationBuilder.CreateTable(
                name: "BranchUsers",
                columns: table => new
                {
                    BranchesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchUsers", x => new { x.BranchesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BranchUsers_Branch_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BranchId", "CreatedTime", "CreatedUserId", "DeleterUserId", "DeletionTime", "Email", "FirstName", "ImageUrl", "IsDeleted", "LastName", "Password", "PhoneNumber", "UserRoleId" },
                values: new object[] { new Guid("275c5432-c078-4c70-bc75-fe6bc0a428d5"), new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(1902), 1, new DateTime(2023, 9, 3, 14, 51, 30, 728, DateTimeKind.Local).AddTicks(1903), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "edip@gmail.com", "Edip", "Profil Resmi Edip.jpg", false, "YILMAZSOY", "Ey-2441559", "5547890002", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_BranchUsers_UserId",
                table: "BranchUsers",
                column: "UserId");
        }
    }
}
