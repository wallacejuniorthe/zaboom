using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _5 : Migration
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
                name: "PictureUrl",
                table: "partners",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1886), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1898), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1901), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1905), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1826), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1835), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1839), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1841), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1748), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1778), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1780), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1783), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 1, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2090), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2079), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2078), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 2, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2101), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2098), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 3, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2107), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2104), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2103), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 4, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2112), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2109), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 5, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2118), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2115), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2114), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 6, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2422), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2420), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2419), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 7, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2475), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2472), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 8, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2480), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2478), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 9, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2489), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2483), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 10, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2494), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2492), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2491), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "UseLimiteDate" },
                values: new object[] { 11, null, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2499), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2497), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2025), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2028), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2030), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2032), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2033), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2035), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2037), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2039), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2041), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2542), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2545), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2547), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2549), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2551), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2552), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2554), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "partners");

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

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8657), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8677), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8676), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8689), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8685), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8684), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8697), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8693), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8692), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8707), new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8702), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8701), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8715), new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8711), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8724), new DateTime(2022, 4, 21, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8719), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8732), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8728), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8737), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8735), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8747), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8744), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8742), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8755), new DateTime(2022, 4, 28, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8751), new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 8, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 17, 27, 20, 472, DateTimeKind.Local).AddTicks(8249));
        }
    }
}
