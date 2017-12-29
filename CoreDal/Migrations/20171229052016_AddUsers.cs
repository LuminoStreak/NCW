using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreDal.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserDepartment_UserDepartmentId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDepartment",
                table: "UserDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "UserDepartment",
                newName: "UserDepartments");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserDepartmentId",
                table: "Users",
                newName: "IX_Users_UserDepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserDepartments_UserDepartmentId",
                table: "Users",
                column: "UserDepartmentId",
                principalTable: "UserDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserDepartments_UserDepartmentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserDepartments",
                newName: "UserDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserDepartmentId",
                table: "User",
                newName: "IX_User_UserDepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDepartment",
                table: "UserDepartment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserDepartment_UserDepartmentId",
                table: "User",
                column: "UserDepartmentId",
                principalTable: "UserDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
