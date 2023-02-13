using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_User.Migrations
{
    public partial class firstordefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 306, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[] { new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 6, 10, 52, 19, 307, DateTimeKind.Local).AddTicks(9119), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of users", "USER_ROLE", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.InsertData(
                table: "RefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Identify the person is admin
                ", "Admin", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(2705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Identify the person is User
                ", "User", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "RefSetid", "ReftermId", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("99a1c931-2a2b-45a2-883b-a020d4f0e3ae"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"), new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("19fca541-c259-4cd7-91ab-e16557ba12b0"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 6, 10, 52, 19, 308, DateTimeKind.Local).AddTicks(6780), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"), new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 305, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 6, 10, 52, 19, 304, DateTimeKind.Local).AddTicks(5946));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("29723b4d-d86c-431f-8e82-6cc8eeef0ed4"));

            migrationBuilder.DeleteData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3601bfeb-1103-4f49-98ba-712f55cee042"));

            migrationBuilder.DeleteData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("19fca541-c259-4cd7-91ab-e16557ba12b0"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("99a1c931-2a2b-45a2-883b-a020d4f0e3ae"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 837, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 838, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 836, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 32, 16, 835, DateTimeKind.Local).AddTicks(5422));
        }
    }
}
