using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Phone1 = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Phone1Verified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    AcceptTerms = table.Column<bool>(type: "INTEGER", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    VerificationToken = table.Column<string>(type: "TEXT", nullable: true),
                    Verified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ResetToken = table.Column<string>(type: "TEXT", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PasswordReset = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "event_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    Expires = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedByIp = table.Column<string>(type: "TEXT", nullable: true),
                    Revoked = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RevokedByIp = table.Column<string>(type: "TEXT", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "TEXT", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cnpj = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Contact = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Phone1 = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone2 = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AreaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    Street = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Details = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    District = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_participants_areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Key1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Key2 = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_events_event_types_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "event_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cnpj = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Regulation = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Contact = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Phone1 = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone2 = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SegmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    Street = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Details = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    District = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_partners_segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "participants_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParticipantId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participants_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_participants_users_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_participants_users_participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PartnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Regulation = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    QuantityUsed = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantityMaxUse = table.Column<int>(type: "INTEGER", nullable: true),
                    QuantityMaxUseUser = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FinishAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CanceledAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastUse = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coupons_partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coupons_participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CouponId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipantId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons_participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coupons_participants_coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coupons_participants_participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coupons_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CouponId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    Activate = table.Column<bool>(type: "INTEGER", nullable: false),
                    Used = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coupons_users_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coupons_users_coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 1, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6553), "User1@teste.com", "User1", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 2, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6557), "User2@teste.com", "User2", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 3, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6610), "User3@teste.com", "User3", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", null });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 4, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6611), "User4@teste.com", "User4", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", null });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 5, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6613), "User5@teste.com", "User5", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 6, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6614), "User6@teste.com", "User6", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 7, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6615), "User7@teste.com", "User7", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 8, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6616), "User8@teste.com", "User8", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "AcceptTerms", "Cpf", "Created", "Email", "Name", "PasswordHash", "PasswordReset", "Phone1", "Phone1Verified", "ResetToken", "ResetTokenExpires", "Role", "Updated", "VerificationToken", "Verified" },
                values: new object[] { 9, true, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6618), "User9@teste.com", "User9", "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q", null, null, null, null, null, 0, null, "583422", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.InsertData(
                table: "areas",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Area 1" });

            migrationBuilder.InsertData(
                table: "areas",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Area 2" });

            migrationBuilder.InsertData(
                table: "segments",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Segmento 1" });

            migrationBuilder.InsertData(
                table: "segments",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Segmento 2" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6529), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6532), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6533), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6533), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6485), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6505), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6507), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6508), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 1, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6666), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6660), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 2, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6669), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6668), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 3, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 8, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 4, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6672), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 8, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6671), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 5, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6674), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6673), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 6, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6675), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6675), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 7, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6677), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6676), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 8, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6679), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6678), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 9, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6680), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6680), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 10, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6682), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6681), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 11, null, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6684), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6683), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6636), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6637), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6637), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6638), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6639), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6640), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6640), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6641), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6641), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6699), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6700), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6700), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6701), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6702), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6702), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6703), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_Cpf",
                table: "accounts",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_areas_Description",
                table: "areas",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_coupons_PartnerId",
                table: "coupons",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_coupons_participants_CouponId_ParticipantId",
                table: "coupons_participants",
                columns: new[] { "CouponId", "ParticipantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_coupons_participants_ParticipantId",
                table: "coupons_participants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_AccountId",
                table: "coupons_users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_CouponId_AccountId",
                table: "coupons_users",
                columns: new[] { "CouponId", "AccountId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_event_types_Description",
                table: "event_types",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_events_EventTypeId",
                table: "events",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_participants_AreaId",
                table: "participants",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_participants_Cnpj",
                table: "participants",
                column: "Cnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_participants_users_AccountId_ParticipantId",
                table: "participants_users",
                columns: new[] { "AccountId", "ParticipantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_participants_users_ParticipantId",
                table: "participants_users",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_partners_Cnpj",
                table: "partners",
                column: "Cnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_partners_SegmentId",
                table: "partners",
                column: "SegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AccountId",
                table: "RefreshToken",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_segments_Description",
                table: "segments",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coupons_participants");

            migrationBuilder.DropTable(
                name: "coupons_users");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "participants_users");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "coupons");

            migrationBuilder.DropTable(
                name: "event_types");

            migrationBuilder.DropTable(
                name: "participants");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "partners");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropTable(
                name: "segments");
        }
    }
}
