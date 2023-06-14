using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Layer.Migrations
{
    public partial class new_mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99670b3e-368f-4b26-b2a8-df928bcab9dd", new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1991), "AQAAAAEAACcQAAAAENpxPLpM31AsSVoCHyRg9egjK+58lPlSAJvlIWGExaC8Lv2oU0K/DgzivnE0zp8uhw==", "f2cc0580-e68d-45b1-83e1-71ad6d903e21" });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 1, (byte)1 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)2 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)3 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExamTime" },
                values: new object[] { new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 6, 21, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 14, 20, 59, 39, 105, DateTimeKind.Local).AddTicks(1751));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79bd127d-d2b3-4f9a-940e-11b938654bcb", new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5967), "AQAAAAEAACcQAAAAEP3a62kUC53aKEOzWzGL+mkqVSuv2hzedkY3U1nMFxbolwY2LTpjO4nXwEp1P2LVfw==", "8051f6f8-ac3f-4558-ae05-fbe4d5282250" });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 1, (byte)1 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)2 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)3 },
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExamTime" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 6, 19, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5689));
        }
    }
}
