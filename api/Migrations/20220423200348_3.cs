using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_coupons_users_CouponId_AccountId",
                table: "coupons_users");

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

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 1, 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1390), null, "Bairro", "Participant1@teste.com", "Participant1", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 2, 1, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1395), null, "Bairro", "Participant2@teste.com", "Participant2", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 3, 1, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1398), null, "Bairro", "Participant3@teste.com", "Participant3", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "participants",
                columns: new[] { "Id", "AreaId", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "State", "Street" },
                values: new object[] { 4, 1, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1400), null, "Bairro", "Participant4@teste.com", "Participant4", null, "Phone1", null, "64014050", "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 1, "Teresina", "123456", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1324), null, "Bairro", "Empresa1@teste.com", "Empresa1", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 2, "Teresina", "1234567", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1348), null, "Bairro", "Empresa2@teste.com", "Empresa2", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 3, "Teresina", "1234568", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1351), null, "Bairro", "Empresa3@teste.com", "Empresa3", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "partners",
                columns: new[] { "Id", "City", "Cnpj", "Comments", "Contact", "CreatedAt", "Details", "District", "Email", "Name", "Number", "Phone1", "Phone2", "PostalCode", "Regulation", "SegmentId", "State", "Street" },
                values: new object[] { 4, "Teresina", "12345699", null, "Contato", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1353), null, "Bairro", "Empresa4@teste.com", "Empresa4", null, "Phone1", null, "64014050", null, 1, "PI", "Rua X" });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 1, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1605), "Cupom 1 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1596), null, 1, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 2, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1611), "Cupom 2 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1610), null, 1, 50, 5, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 3, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1614), "Cupom 3 - dewr rewrr rer", new DateTime(2022, 5, 8, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1613), null, 1, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 4, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1617), "Cupom 4 - dewr rewrr rer", new DateTime(2022, 5, 8, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1616), null, 2, null, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 5, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1620), "Cupom 5 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1619), null, 2, null, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 6, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1623), "Cupom 6 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1622), null, 2, 50, null, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 7, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1626), "Cupom 7 - dewr rewrr rer", new DateTime(2022, 4, 21, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1625), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 8, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1630), "Cupom 8 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1628), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 9, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1633), "Cupom 9 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1632), null, 3, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 10, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1636), "Cupom 10 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1635), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.InsertData(
                table: "coupons",
                columns: new[] { "Id", "CanceledAt", "CreatedAt", "Description", "FinishAt", "LastUse", "PartnerId", "QuantityMaxUse", "QuantityMaxUseUser", "QuantityUsed", "Regulation", "StartAt" },
                values: new object[] { 11, null, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1639), "Cupom 11 - dewr rewrr rer", new DateTime(2022, 4, 28, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1638), null, 4, 50, 1, 0, "Resulamento xx xx x x", new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1492), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1494), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 3, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1495), 1 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 4, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1497), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 5, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1498), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 6, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1499), 2 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 7, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1501), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 8, 8, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1502), 3 });

            migrationBuilder.InsertData(
                table: "participants_users",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ParticipantId" },
                values: new object[] { 9, 9, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1559), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1675), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1677), 2 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 3, 1, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1678), 3 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 4, 2, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1680), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 5, 3, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1681), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 6, 4, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1683), 1 });

            migrationBuilder.InsertData(
                table: "coupons_participants",
                columns: new[] { "Id", "CouponId", "CreatedAt", "ParticipantId" },
                values: new object[] { 7, 5, new DateTime(2022, 4, 23, 17, 3, 30, 994, DateTimeKind.Local).AddTicks(1684), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_CouponId",
                table: "coupons_users",
                column: "CouponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_coupons_users_CouponId",
                table: "coupons_users");

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

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5887), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5878), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5891), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5894), new DateTime(2022, 5, 8, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5893), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 5, 8, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5896), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5899), new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5898), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5902), new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5901), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 4, 21, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5908), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5909), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5913), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5913), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishAt", "StartAt" },
                values: new object[] { new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5955), new DateTime(2022, 4, 28, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5915), new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "coupons_participants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "participants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "participants_users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "partners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 23, 16, 42, 28, 487, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_CouponId_AccountId",
                table: "coupons_users",
                columns: new[] { "CouponId", "AccountId" },
                unique: true);
        }
    }
}
