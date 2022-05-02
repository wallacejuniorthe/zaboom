using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "UseLimiteDate",
                table: "coupons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8427), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8449), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8453), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8458), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8463), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8469), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8325), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8334), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8341), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8346), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8070), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8110), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8241), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8249), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 1, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8657), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8642), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 2, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8682), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8677), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8676), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 3, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8689), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8685), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8684), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 4, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8697), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8693), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8692), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 5, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8707), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8702), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8701), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 6, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8715), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8711), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 7, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8724), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8719), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 8, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8732), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8728), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 9, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8740), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8737), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8735), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 10, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8747), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8744), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8742), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 11, null, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8755), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8751), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8544), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8549), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8552), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8555), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8558), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8560), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8563), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8565), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8567), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8818), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8822), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8825), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8828), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8894), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8897), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8899), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseLimiteDate",
                table: "coupons");

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1438), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1442), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1448), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1451), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1454), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1456), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1596), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1611), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1610), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 5, 8, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1613), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1617), new DateTime(2022, 5, 8, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1616), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1619), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1623), new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1622), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1625), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1628), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1632), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1638), new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1353));
        }
    }
}
