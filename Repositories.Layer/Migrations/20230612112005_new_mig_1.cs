using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Layer.Migrations
{
    public partial class new_mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "CourseCalendars",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "CourseCalendars",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5404), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)2 },
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5415), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)3 },
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 12, 14, 20, 4, 718, DateTimeKind.Local).AddTicks(5416), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "CourseCalendars",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "CourseCalendars",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8337a20-9eb7-401a-a362-10da43576001", new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2690), "AQAAAAEAACcQAAAAEHxLFactCHEegJS13SbzU5oTVMNnPn6qNnhW4c8j8yAYDjz+TwGSL94J2EoTavZp6g==", "1eae3438-6e91-41dd-8e82-43ee1ea9e727" });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 1, (byte)1 },
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)2 },
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "CourseCalendars",
                keyColumns: new[] { "CourseId", "DayId" },
                keyValues: new object[] { 2, (byte)3 },
                columns: new[] { "CreatedDate", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExamTime" },
                values: new object[] { new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 6, 12, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "CourseDetails",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 22, 14, 37, 554, DateTimeKind.Local).AddTicks(2478));
        }
    }
}
