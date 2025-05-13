using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WandleWheelhouse.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddContactInquiriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInquiries",
                columns: table => new
                {
                    ContactInquiryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    OrganizationName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    TourGroupType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PreferredTourDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NumberOfAttendees = table.Column<int>(type: "INTEGER", nullable: true),
                    Message = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsArchived = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInquiries", x => x.ContactInquiryId);
                    table.ForeignKey(
                        name: "FK_ContactInquiries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInquiries_IsArchived",
                table: "ContactInquiries",
                column: "IsArchived");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInquiries_SubmittedAt",
                table: "ContactInquiries",
                column: "SubmittedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInquiries_Type",
                table: "ContactInquiries",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInquiries_UserId",
                table: "ContactInquiries",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInquiries");
        }
    }
}
