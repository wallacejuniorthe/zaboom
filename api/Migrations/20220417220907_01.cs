using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coupons_uses");

            migrationBuilder.RenameColumn(
                name: "QuantityUseUser",
                table: "coupons",
                newName: "QuantityUsed");

            migrationBuilder.RenameColumn(
                name: "QuantityUse",
                table: "coupons",
                newName: "QuantityMaxUseUser");

            migrationBuilder.RenameColumn(
                name: "FisishAt",
                table: "coupons",
                newName: "LastUse");

            migrationBuilder.AddColumn<DateTime>(
                name: "CanceledAt",
                table: "coupons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishAt",
                table: "coupons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityMaxUse",
                table: "coupons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Phone1Verified",
                table: "accounts",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_AccountId",
                table: "coupons_users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_coupons_users_CouponId_AccountId",
                table: "coupons_users",
                columns: new[] { "CouponId", "AccountId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coupons_users");

            migrationBuilder.DropColumn(
                name: "CanceledAt",
                table: "coupons");

            migrationBuilder.DropColumn(
                name: "FinishAt",
                table: "coupons");

            migrationBuilder.DropColumn(
                name: "QuantityMaxUse",
                table: "coupons");

            migrationBuilder.DropColumn(
                name: "Phone1Verified",
                table: "accounts");

            migrationBuilder.RenameColumn(
                name: "QuantityUsed",
                table: "coupons",
                newName: "QuantityUseUser");

            migrationBuilder.RenameColumn(
                name: "QuantityMaxUseUser",
                table: "coupons",
                newName: "QuantityUse");

            migrationBuilder.RenameColumn(
                name: "LastUse",
                table: "coupons",
                newName: "FisishAt");

            migrationBuilder.CreateTable(
                name: "coupons_uses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    CouponId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons_uses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coupons_uses_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coupons_uses_coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coupons_uses_AccountId",
                table: "coupons_uses",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_coupons_uses_CouponId_AccountId",
                table: "coupons_uses",
                columns: new[] { "CouponId", "AccountId" },
                unique: true);
        }
    }
}
