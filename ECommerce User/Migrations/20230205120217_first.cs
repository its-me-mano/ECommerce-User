using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_User.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 515, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 515, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 516, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 517, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 514, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 5, 17, 25, 15, 513, DateTimeKind.Local).AddTicks(6828));
        }
    }
}
