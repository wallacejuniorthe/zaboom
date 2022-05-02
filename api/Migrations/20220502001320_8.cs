using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _8 : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "coupons_users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7368), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7371), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7376), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7381), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7328), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7332), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7334), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7335), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7244), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7262), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7265), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7266), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 1, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7448), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7436), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7435), "Cupom 1", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 2, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7453), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7452), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7451), "Cupom 2", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 3, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7457), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7455), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7455), "Cupom 3", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 4, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7460), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7458), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7458), "Cupom 4", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 5, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7463), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 29, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7461), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7461), "Cupom 5", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 6, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7466), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 29, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7465), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7464), "Cupom 6", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 7, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7469), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 29, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7468), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7467), "Cupom 7", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 8, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7474), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7472), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7471), "Cupom 8", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 9, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7477), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7475), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7474), "Cupom 9", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 10, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7480), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7478), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7478), "Cupom 10", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 11, null, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7483), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 5, 6, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7481), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7481), "Cupom 11", new DateTime(2022, 5, 16, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7405), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7407), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7409), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7410), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7411), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7412), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7413), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7414), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7415), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7505), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7507), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7508), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7509), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7510), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7511), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 5, 1, 21, 13, 17, 865, DateTimeKind.Local).AddTicks(7512), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "coupons_users");

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4150), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4152), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4157), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4158), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4161), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4162), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4164), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4231), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4222), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4221), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4234), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4239), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4238), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4237), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4243), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4248), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4247), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4253), new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4256), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4254), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4253), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4259), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4261), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4264), new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4082));
        }
    }
}
