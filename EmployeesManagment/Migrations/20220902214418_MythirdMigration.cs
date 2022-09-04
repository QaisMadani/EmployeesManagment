using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesManagment.Migrations
{
    public partial class MythirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeesActivity",
                newName: "EmployeeRefId");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "EmployeesActivity",
                newName: "EmployeeId1");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employees",
                newName: "DepartmentRefId");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "Employees",
                newName: "CardRefId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Cards",
                newName: "EmployeeRefId");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "Attendance",
                newName: "CardRefId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Activities",
                newName: "DepartmentRefId");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId1",
                table: "EmployeesActivity",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ActivityRefId",
                table: "EmployeesActivity",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CardId1",
                table: "Attendance",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "Activities",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesActivity_ActivityId1",
                table: "EmployeesActivity",
                column: "ActivityId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesActivity_EmployeeId1",
                table: "EmployeesActivity",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_EmployeeId1",
                table: "Cards",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_CardId1",
                table: "Attendance",
                column: "CardId1");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DepartmentId1",
                table: "Activities",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Departments_DepartmentId1",
                table: "Activities",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Cards_CardId1",
                table: "Attendance",
                column: "CardId1",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Employees_EmployeeId1",
                table: "Cards",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesActivity_Activities_ActivityId1",
                table: "EmployeesActivity",
                column: "ActivityId1",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesActivity_Employees_EmployeeId1",
                table: "EmployeesActivity",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Departments_DepartmentId1",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Cards_CardId1",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Employees_EmployeeId1",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesActivity_Activities_ActivityId1",
                table: "EmployeesActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesActivity_Employees_EmployeeId1",
                table: "EmployeesActivity");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesActivity_ActivityId1",
                table: "EmployeesActivity");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesActivity_EmployeeId1",
                table: "EmployeesActivity");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Cards_EmployeeId1",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_CardId1",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Activities_DepartmentId1",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ActivityId1",
                table: "EmployeesActivity");

            migrationBuilder.DropColumn(
                name: "ActivityRefId",
                table: "EmployeesActivity");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardId1",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "EmployeeRefId",
                table: "EmployeesActivity",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId1",
                table: "EmployeesActivity",
                newName: "ActivityId");

            migrationBuilder.RenameColumn(
                name: "DepartmentRefId",
                table: "Employees",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "CardRefId",
                table: "Employees",
                newName: "CardId");

            migrationBuilder.RenameColumn(
                name: "EmployeeRefId",
                table: "Cards",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "CardRefId",
                table: "Attendance",
                newName: "CardId");

            migrationBuilder.RenameColumn(
                name: "DepartmentRefId",
                table: "Activities",
                newName: "DepartmentId");
        }
    }
}
