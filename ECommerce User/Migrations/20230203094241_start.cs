using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_User.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CardholderName = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    CVV = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductQuantity = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Visibility = table.Column<Guid>(nullable: false),
                    ImageAsset = table.Column<Guid>(nullable: false),
                    Category = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetRefTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    RefSetid = table.Column<Guid>(nullable: false),
                    ReftermId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetRefTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPIS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    UPIID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPIS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    StateName = table.Column<string>(nullable: true),
                    Country = table.Column<Guid>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true),
                    Type = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    File = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 78, DateTimeKind.Local).AddTicks(713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of addresses
                ", "ADDRESS_TYPE", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a447a151-130e-46df-917b-d09976d2ebb5"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 78, DateTimeKind.Local).AddTicks(1213), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of phonenumber
                ", "PHONE_NUMBER_TYPE", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 78, DateTimeKind.Local).AddTicks(1261), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of emails
                ", "EMAIL_ADDRESS_TYPE", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 78, DateTimeKind.Local).AddTicks(1287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of countries
                ", "COUNTRY", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "RefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 80, DateTimeKind.Local).AddTicks(3086), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"It is used to the detail mentioned all about personal
                ", "PERSONAL", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 80, DateTimeKind.Local).AddTicks(3542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"The detail mentioned is all about Work based
                ", "WORK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 80, DateTimeKind.Local).AddTicks(3589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Country
                ", "INDIA", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 80, DateTimeKind.Local).AddTicks(3617), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Country
                ", "UNITED_STATES", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 80, DateTimeKind.Local).AddTicks(3641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Alternate number
                ", "ALTERNATE", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "RefSetid", "ReftermId", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"), new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5d14d241-437e-4819-ab01-58563d95c73c"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"), new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("173487fc-5809-4d64-8a2c-a23403127e30"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(3529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a447a151-130e-46df-917b-d09976d2ebb5"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4239), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a447a151-130e-46df-917b-d09976d2ebb5"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4162), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 82, DateTimeKind.Local).AddTicks(4327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a447a151-130e-46df-917b-d09976d2ebb5"), new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "FirstName", "LastName", "Password", "UpdateBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 3, 15, 12, 41, 73, DateTimeKind.Local).AddTicks(385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sakthi", "Vel", "Hello@123", new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 73, DateTimeKind.Local).AddTicks(9271), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manoj", "Kumar", "Hello@321", new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreateBy", "DateCreated", "DateUpdated", "Line1", "Line2", "StateName", "Type", "UpdateBy", "UserId", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("859a0577-76ad-49ef-a111-346e4f978a88"), "madurai", new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hello", "solunga", "tamilnadu", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), "625002" },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), "madurai", new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(544), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hello", "solunga", "tamilnadu", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), "625002" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "EmailAddress", "TypeId", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(2984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itsmemano123@gmail.com", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(3035), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "itsmemano@gmail.com", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "PhoneNumber", "TypeId", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("00793011-a986-49f0-879b-86023edaff46"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(1711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8925250061", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 3, 15, 12, 41, 75, DateTimeKind.Local).AddTicks(1754), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9488977667", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UserId",
                table: "Assets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_UserId",
                table: "Phones",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RefSets");

            migrationBuilder.DropTable(
                name: "RefTerms");

            migrationBuilder.DropTable(
                name: "SetRefTerms");

            migrationBuilder.DropTable(
                name: "UPIS");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
