using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _6 : Migration
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
                name: "Tile",
                table: "coupons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3183), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2983), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2997), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3002), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3007), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2836), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2881), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2886), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2891), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 1, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3546), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3394), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3392), "Cupom 1", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 2, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3565), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3560), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3558), "Cupom 2", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 3, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3578), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3570), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3568), "Cupom 3", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 4, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3588), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3582), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3580), "Cupom 4", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 5, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3600), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3594), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3592), "Cupom 5", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 6, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3612), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3605), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3604), "Cupom 6", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 7, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3625), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3619), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3617), "Cupom 7", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 8, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4004), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3630), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3629), "Cupom 8", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 9, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4019), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4010), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4008), "Cupom 9", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 10, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4030), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4025), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4023), "Cupom 10", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Tile", "UseLimiteDate" },
                values: new object[] { 11, null, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4039), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4034), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4033), "Cupom 11", new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3284), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3290), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3294), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3297), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3300), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3303), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3306), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3308), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3312), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4267), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4272), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4275), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4278), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4281), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4284), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4287), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tile",
                table: "coupons");

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

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2078), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2101), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2098), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2107), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2103), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2112), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2118), new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2115), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2114), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2422), new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2419), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2475), new DateTime(2022, 4, 28, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2472), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2478), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2489), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2491), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2499), new DateTime(2022, 5, 5, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2497), new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 5, 15, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 30, 15, 21, 45, 781, DateTimeKind.Local).AddTicks(1783));
        }
    }
}
