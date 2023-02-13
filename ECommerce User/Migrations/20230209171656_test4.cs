using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_User.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "UPIS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Cards",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("491274fa-cb0e-459e-a5d1-f4b45a22349a"),
                columns: new[] { "DateCreated", "type" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(475), "razor" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ef5e2a13-0ea6-4c83-a6a3-571e6ae79c60"),
                columns: new[] { "DateCreated", "type" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(9696), "visa" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("19fca541-c259-4cd7-91ab-e16557ba12b0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("99a1c931-2a2b-45a2-883b-a020d4f0e3ae"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 810, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("43c85934-796f-4bee-b858-066d04a18f1d"),
                columns: new[] { "DateCreated", "type" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(9030), "paytm" });

            migrationBuilder.UpdateData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("abf127e7-ff34-4ac1-9a95-083f70047d14"),
                columns: new[] { "DateCreated", "type" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 46, 55, 809, DateTimeKind.Local).AddTicks(8799), "gpay" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 808, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 22, 46, 55, 807, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.CreateIndex(
                name: "IX_UPIS_UserId",
                table: "UPIS",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UPIS_Users_UserId",
                table: "UPIS",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_UPIS_Users_UserId",
                table: "UPIS");

            migrationBuilder.DropIndex(
                name: "IX_UPIS_UserId",
                table: "UPIS");

            migrationBuilder.DropIndex(
                name: "IX_Cards_UserId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "type",
                table: "UPIS");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Cards");

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("491274fa-cb0e-459e-a5d1-f4b45a22349a"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ef5e2a13-0ea6-4c83-a6a3-571e6ae79c60"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 461, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("19fca541-c259-4cd7-91ab-e16557ba12b0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("99a1c931-2a2b-45a2-883b-a020d4f0e3ae"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 463, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("43c85934-796f-4bee-b858-066d04a18f1d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("abf127e7-ff34-4ac1-9a95-083f70047d14"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 460, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 56, 46, 459, DateTimeKind.Local).AddTicks(4459));
        }
    }
}
