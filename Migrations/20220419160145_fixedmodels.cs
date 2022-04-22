using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerPortal.Migrations
{
    public partial class fixedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ColumnID",
                table: "Elevator");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "BatteryID",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "BuildingID",
                table: "Battery");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Battery");

            migrationBuilder.AddColumn<int>(
                name: "BatteryId",
                table: "Employee",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Customer",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElevatorId",
                table: "Column",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatteryId",
                table: "Building",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastInspectionDate",
                table: "Battery",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommissionDate",
                table: "Battery",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColumnId",
                table: "Battery",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BatteryId",
                table: "Employee",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_BuildingId",
                table: "Customer",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Column_ElevatorId",
                table: "Column",
                column: "ElevatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BatteryId",
                table: "Building",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Battery_ColumnId",
                table: "Battery",
                column: "ColumnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battery_Column_ColumnId",
                table: "Battery",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Battery_BatteryId",
                table: "Building",
                column: "BatteryId",
                principalTable: "Battery",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Elevator_ElevatorId",
                table: "Column",
                column: "ElevatorId",
                principalTable: "Elevator",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Building_BuildingId",
                table: "Customer",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Battery_BatteryId",
                table: "Employee",
                column: "BatteryId",
                principalTable: "Battery",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battery_Column_ColumnId",
                table: "Battery");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_Battery_BatteryId",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Elevator_ElevatorId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Building_BuildingId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Battery_BatteryId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BatteryId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Customer_BuildingId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Column_ElevatorId",
                table: "Column");

            migrationBuilder.DropIndex(
                name: "IX_Building_BatteryId",
                table: "Building");

            migrationBuilder.DropIndex(
                name: "IX_Battery_ColumnId",
                table: "Battery");

            migrationBuilder.DropColumn(
                name: "BatteryId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ElevatorId",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "BatteryId",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Battery");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Employee",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColumnID",
                table: "Elevator",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Customer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Customer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BatteryID",
                table: "Column",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Building",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Building",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastInspectionDate",
                table: "Battery",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommissionDate",
                table: "Battery",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "BuildingID",
                table: "Battery",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Battery",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}