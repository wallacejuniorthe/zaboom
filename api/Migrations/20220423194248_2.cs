using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _2 : Migration
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

            migrationBuilder.DropColumn(
                name: "Activate",
                table: "coupons_users");

            migrationBuilder.DropColumn(
                name: "Used",
                table: "coupons_users");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActivatedDate",
                table: "coupons_users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UseDate",
                table: "coupons_users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5805), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5812), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5814), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5758), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5762), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5765), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5767), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5706), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5727), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5728), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5730), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 1, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5887), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5878), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 2, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5891), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5890), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 3, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5894), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 8, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5893), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 4, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5897), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 8, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5896), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 5, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5899), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5898), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 6, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5902), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5901), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 7, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5905), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5904), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 8, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5908), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5907), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 9, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5910), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5909), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 10, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5913), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5913), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 11, null, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5955), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5915), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5840), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5842), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5843), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5845), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5846), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5847), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5848), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5850), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5851), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5980), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5981), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5983), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5984), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5985), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5986), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5987), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivatedDate",
                table: "coupons_users");

            migrationBuilder.DropColumn(
                name: "UseDate",
                table: "coupons_users");

            migrationBuilder.AddColumn<bool>(
                name: "Activate",
                table: "coupons_users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Used",
                table: "coupons_users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6557), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6613), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6616), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Verified" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6618), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6668), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 5, 8, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6672), new DateTime(2022, 5, 8, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6671), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6673), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6677), new DateTime(2022, 4, 21, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6676), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6679), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6678), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6682), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6681), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 4, 28, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6683), new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 15, 45, 43, 437, DateTimeKind.Local).AddTicks(6508));
        }
    }
}
