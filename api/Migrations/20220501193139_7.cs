using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _7 : Migration
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

            migrationBuilder.RenameColumn(
                name: "Tile",
                table: "coupons",
                newName: "Title");

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

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4111), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4115), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4117), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4118), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3643), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3662), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(3664), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PictureUrl", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4082), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "https://random.imagecdn.app/500/150", "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 1, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4231), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4222), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4221), "Cupom 1", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 2, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4236), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4235), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4234), "Cupom 2", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 3, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4239), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4238), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4237), "Cupom 3", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 4, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4243), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4241), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4241), "Cupom 4", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 5, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4246), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4244), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4244), "Cupom 5", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 6, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4250), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4248), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4247), "Cupom 6", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 7, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4253), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 29, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4251), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4250), "Cupom 7", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 8, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4256), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4254), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4253), "Cupom 8", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 9, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4259), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4257), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4257), "Cupom 9", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 10, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4262), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4261), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4260), "Cupom 10", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt", "Title", "UseLimiteDate" },
                values: new object[] { 11, null, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4265), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 5, 6, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4264), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4263), "Cupom 11", new DateTime(2022, 5, 16, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4191), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4193), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4194), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4196), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4197), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4198), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4199), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4200), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4201), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4285), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4286), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4287), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4289), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4321), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4323), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 5, 1, 16, 31, 12, 190, DateTimeKind.Local).AddTicks(4324), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "coupons",
                newName: "Tile");

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

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3565), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3558), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3568), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3588), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3582), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3580), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3592), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3612), new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3605), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3604), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3625), new DateTime(2022, 4, 29, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3617), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4004), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4019), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4008), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4025), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4023), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt", "UseLimiteDate" },
                values: new object[] { new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 5, 6, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4034), new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4033), new DateTime(2022, 5, 16, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 5, 1, 16, 11, 10, 302, DateTimeKind.Local).AddTicks(2891));
        }
    }
}
