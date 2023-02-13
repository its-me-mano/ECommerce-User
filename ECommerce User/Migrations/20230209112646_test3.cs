using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_User.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CVV", "CardNumber", "CardholderName", "CreateBy", "DateCreated", "DateUpdated", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("ef5e2a13-0ea6-4c83-a6a3-571e6ae79c60"), "123", "123456789101", "Keerthi varman", new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(1329), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") },
                    { new Guid("491274fa-cb0e-459e-a5d1-f4b45a22349a"), "321", "123098456712", "RamPrasath", new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(1942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") }
                });

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

            migrationBuilder.InsertData(
                table: "UPIS",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "UPIID", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("abf127e7-ff34-4ac1-9a95-083f70047d14"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(598), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234567891@apl", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") },
                    { new Guid("43c85934-796f-4bee-b858-066d04a18f1d"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 9, 16, 56, 46, 462, DateTimeKind.Local).AddTicks(637), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234567821@apl", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("491274fa-cb0e-459e-a5d1-f4b45a22349a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ef5e2a13-0ea6-4c83-a6a3-571e6ae79c60"));

            migrationBuilder.DeleteData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("43c85934-796f-4bee-b858-066d04a18f1d"));

            migrationBuilder.DeleteData(
                table: "UPIS",
                keyColumn: "Id",
                keyValue: new Guid("abf127e7-ff34-4ac1-9a95-083f70047d14"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 100, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("19fca541-c259-4cd7-91ab-e16557ba12b0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("99a1c931-2a2b-45a2-883b-a020d4f0e3ae"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 101, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 99, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 9, 16, 50, 51, 98, DateTimeKind.Local).AddTicks(3078));
        }
    }
}
