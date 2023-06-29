using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project_final.Migrations
{
    public partial class Generating_database_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    billId = table.Column<string>(nullable: false),
                    data_of_sale = table.Column<DateTime>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    billType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.billId);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleId = table.Column<string>(nullable: false),
                    role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    product_name = table.Column<string>(nullable: false),
                    quentity = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    discount = table.Column<double>(nullable: false),
                    data_of_sale = table.Column<DateTime>(nullable: false),
                    userId = table.Column<string>(nullable: false),
                    billId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.id);
                    table.ForeignKey(
                        name: "FK_sales_Bill_billId",
                        column: x => x.billId,
                        principalTable: "Bill",
                        principalColumn: "billId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    product_name = table.Column<string>(nullable: false),
                    product_description = table.Column<string>(nullable: true),
                    quintity = table.Column<int>(nullable: false),
                    price_of_sale = table.Column<double>(nullable: false),
                    price_of_purchase = table.Column<double>(nullable: false),
                    profit = table.Column<double>(nullable: false),
                    date_of_purchase = table.Column<DateTime>(nullable: false),
                    userId = table.Column<string>(nullable: false),
                    billId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.id);
                    table.ForeignKey(
                        name: "FK_stores_Bill_billId",
                        column: x => x.billId,
                        principalTable: "Bill",
                        principalColumn: "billId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stores_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usersRoles",
                columns: table => new
                {
                    userRolesId = table.Column<string>(nullable: false),
                    userId = table.Column<string>(nullable: false),
                    roleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usersRoles", x => x.userRolesId);
                    table.ForeignKey(
                        name: "FK_usersRoles_roles_roleId",
                        column: x => x.roleId,
                        principalTable: "roles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usersRoles_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sales_billId",
                table: "sales",
                column: "billId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_userId",
                table: "sales",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_stores_billId",
                table: "stores",
                column: "billId");

            migrationBuilder.CreateIndex(
                name: "IX_stores_userId",
                table: "stores",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_usersRoles_roleId",
                table: "usersRoles",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_usersRoles_userId",
                table: "usersRoles",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "usersRoles");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
