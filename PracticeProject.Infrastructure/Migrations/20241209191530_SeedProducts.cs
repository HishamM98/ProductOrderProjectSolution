using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PracticeProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("10c1e8a4-93c5-4d74-9f51-daa2137fc25b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e8d36ad-9c39-4c24-93df-a80692d0718b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("046ebee5-ffd6-48aa-b4aa-c3be7c98fa4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0588610d-f840-4267-8843-aed7d96eea6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06a40e32-3978-4213-b467-315525880cd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06f8d6e8-cba6-4c37-8822-f93d4348d9e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13969749-ce3a-4c26-8410-daf3f1dff104"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("164b04a8-c9ab-4892-8d54-4a47ab10739e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("165d9ce6-b25f-4a3c-82dc-efdeed5ea8bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("181b7b77-f740-45ea-a3eb-02b3290fd4d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d102968-7fde-4d2d-a23a-4c4baef232d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1db0c9c8-b445-4b25-bba2-19e398712f1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e1bdddc-0e64-44f8-8878-0adbc7e7fa3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ea80ca9-b896-4aa3-abea-d488f910223e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208ab1f9-9854-4574-8e78-24620ed987a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("255285bc-7fba-4b45-a45e-2a8a5041c014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25dff402-f9a5-4714-93d9-1060736f1907"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cc9b23a-f087-41f8-b637-fd7ab268d6a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f7012b5-0fa4-47d5-b347-4b2bd394ce4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39e7ee8b-a3d9-4f9e-a627-56c0419a70b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a87b7bc-2208-4d8f-bdf4-631abcce28a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dbb27c2-982c-48b6-b3c9-457c49820901"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("412245ec-efb1-4adb-9e10-1d95fd730cee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41b582fc-c7ea-4b24-9adc-8924509d9b73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45693af1-945e-4dcc-a36f-c61941664ee6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45b01c40-a01e-4d3a-8925-6e0a1f5b7762"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("461f7c48-3971-4641-b660-6683a3e75f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47bd7680-9f98-4df5-bbfa-ae159ca9ad86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4822a5a9-fc4e-4845-a0c6-a53f22b41b57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("482f438f-c28a-413a-aea2-357f384d0ec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c6afb14-8af7-4e92-b8f0-025cc1b3cf01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e1808dd-7a23-42d4-a16d-5dc65b3f2f31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef49906-c072-4984-8374-c99d109e2dc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53805332-861e-4028-a3a3-8672f9ff6427"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("545a20be-31c6-4550-a991-65e77a7b3c04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59f9076b-f8c1-47db-ba4f-8afee63250d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a68d49f-8dde-4728-a68d-86de443f4c13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5abd1096-73c5-4f8c-a60e-ac7c13df9244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ae90d59-34ad-471c-a3f0-e2bf3350a1a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cdd362a-67ad-4234-9fe3-f49d9ff66be9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea6d0bd-c7ac-4458-a972-c915f3b4c598"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("608bb13b-348f-44e3-9199-9dcae0dc9adb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("634f4aa9-6b9b-4807-8746-6dbcdda7fa4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bd6c93e-2eee-4566-8a32-87ace2c97470"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ceeb3b7-3134-470d-875b-d21547f24bfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8b04c6-302a-435b-a67b-91d91a88abb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f96661b-54c6-4dcb-8101-859474b82ba2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6faef039-3b88-4b72-ad74-d3b48c57d2c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71689a8c-038d-4904-9a04-c88acfefcfc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76c09c1d-0db0-4162-ba0a-b0b7da468959"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("770745ae-1d18-46a1-ab69-ee34cf1aef1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79ed1487-04a5-4ac1-9a97-6496fb3964a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7deeb7b6-58ca-4c9f-bc18-d27f7fabd001"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f95c881-0d6a-4165-a161-d6072dabacf4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8134a02e-db29-4655-ac23-c252e423aa29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("858cfc5b-2f44-4f32-b824-22287bae755b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8670325c-d470-4a39-8f83-6889ca688ba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87c0b1b6-ce9e-48eb-a253-8d6d717831c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8dac031e-8db7-455a-870b-dc0d2635d2e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fe21883-acf0-4713-8485-b9677f0c2e22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90efae05-2614-4ff8-901a-c4eea6437bd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("912f1a20-a57e-4937-9949-a984f6938213"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91e972a3-a894-4ba2-9efa-f4da45e97205"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93799ecf-19c8-483a-9197-382211ac50d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96bc7d65-9358-4156-a750-342b9c5fd0c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96c1a6e8-8e17-4f52-adfa-915681fb566a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b28914f-e988-4087-9ffa-459989c3d015"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bcd4702-01ef-4569-a0cc-10016a3cbb46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1434ff7-5fc0-4d48-8b5c-3a16b02e5685"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a34051fd-71a6-44f6-a885-07a13225096c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9cb2619-99ae-4b10-a876-2dba686ab1b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af2db0ed-f6bc-4e69-ad6c-6d9027e73fd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0a06cbc-3425-4d57-8248-2e28eb190cf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b32ca35e-986d-4090-9051-0062a5c529aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5f146ff-0df7-4c4e-b395-ee2a9bf95c35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7cc35d5-bedd-40ef-90f2-174c7db34584"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b80c23e2-107b-4540-9cde-e954751d1ec1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba63a8d7-5205-4d9e-b6de-e9f7264bfc6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2dd5308-de57-4fca-a419-cb9e3683a3a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4e66aca-f381-4923-af00-3b0075427acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c667e824-5d25-488d-a877-e4f10052665d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6a87f29-c4d6-45f4-aadd-f318f005c313"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c77e6a1f-980d-4378-a73c-6c8060d635cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9b8b691-2a53-4fc5-9917-a15733fa61b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbd464f3-2927-4b20-b38f-d019c3a0d365"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d06a2117-7394-4e18-8ed7-72958961c708"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d41bb08f-44cd-4ade-8e43-6b54ac9f7d2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8704cf8-3949-4913-a25c-bed88210426f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e77b8b4b-7499-4da6-94e6-9d7f71644969"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb97c910-6572-45ed-be18-a5d369bae4ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec3f2f6-11bb-497c-9e24-3ef5813e49e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eedfcc0c-aaf6-4a90-802c-5abe169d28db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef28c636-c92b-43dd-8230-3bc72aad5de6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efc3979b-b16a-431e-80ec-0ebb6540f541"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1fbdc74-5149-4857-8615-143c4c05d1fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6a62298-7344-4a6c-92f0-a0e1bf4cc09a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7101648-b6ad-46ec-99c2-20594aa71f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb3daf07-077e-49bd-98d0-d8822e7265ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb801ece-7faa-4965-a990-f690cf67ca80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce8da7d-9847-4bc1-9643-f6ebcaa3a1b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fced2ace-67c5-4a0e-9088-c300cd104e3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe40197a-ea9f-4405-970a-816a357a0ba1"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0087babb-8f36-4ec5-900d-f0d8573edb73"), null, "User", "USER" },
                    { new Guid("98d22460-ae55-464e-aa50-34e4d412cf6b"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("000e6c99-5b1c-4502-b9f8-a90a1f84e4e8"), "Home", "Soft and comfortable t-shirt", "Speaker", 118.36m, 81 },
                    { new Guid("02100e13-50e4-4b3d-9bf6-04af9cf8f475"), "Books", "Soft and comfortable t-shirt", "Monitor", 518.41m, 3 },
                    { new Guid("02b0615b-7dc6-4d68-b7c6-352c992e6583"), "Other", "Versatile and practical kitchen appliance", "Monitor", 566.7m, 88 },
                    { new Guid("03b4d595-3333-4784-82ae-4e83c8eaddab"), "Other", "Elegant and modern wristwatch", "Camera", 865.76m, 327 },
                    { new Guid("055e7a58-5167-4507-9d62-c11ad1903117"), "Electronics", "Elegant and modern wristwatch", "Wireless Router", 231.91m, 205 },
                    { new Guid("07ca935b-4e5a-431f-a98c-68eed6d04fff"), "Clothing", "Elegant and modern wristwatch", "Graphics Card", 582.21m, 477 },
                    { new Guid("0881dbf4-ca55-46c1-81ee-7c8aabc31012"), "Books", "Elegant and modern wristwatch", "Printer", 651.38m, 387 },
                    { new Guid("090438a5-e073-4410-9d96-5e455004cad7"), "Clothing", "Elegant and modern wristwatch", "Speaker", 571.85m, 77 },
                    { new Guid("0a9ffd93-2a08-45f5-a2ff-8bb1df8d97bc"), "Clothing", "Soft and comfortable t-shirt", "Wireless Mouse", 708.8m, 209 },
                    { new Guid("0c6a2cf9-3b4d-42cc-8c41-02cbeff12b4b"), "Books", "Durable and stylish backpack", "Router", 441.69m, 484 },
                    { new Guid("14eb3cf4-ed14-46eb-ac5f-6ce066864d2c"), "Other", "Soft and comfortable t-shirt", "Tablet", 758.6m, 490 },
                    { new Guid("1b411f73-1399-45d7-a29c-ce7883369204"), "Electronics", "Soft and comfortable t-shirt", "Monitor", 641.78m, 492 },
                    { new Guid("20edfc96-5227-45b6-90fd-78c522e50b02"), "Clothing", "Elegant and modern wristwatch", "Camera", 398.29m, 120 },
                    { new Guid("21cd4ed9-aec6-4d5c-9522-6f4bdc55f657"), "Books", "Soft and comfortable t-shirt", "Smartwatch", 43.38m, 167 },
                    { new Guid("2253b37d-751b-44a1-946c-a7cb77d3df9f"), "Books", "Soft and comfortable t-shirt", "Fitness Tracker", 198.98m, 84 },
                    { new Guid("24f89608-f520-4412-b4b8-5af6f29cb3ad"), "Home", "Durable and stylish backpack", "Bluetooth Speaker", 161.79m, 450 },
                    { new Guid("252d8e88-8f00-4734-95a5-6665c2139683"), "Electronics", "Versatile and practical kitchen appliance", "Laptop", 848.84m, 72 },
                    { new Guid("26a2f976-9633-4722-9cf9-93228ee8f1e3"), "Books", "Durable and stylish backpack", "Fitness Tracker", 37.19m, 288 },
                    { new Guid("2c91d366-c4d6-4c09-ae0f-0091303b89a5"), "Books", "Durable and stylish backpack", "Camera", 614.92m, 402 },
                    { new Guid("2e469e5a-43c6-4831-8a69-0a19117caa70"), "Electronics", "Durable and stylish backpack", "Camera", 911.86m, 8 },
                    { new Guid("311c0d7d-6ab5-4dd9-b866-a3897ae21eda"), "Clothing", "Soft and comfortable t-shirt", "Headphones", 392.45m, 370 },
                    { new Guid("313d63ff-7d43-4276-a44f-d49bbc8839cf"), "Other", "Soft and comfortable t-shirt", "Smartphone", 535.98m, 220 },
                    { new Guid("31f56c88-edf6-4e50-bbbb-0c7b46748a79"), "Other", "Versatile and practical kitchen appliance", "Wireless Mouse", 814.91m, 127 },
                    { new Guid("33760a14-aec4-4aba-95f1-651a1a2710dc"), "Home", "Versatile and practical kitchen appliance", "Fitness Tracker", 611.86m, 189 },
                    { new Guid("35560afb-d0cf-401d-b690-f5e5fb7c8e76"), "Other", "Versatile and practical kitchen appliance", "External Hard Drive", 898.1m, 94 },
                    { new Guid("3bd492c8-b42e-4927-9ca6-01ba7d782b7a"), "Electronics", "Soft and comfortable t-shirt", "Camera", 491.33m, 64 },
                    { new Guid("3e003da8-e88f-4aef-8a4b-b69a0d0c16b7"), "Books", "Durable and stylish backpack", "USB Flash Drive", 425.68m, 361 },
                    { new Guid("40e58668-45cb-4e51-a08e-8bf05a9b7b09"), "Other", "Elegant and modern wristwatch", "Wireless Keyboard", 27.94m, 390 },
                    { new Guid("45218055-86df-40c4-bd8d-6a683dc15c73"), "Electronics", "Durable and stylish backpack", "Headphones", 639.54m, 66 },
                    { new Guid("457eccda-6867-4461-9d2c-e6b9b7bc3fdf"), "Home", "Soft and comfortable t-shirt", "Graphics Card", 873.11m, 107 },
                    { new Guid("4709ff36-00a8-4f9c-be82-06bf233e5b0a"), "Other", "Elegant and modern wristwatch", "Webcam", 237.49m, 93 },
                    { new Guid("49cc6197-f582-4040-bc57-31d4110675bb"), "Books", "Elegant and modern wristwatch", "Headphones", 761.89m, 232 },
                    { new Guid("50d98327-5455-4bf0-bc64-9d0995f9678a"), "Electronics", "Versatile and practical kitchen appliance", "Gaming Console", 644.42m, 122 },
                    { new Guid("526a6571-d79d-467d-92f8-b7f793ea001c"), "Home", "Durable and stylish backpack", "Microphone", 289.89m, 170 },
                    { new Guid("56717e3a-0fdf-464f-beb0-a0883aa95311"), "Other", "Elegant and modern wristwatch", "Gaming Console", 440.81m, 148 },
                    { new Guid("58ef3523-00c0-40c6-89d2-21079f935b2c"), "Clothing", "Versatile and practical kitchen appliance", "Camera", 890.69m, 201 },
                    { new Guid("5dd2bed0-c46d-4f1f-8c57-3cb671846a14"), "Other", "Versatile and practical kitchen appliance", "Monitor", 588.13m, 474 },
                    { new Guid("604c4ff2-588e-424a-8aaf-55ecf8e7d0bc"), "Clothing", "Elegant and modern wristwatch", "Smartphone", 310.15m, 223 },
                    { new Guid("62a98303-cc3c-4d35-9078-a13166b324d2"), "Books", "Durable and stylish backpack", "Portable Charger", 180.06m, 317 },
                    { new Guid("62d06097-3f2d-485c-a5cd-f371c557a5b4"), "Electronics", "Versatile and practical kitchen appliance", "Smartwatch", 208.85m, 409 },
                    { new Guid("646aff46-25fc-4eb4-97a9-36cf9025e291"), "Home", "Durable and stylish backpack", "Portable Charger", 108.87m, 499 },
                    { new Guid("65d4d07f-4cd8-43be-8bfc-bcc82c94f4b4"), "Electronics", "Versatile and practical kitchen appliance", "Monitor", 309.9m, 270 },
                    { new Guid("682fc03f-7a65-4054-8642-621217c859dc"), "Home", "Durable and stylish backpack", "Wireless Router", 400.59m, 63 },
                    { new Guid("6a0feb92-8d23-4e9e-b8ff-ad6119d4a949"), "Home", "Versatile and practical kitchen appliance", "Monitor", 311.53m, 435 },
                    { new Guid("7015c28f-e89a-4cc6-a067-529a54909659"), "Clothing", "Soft and comfortable t-shirt", "Fitness Tracker", 714.87m, 246 },
                    { new Guid("704ef17d-315b-4fde-a8ec-c0290a837b91"), "Home", "Versatile and practical kitchen appliance", "Speaker", 299.54m, 110 },
                    { new Guid("72def9b7-7d43-4b99-acc4-503881b6e3d2"), "Electronics", "Soft and comfortable t-shirt", "Camera", 135.56m, 104 },
                    { new Guid("73df1950-d695-4b75-9361-b4c736a33385"), "Home", "Versatile and practical kitchen appliance", "Projector", 380.9m, 144 },
                    { new Guid("756db979-f5ea-4b81-a913-796274ea3b6b"), "Clothing", "Soft and comfortable t-shirt", "Printer", 504.47m, 313 },
                    { new Guid("771538a8-b71a-4789-a3d0-07e661380937"), "Home", "Durable and stylish backpack", "USB Flash Drive", 918.36m, 482 },
                    { new Guid("7807f809-7875-4760-8b36-510e217f96bc"), "Books", "Versatile and practical kitchen appliance", "Wireless Earbuds", 802.06m, 28 },
                    { new Guid("78a2cd11-d53c-4ea9-b9c3-47668eeb0f68"), "Electronics", "Durable and stylish backpack", "External Hard Drive", 50.74m, 368 },
                    { new Guid("7a52fa81-8036-4633-a559-829fa135d8f7"), "Home", "Elegant and modern wristwatch", "Laptop", 229.68m, 414 },
                    { new Guid("7b21e62a-7191-4da4-be2d-0f10e9c5f835"), "Books", "Durable and stylish backpack", "Speaker", 997.51m, 72 },
                    { new Guid("7bf97a49-811a-4daa-a501-66736f867f3f"), "Books", "Versatile and practical kitchen appliance", "Tablet", 926.54m, 493 },
                    { new Guid("7d2566f5-d6b5-4be1-a63c-8c350d784091"), "Electronics", "Durable and stylish backpack", "Projector", 810.26m, 336 },
                    { new Guid("8020dd83-14f9-4371-8161-abba3335d1b9"), "Other", "Durable and stylish backpack", "Fitness Tracker", 223.03m, 184 },
                    { new Guid("8a85e9c9-cabb-44cd-8b29-956a2d3efbc7"), "Home", "Durable and stylish backpack", "Wireless Printer", 844.09m, 53 },
                    { new Guid("9168c928-d33b-45d6-83cb-cbc568e91073"), "Clothing", "Soft and comfortable t-shirt", "Wireless Router", 567.8m, 322 },
                    { new Guid("94e92a9f-d010-4c27-acc0-53c6b242c618"), "Books", "Elegant and modern wristwatch", "Keyboard", 894.05m, 487 },
                    { new Guid("974152c5-e121-4c5e-a876-cc3f2e0cf02f"), "Books", "Versatile and practical kitchen appliance", "Headphones", 524.18m, 472 },
                    { new Guid("9b8462c3-0213-45d7-ae5c-9545b36d9480"), "Clothing", "Durable and stylish backpack", "Keyboard", 591.98m, 443 },
                    { new Guid("9c88025b-f441-475d-8183-2e2a28cc9ac3"), "Clothing", "Elegant and modern wristwatch", "Webcam", 910.17m, 377 },
                    { new Guid("9e066adc-ff7d-4ba2-9a22-a9eedc327216"), "Home", "Soft and comfortable t-shirt", "Smartwatch", 410.28m, 131 },
                    { new Guid("a399c158-a08b-486e-94b0-6cfaefd677d3"), "Electronics", "Elegant and modern wristwatch", "Projector", 745.92m, 19 },
                    { new Guid("a46a054b-9f18-4210-943d-e8ee09ede007"), "Home", "Versatile and practical kitchen appliance", "Wireless Printer", 85.1m, 63 },
                    { new Guid("a783b24f-e11c-4f28-9706-e9501a2320fc"), "Electronics", "Durable and stylish backpack", "Laptop", 352.1m, 327 },
                    { new Guid("a97cf430-bda6-4b35-b6a0-c1bde8b81f11"), "Clothing", "Durable and stylish backpack", "Smartphone", 646.0m, 179 },
                    { new Guid("ac2ad2d7-fc44-43fb-9e75-82bfcb5da3fa"), "Clothing", "Elegant and modern wristwatch", "Wireless Keyboard", 243.58m, 121 },
                    { new Guid("acc21795-a5e6-43b8-a9ad-49272fbc85b5"), "Home", "Soft and comfortable t-shirt", "USB Flash Drive", 754.93m, 193 },
                    { new Guid("af46567a-2564-491a-8f47-7942bd906590"), "Home", "Versatile and practical kitchen appliance", "Wireless Mouse", 821.45m, 97 },
                    { new Guid("af6e2699-2a2a-46cd-8096-8ec9f54cf562"), "Other", "Durable and stylish backpack", "Monitor", 814.77m, 326 },
                    { new Guid("b2fb2042-2076-4c5a-9de9-26887ea4455e"), "Clothing", "Elegant and modern wristwatch", "Bluetooth Speaker", 575.85m, 29 },
                    { new Guid("b3f5f795-1364-4b81-a68b-966e362379c0"), "Books", "Versatile and practical kitchen appliance", "Tablet", 647.31m, 491 },
                    { new Guid("b5b95b29-a291-45ec-8c3d-e16bf6d6933b"), "Clothing", "Durable and stylish backpack", "Smartwatch", 681.24m, 44 },
                    { new Guid("b721676a-2ce1-4de9-a419-bdd6e17db133"), "Books", "Durable and stylish backpack", "Camera", 990.73m, 32 },
                    { new Guid("bea9debc-c889-4d9e-8058-272da76fdbe7"), "Electronics", "Versatile and practical kitchen appliance", "Wireless Earbuds", 149.43m, 37 },
                    { new Guid("bf78505b-9d47-4384-9072-7cd4294b86e0"), "Books", "Versatile and practical kitchen appliance", "Smartphone", 295.96m, 99 },
                    { new Guid("c097a135-c163-4051-ab9d-b5fec7ea2c4d"), "Home", "Versatile and practical kitchen appliance", "VR Headset", 720.15m, 400 },
                    { new Guid("c3c2ef85-7e76-4ea1-bed7-bad724145fc0"), "Clothing", "Elegant and modern wristwatch", "External Hard Drive", 499.56m, 479 },
                    { new Guid("c6eba505-b588-4d77-81f3-4dc324dbc786"), "Other", "Soft and comfortable t-shirt", "Projector", 436.25m, 144 },
                    { new Guid("c84c9d89-9560-4ebf-9f66-6f8221e2b361"), "Home", "Versatile and practical kitchen appliance", "Wireless Earbuds", 613.67m, 471 },
                    { new Guid("d00bd6b2-0ac9-4e80-a4d7-9dc34a45e357"), "Other", "Durable and stylish backpack", "Action Camera", 272.44m, 479 },
                    { new Guid("d1c0b4bf-e8d1-45bf-8c46-f60f0d8fcad3"), "Home", "Soft and comfortable t-shirt", "Gaming Mouse", 822.44m, 493 },
                    { new Guid("d3780a3a-b8bd-4d51-a84c-db4b047dbb45"), "Home", "Elegant and modern wristwatch", "Wireless Earbuds", 190.34m, 60 },
                    { new Guid("d3c8c1c4-da36-4edb-8551-3ed2aad189c2"), "Other", "Elegant and modern wristwatch", "VR Headset", 12.34m, 339 },
                    { new Guid("d6d3f33c-6319-4a43-9beb-058b150913de"), "Home", "Durable and stylish backpack", "Tablet", 885.78m, 329 },
                    { new Guid("d7bd83ad-797e-48a3-a83a-f0755a51639c"), "Clothing", "Durable and stylish backpack", "Headphones", 960.7m, 397 },
                    { new Guid("d884cf5a-57e8-4fad-a84f-e2834a109a3b"), "Other", "Durable and stylish backpack", "Wireless Keyboard", 517.79m, 68 },
                    { new Guid("dcf9f670-958d-47ad-8b70-0681da4698a2"), "Home", "Elegant and modern wristwatch", "Smartwatch", 248.1m, 312 },
                    { new Guid("df414527-8f63-4c15-b75b-e6c58874a5f5"), "Other", "Versatile and practical kitchen appliance", "Laptop", 904.82m, 32 },
                    { new Guid("e0b8cef9-3faf-4cc4-9494-f09bc6db4d88"), "Books", "Versatile and practical kitchen appliance", "Smartphone", 116.07m, 15 },
                    { new Guid("e3c24381-6b26-4d5a-8f87-bc36e95793ef"), "Clothing", "Soft and comfortable t-shirt", "Tablet", 298.94m, 211 },
                    { new Guid("e58fd23d-bb91-41a0-9c96-a654057d2724"), "Other", "Durable and stylish backpack", "Wireless Printer", 758.08m, 344 },
                    { new Guid("e86f1e18-bcb5-4aa6-9211-82d1bbbc9f0a"), "Clothing", "Soft and comfortable t-shirt", "Gaming Console", 152.87m, 387 },
                    { new Guid("f164a34a-2865-40f4-b6df-0a516a03aa6f"), "Electronics", "Durable and stylish backpack", "Graphics Card", 8.59m, 33 },
                    { new Guid("f356eb68-5291-4206-bc62-8e6ab0e33a50"), "Clothing", "Versatile and practical kitchen appliance", "Wireless Keyboard", 23.15m, 357 },
                    { new Guid("f745432a-cf39-436f-ac92-d7c50535931b"), "Other", "Durable and stylish backpack", "Camera", 652.54m, 474 },
                    { new Guid("f76c82dc-f850-4478-b4a7-539c08782621"), "Home", "Versatile and practical kitchen appliance", "VR Headset", 504.98m, 441 },
                    { new Guid("f993a218-6692-4a1b-996a-3aae76b90ffb"), "Other", "Durable and stylish backpack", "Wireless Keyboard", 820.99m, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0087babb-8f36-4ec5-900d-f0d8573edb73"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("98d22460-ae55-464e-aa50-34e4d412cf6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000e6c99-5b1c-4502-b9f8-a90a1f84e4e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02100e13-50e4-4b3d-9bf6-04af9cf8f475"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02b0615b-7dc6-4d68-b7c6-352c992e6583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03b4d595-3333-4784-82ae-4e83c8eaddab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("055e7a58-5167-4507-9d62-c11ad1903117"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07ca935b-4e5a-431f-a98c-68eed6d04fff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0881dbf4-ca55-46c1-81ee-7c8aabc31012"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("090438a5-e073-4410-9d96-5e455004cad7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a9ffd93-2a08-45f5-a2ff-8bb1df8d97bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c6a2cf9-3b4d-42cc-8c41-02cbeff12b4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14eb3cf4-ed14-46eb-ac5f-6ce066864d2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b411f73-1399-45d7-a29c-ce7883369204"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20edfc96-5227-45b6-90fd-78c522e50b02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21cd4ed9-aec6-4d5c-9522-6f4bdc55f657"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2253b37d-751b-44a1-946c-a7cb77d3df9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24f89608-f520-4412-b4b8-5af6f29cb3ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("252d8e88-8f00-4734-95a5-6665c2139683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26a2f976-9633-4722-9cf9-93228ee8f1e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c91d366-c4d6-4c09-ae0f-0091303b89a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e469e5a-43c6-4831-8a69-0a19117caa70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("311c0d7d-6ab5-4dd9-b866-a3897ae21eda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("313d63ff-7d43-4276-a44f-d49bbc8839cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31f56c88-edf6-4e50-bbbb-0c7b46748a79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33760a14-aec4-4aba-95f1-651a1a2710dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35560afb-d0cf-401d-b690-f5e5fb7c8e76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bd492c8-b42e-4927-9ca6-01ba7d782b7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e003da8-e88f-4aef-8a4b-b69a0d0c16b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40e58668-45cb-4e51-a08e-8bf05a9b7b09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45218055-86df-40c4-bd8d-6a683dc15c73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("457eccda-6867-4461-9d2c-e6b9b7bc3fdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4709ff36-00a8-4f9c-be82-06bf233e5b0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49cc6197-f582-4040-bc57-31d4110675bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50d98327-5455-4bf0-bc64-9d0995f9678a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("526a6571-d79d-467d-92f8-b7f793ea001c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56717e3a-0fdf-464f-beb0-a0883aa95311"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58ef3523-00c0-40c6-89d2-21079f935b2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dd2bed0-c46d-4f1f-8c57-3cb671846a14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("604c4ff2-588e-424a-8aaf-55ecf8e7d0bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62a98303-cc3c-4d35-9078-a13166b324d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62d06097-3f2d-485c-a5cd-f371c557a5b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("646aff46-25fc-4eb4-97a9-36cf9025e291"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65d4d07f-4cd8-43be-8bfc-bcc82c94f4b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("682fc03f-7a65-4054-8642-621217c859dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a0feb92-8d23-4e9e-b8ff-ad6119d4a949"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7015c28f-e89a-4cc6-a067-529a54909659"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("704ef17d-315b-4fde-a8ec-c0290a837b91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72def9b7-7d43-4b99-acc4-503881b6e3d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73df1950-d695-4b75-9361-b4c736a33385"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("756db979-f5ea-4b81-a913-796274ea3b6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("771538a8-b71a-4789-a3d0-07e661380937"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7807f809-7875-4760-8b36-510e217f96bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78a2cd11-d53c-4ea9-b9c3-47668eeb0f68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a52fa81-8036-4633-a559-829fa135d8f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b21e62a-7191-4da4-be2d-0f10e9c5f835"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bf97a49-811a-4daa-a501-66736f867f3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d2566f5-d6b5-4be1-a63c-8c350d784091"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8020dd83-14f9-4371-8161-abba3335d1b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a85e9c9-cabb-44cd-8b29-956a2d3efbc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9168c928-d33b-45d6-83cb-cbc568e91073"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94e92a9f-d010-4c27-acc0-53c6b242c618"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("974152c5-e121-4c5e-a876-cc3f2e0cf02f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b8462c3-0213-45d7-ae5c-9545b36d9480"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c88025b-f441-475d-8183-2e2a28cc9ac3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e066adc-ff7d-4ba2-9a22-a9eedc327216"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a399c158-a08b-486e-94b0-6cfaefd677d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a46a054b-9f18-4210-943d-e8ee09ede007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a783b24f-e11c-4f28-9706-e9501a2320fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a97cf430-bda6-4b35-b6a0-c1bde8b81f11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac2ad2d7-fc44-43fb-9e75-82bfcb5da3fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acc21795-a5e6-43b8-a9ad-49272fbc85b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af46567a-2564-491a-8f47-7942bd906590"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af6e2699-2a2a-46cd-8096-8ec9f54cf562"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2fb2042-2076-4c5a-9de9-26887ea4455e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3f5f795-1364-4b81-a68b-966e362379c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b95b29-a291-45ec-8c3d-e16bf6d6933b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b721676a-2ce1-4de9-a419-bdd6e17db133"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bea9debc-c889-4d9e-8058-272da76fdbe7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf78505b-9d47-4384-9072-7cd4294b86e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c097a135-c163-4051-ab9d-b5fec7ea2c4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3c2ef85-7e76-4ea1-bed7-bad724145fc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6eba505-b588-4d77-81f3-4dc324dbc786"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c84c9d89-9560-4ebf-9f66-6f8221e2b361"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d00bd6b2-0ac9-4e80-a4d7-9dc34a45e357"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1c0b4bf-e8d1-45bf-8c46-f60f0d8fcad3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3780a3a-b8bd-4d51-a84c-db4b047dbb45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3c8c1c4-da36-4edb-8551-3ed2aad189c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6d3f33c-6319-4a43-9beb-058b150913de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7bd83ad-797e-48a3-a83a-f0755a51639c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d884cf5a-57e8-4fad-a84f-e2834a109a3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcf9f670-958d-47ad-8b70-0681da4698a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df414527-8f63-4c15-b75b-e6c58874a5f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0b8cef9-3faf-4cc4-9494-f09bc6db4d88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3c24381-6b26-4d5a-8f87-bc36e95793ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e58fd23d-bb91-41a0-9c96-a654057d2724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e86f1e18-bcb5-4aa6-9211-82d1bbbc9f0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f164a34a-2865-40f4-b6df-0a516a03aa6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f356eb68-5291-4206-bc62-8e6ab0e33a50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f745432a-cf39-436f-ac92-d7c50535931b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f76c82dc-f850-4478-b4a7-539c08782621"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f993a218-6692-4a1b-996a-3aae76b90ffb"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("10c1e8a4-93c5-4d74-9f51-daa2137fc25b"), null, "Admin", "ADMIN" },
                    { new Guid("4e8d36ad-9c39-4c24-93df-a80692d0718b"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("046ebee5-ffd6-48aa-b4aa-c3be7c98fa4b"), "Clothing", "Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", "GizmoX 5000", 266.82m, 60 },
                    { new Guid("0588610d-f840-4267-8843-aed7d96eea6b"), "Home", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", "TechMaster Pro 2000", 406.06m, 58 },
                    { new Guid("06a40e32-3978-4213-b467-315525880cd0"), "Clothing", "Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.", "EcoGadget 300", 519.12m, 26 },
                    { new Guid("06f8d6e8-cba6-4c37-8822-f93d4348d9e3"), "Home", "Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", "MegaDeal Max", 396.8m, 50 },
                    { new Guid("13969749-ce3a-4c26-8410-daf3f1dff104"), "Books", "Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.", "GigaGizmo 9000", 488.95m, 47 },
                    { new Guid("164b04a8-c9ab-4892-8d54-4a47ab10739e"), "Clothing", "Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", "GizmoX 5000", 305.38m, 87 },
                    { new Guid("165d9ce6-b25f-4a3c-82dc-efdeed5ea8bd"), "Electronics", "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum.", "UltimateTech 1000", 557.56m, 22 },
                    { new Guid("181b7b77-f740-45ea-a3eb-02b3290fd4d5"), "Clothing", "Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque.", "SuperSaver Deal", 888.38m, 42 },
                    { new Guid("1d102968-7fde-4d2d-a23a-4c4baef232d8"), "Books", "Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.", "GizmoX 5000", 356.49m, 96 },
                    { new Guid("1db0c9c8-b445-4b25-bba2-19e398712f1e"), "Books", "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.", "HomeHelper Plus", 229.92m, 35 },
                    { new Guid("1e1bdddc-0e64-44f8-8878-0adbc7e7fa3b"), "Home", "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.", "LuxuryTech Elite", 728.07m, 32 },
                    { new Guid("1ea80ca9-b896-4aa3-abea-d488f910223e"), "Home", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "UltimateTech 1000", 233.57m, 8 },
                    { new Guid("208ab1f9-9854-4574-8e78-24620ed987a6"), "Books", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum.", "GizmoX 5000", 735.23m, 77 },
                    { new Guid("255285bc-7fba-4b45-a45e-2a8a5041c014"), "Books", "Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.", "UltimateTech 1000", 292.81m, 15 },
                    { new Guid("25dff402-f9a5-4714-93d9-1060736f1907"), "Other", "Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.", "HomeHelper Plus", 294.58m, 69 },
                    { new Guid("2cc9b23a-f087-41f8-b637-fd7ab268d6a6"), "Books", "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum.", "SuperSaver Deal", 321.54m, 24 },
                    { new Guid("2f7012b5-0fa4-47d5-b347-4b2bd394ce4f"), "Clothing", "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", "LuxuryTech Elite", 685.9m, 6 },
                    { new Guid("39e7ee8b-a3d9-4f9e-a627-56c0419a70b3"), "Books", "Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat.", "GigaGizmo 9000", 47.28m, 14 },
                    { new Guid("3a87b7bc-2208-4d8f-bdf4-631abcce28a6"), "Home", "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo.", "TechMaster Pro 2000", 355m, 29 },
                    { new Guid("3dbb27c2-982c-48b6-b3c9-457c49820901"), "Clothing", "Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti.", "SuperSaver Deal", 197.45m, 37 },
                    { new Guid("412245ec-efb1-4adb-9e10-1d95fd730cee"), "Other", "Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", "SmartLife 360", 87.9m, 92 },
                    { new Guid("41b582fc-c7ea-4b24-9adc-8924509d9b73"), "Other", "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio.", "GigaGizmo 9000", 596.79m, 2 },
                    { new Guid("45693af1-945e-4dcc-a36f-c61941664ee6"), "Books", "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.", "EcoGadget 300", 529.51m, 95 },
                    { new Guid("45b01c40-a01e-4d3a-8925-6e0a1f5b7762"), "Books", "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", "GigaGizmo 9000", 176.27m, 65 },
                    { new Guid("461f7c48-3971-4641-b660-6683a3e75f3e"), "Other", "Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.", "HomeHelper Plus", 730.26m, 64 },
                    { new Guid("47bd7680-9f98-4df5-bbfa-ae159ca9ad86"), "Books", "Integer ac neque. Duis bibendum.", "MegaDeal Max", 113.49m, 61 },
                    { new Guid("4822a5a9-fc4e-4845-a0c6-a53f22b41b57"), "Electronics", "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", "GigaGizmo 9000", 323.03m, 56 },
                    { new Guid("482f438f-c28a-413a-aea2-357f384d0ec6"), "Home", "Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.", "SmartLife 360", 998.93m, 27 },
                    { new Guid("4c6afb14-8af7-4e92-b8f0-025cc1b3cf01"), "Other", "Nunc purus. Phasellus in felis. Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", "GigaGizmo 9000", 354.19m, 48 },
                    { new Guid("4e1808dd-7a23-42d4-a16d-5dc65b3f2f31"), "Other", "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", "TechMaster Pro 2000", 539.86m, 86 },
                    { new Guid("4ef49906-c072-4984-8374-c99d109e2dc9"), "Books", "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.", "GigaGizmo 9000", 528.69m, 79 },
                    { new Guid("53805332-861e-4028-a3a3-8672f9ff6427"), "Other", "Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.", "LuxuryTech Elite", 427.77m, 25 },
                    { new Guid("545a20be-31c6-4550-a991-65e77a7b3c04"), "Clothing", "Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", "SmartLife 360", 873.48m, 66 },
                    { new Guid("59f9076b-f8c1-47db-ba4f-8afee63250d5"), "Electronics", "Ut at dolor quis odio consequat varius. Integer ac leo.", "SuperSaver Deal", 849.5m, 34 },
                    { new Guid("5a68d49f-8dde-4728-a68d-86de443f4c13"), "Home", "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.", "UltimateTech 1000", 371.68m, 68 },
                    { new Guid("5abd1096-73c5-4f8c-a60e-ac7c13df9244"), "Books", "Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.", "TechMaster Pro 2000", 789.56m, 67 },
                    { new Guid("5ae90d59-34ad-471c-a3f0-e2bf3350a1a3"), "Other", "Morbi non quam nec dui luctus rutrum.", "GizmoX 5000", 907.39m, 57 },
                    { new Guid("5cdd362a-67ad-4234-9fe3-f49d9ff66be9"), "Clothing", "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.", "MegaDeal Max", 540.21m, 94 },
                    { new Guid("5ea6d0bd-c7ac-4458-a972-c915f3b4c598"), "Other", "Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", "MegaDeal Max", 363.05m, 10 },
                    { new Guid("608bb13b-348f-44e3-9199-9dcae0dc9adb"), "Home", "In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum.", "MegaDeal Max", 105.84m, 28 },
                    { new Guid("634f4aa9-6b9b-4807-8746-6dbcdda7fa4d"), "Electronics", "Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "SuperSaver Deal", 807.43m, 82 },
                    { new Guid("6bd6c93e-2eee-4566-8a32-87ace2c97470"), "Other", "Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", "HomeHelper Plus", 667.66m, 90 },
                    { new Guid("6ceeb3b7-3134-470d-875b-d21547f24bfa"), "Clothing", "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum.", "GizmoX 5000", 95.35m, 100 },
                    { new Guid("6d8b04c6-302a-435b-a67b-91d91a88abb9"), "Electronics", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", "EcoGadget 300", 983.72m, 39 },
                    { new Guid("6f96661b-54c6-4dcb-8101-859474b82ba2"), "Clothing", "Aliquam erat volutpat. In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.", "TechMaster Pro 2000", 640.63m, 93 },
                    { new Guid("6faef039-3b88-4b72-ad74-d3b48c57d2c5"), "Clothing", "Morbi non quam nec dui luctus rutrum.", "GizmoX 5000", 49.85m, 89 },
                    { new Guid("71689a8c-038d-4904-9a04-c88acfefcfc5"), "Electronics", "Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", "TechMaster Pro 2000", 186.61m, 51 },
                    { new Guid("76c09c1d-0db0-4162-ba0a-b0b7da468959"), "Books", "Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat.", "GigaGizmo 9000", 341.83m, 70 },
                    { new Guid("770745ae-1d18-46a1-ab69-ee34cf1aef1c"), "Books", "Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.", "HomeHelper Plus", 891.18m, 19 },
                    { new Guid("79ed1487-04a5-4ac1-9a97-6496fb3964a2"), "Electronics", "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat.", "SmartLife 360", 13.66m, 20 },
                    { new Guid("7deeb7b6-58ca-4c9f-bc18-d27f7fabd001"), "Clothing", "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", "HomeHelper Plus", 774.69m, 16 },
                    { new Guid("7f95c881-0d6a-4165-a161-d6072dabacf4"), "Clothing", "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.", "MegaDeal Max", 628.58m, 62 },
                    { new Guid("8134a02e-db29-4655-ac23-c252e423aa29"), "Clothing", "Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat.", "GizmoX 5000", 76.11m, 55 },
                    { new Guid("858cfc5b-2f44-4f32-b824-22287bae755b"), "Other", "Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus.", "EcoGadget 300", 744.86m, 54 },
                    { new Guid("8670325c-d470-4a39-8f83-6889ca688ba4"), "Home", "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", "GigaGizmo 9000", 854.43m, 23 },
                    { new Guid("87c0b1b6-ce9e-48eb-a253-8d6d717831c6"), "Books", "Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis.", "UltimateTech 1000", 27.17m, 81 },
                    { new Guid("8dac031e-8db7-455a-870b-dc0d2635d2e5"), "Home", "Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", "GigaGizmo 9000", 884.91m, 75 },
                    { new Guid("8fe21883-acf0-4713-8485-b9677f0c2e22"), "Books", "Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.", "UltimateTech 1000", 479.9m, 73 },
                    { new Guid("90efae05-2614-4ff8-901a-c4eea6437bd5"), "Books", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat. In congue. Etiam justo.", "GigaGizmo 9000", 198.54m, 83 },
                    { new Guid("912f1a20-a57e-4937-9949-a984f6938213"), "Clothing", "Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", "GigaGizmo 9000", 527.18m, 74 },
                    { new Guid("91e972a3-a894-4ba2-9efa-f4da45e97205"), "Other", "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt.", "GigaGizmo 9000", 443.61m, 91 },
                    { new Guid("93799ecf-19c8-483a-9197-382211ac50d2"), "Electronics", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend.", "SuperSaver Deal", 930.98m, 41 },
                    { new Guid("96bc7d65-9358-4156-a750-342b9c5fd0c4"), "Electronics", "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque.", "TechMaster Pro 2000", 534.69m, 43 },
                    { new Guid("96c1a6e8-8e17-4f52-adfa-915681fb566a"), "Home", "Ut tellus. Nulla ut erat id mauris vulputate elementum.", "MegaDeal Max", 660.91m, 71 },
                    { new Guid("9b28914f-e988-4087-9ffa-459989c3d015"), "Other", "Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", "HomeHelper Plus", 910.56m, 84 },
                    { new Guid("9bcd4702-01ef-4569-a0cc-10016a3cbb46"), "Electronics", "Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.", "TechMaster Pro 2000", 340.05m, 18 },
                    { new Guid("a1434ff7-5fc0-4d48-8b5c-3a16b02e5685"), "Other", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", "SmartLife 360", 859.75m, 98 },
                    { new Guid("a34051fd-71a6-44f6-a885-07a13225096c"), "Clothing", "Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante.", "LuxuryTech Elite", 640.03m, 72 },
                    { new Guid("a9cb2619-99ae-4b10-a876-2dba686ab1b1"), "Home", "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", "GigaGizmo 9000", 219.95m, 5 },
                    { new Guid("af2db0ed-f6bc-4e69-ad6c-6d9027e73fd4"), "Books", "Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus.", "GigaGizmo 9000", 274.17m, 76 },
                    { new Guid("b0a06cbc-3425-4d57-8248-2e28eb190cf7"), "Other", "Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.", "SuperSaver Deal", 112.84m, 52 },
                    { new Guid("b32ca35e-986d-4090-9051-0062a5c529aa"), "Electronics", "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.", "SuperSaver Deal", 137m, 38 },
                    { new Guid("b5f146ff-0df7-4c4e-b395-ee2a9bf95c35"), "Books", "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", "SmartLife 360", 27.58m, 11 },
                    { new Guid("b7cc35d5-bedd-40ef-90f2-174c7db34584"), "Other", "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.", "TechMaster Pro 2000", 267.98m, 44 },
                    { new Guid("b80c23e2-107b-4540-9cde-e954751d1ec1"), "Home", "Aliquam sit amet diam in magna bibendum imperdiet.", "GigaGizmo 9000", 210.07m, 31 },
                    { new Guid("ba63a8d7-5205-4d9e-b6de-e9f7264bfc6b"), "Other", "Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.", "TechMaster Pro 2000", 595.94m, 3 },
                    { new Guid("c2dd5308-de57-4fca-a419-cb9e3683a3a1"), "Home", "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.", "GigaGizmo 9000", 8.26m, 30 },
                    { new Guid("c4e66aca-f381-4923-af00-3b0075427acb"), "Clothing", "Nulla mollis molestie lorem. Quisque ut erat.", "EcoGadget 300", 928.3m, 17 },
                    { new Guid("c667e824-5d25-488d-a877-e4f10052665d"), "Books", "Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus.", "MegaDeal Max", 301.44m, 80 },
                    { new Guid("c6a87f29-c4d6-45f4-aadd-f318f005c313"), "Books", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum.", "SuperSaver Deal", 765.66m, 7 },
                    { new Guid("c77e6a1f-980d-4378-a73c-6c8060d635cd"), "Clothing", "Donec vitae nisi.", "EcoGadget 300", 884.96m, 12 },
                    { new Guid("c9b8b691-2a53-4fc5-9917-a15733fa61b3"), "Other", "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", "SuperSaver Deal", 386.5m, 40 },
                    { new Guid("cbd464f3-2927-4b20-b38f-d019c3a0d365"), "Home", "Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "GigaGizmo 9000", 3.71m, 53 },
                    { new Guid("d06a2117-7394-4e18-8ed7-72958961c708"), "Clothing", "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.", "EcoGadget 300", 803.34m, 49 },
                    { new Guid("d41bb08f-44cd-4ade-8e43-6b54ac9f7d2f"), "Home", "Curabitur in libero ut massa volutpat convallis.", "GigaGizmo 9000", 24.56m, 33 },
                    { new Guid("d8704cf8-3949-4913-a25c-bed88210426f"), "Clothing", "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", "GizmoX 5000", 693.59m, 45 },
                    { new Guid("e77b8b4b-7499-4da6-94e6-9d7f71644969"), "Electronics", "Proin at turpis a pede posuere nonummy. Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", "MegaDeal Max", 869.39m, 21 },
                    { new Guid("eb97c910-6572-45ed-be18-a5d369bae4ef"), "Books", "Duis bibendum.", "UltimateTech 1000", 477.69m, 13 },
                    { new Guid("eec3f2f6-11bb-497c-9e24-3ef5813e49e1"), "Clothing", "Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.", "SmartLife 360", 78.25m, 36 },
                    { new Guid("eedfcc0c-aaf6-4a90-802c-5abe169d28db"), "Books", "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", "UltimateTech 1000", 770.79m, 63 },
                    { new Guid("ef28c636-c92b-43dd-8230-3bc72aad5de6"), "Books", "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", "LuxuryTech Elite", 95.22m, 46 },
                    { new Guid("efc3979b-b16a-431e-80ec-0ebb6540f541"), "Home", "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.", "SuperSaver Deal", 831.53m, 88 },
                    { new Guid("f1fbdc74-5149-4857-8615-143c4c05d1fe"), "Books", "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam.", "LuxuryTech Elite", 741.25m, 97 },
                    { new Guid("f6a62298-7344-4a6c-92f0-a0e1bf4cc09a"), "Home", "In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit.", "TechMaster Pro 2000", 626.97m, 4 },
                    { new Guid("f7101648-b6ad-46ec-99c2-20594aa71f93"), "Clothing", "Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", "GizmoX 5000", 980.12m, 99 },
                    { new Guid("fb3daf07-077e-49bd-98d0-d8822e7265ab"), "Other", "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "MegaDeal Max", 464.69m, 59 },
                    { new Guid("fb801ece-7faa-4965-a990-f690cf67ca80"), "Other", "Duis mattis egestas metus.", "UltimateTech 1000", 964.19m, 85 },
                    { new Guid("fce8da7d-9847-4bc1-9643-f6ebcaa3a1b7"), "Electronics", "Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus.", "EcoGadget 300", 51.33m, 78 },
                    { new Guid("fced2ace-67c5-4a0e-9088-c300cd104e3f"), "Other", "Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.", "MegaDeal Max", 870.67m, 9 },
                    { new Guid("fe40197a-ea9f-4405-970a-816a357a0ba1"), "Other", "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", "MegaDeal Max", 207.9m, 1 }
                });
        }
    }
}
