using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_App.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointmnets",
                columns: table => new
                {
                    AppointmentId = table.Column<string>(nullable: false),
                    PatientName = table.Column<string>(maxLength: 100, nullable: false),
                    ProviderName = table.Column<string>(nullable: false),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    AppointmentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointmnets", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "PatientRegistrations",
                columns: table => new
                {
                    MedicalRecordNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: false),
                    InsuranceDetails = table.Column<string>(maxLength: 200, nullable: false),
                    MedicalHistory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRegistrations", x => x.MedicalRecordNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointmnets");

            migrationBuilder.DropTable(
                name: "PatientRegistrations");
        }
    }
}
