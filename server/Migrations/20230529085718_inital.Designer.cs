﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230529085718_inital")]
    partial class inital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("server.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = "301d5dcf-a2a8-4a34-b26b-efcaa103963c",
                            Name = "Dillion's unequaled cashew milk",
                            Storage = 99,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "1277e861-b33b-485d-b86f-400769d25a82",
                            Name = "Monet's powerful cashew milk",
                            Storage = 27,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "210aeed2-413b-4e53-98e7-62c9f6fd31ba",
                            Name = "Julianne's relevant pea milk",
                            Storage = 33,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "72204ea0-29e2-4da8-bf57-648b37268b71",
                            Name = "Macie's broad walnut milk",
                            Storage = 23,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "06d60157-e9c7-4bd9-b2a6-00fd63bb2033",
                            Name = "Christa's fearful rice milk",
                            Storage = 46,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "6905f2f6-e80c-4601-8ae6-5408485ef9c5",
                            Name = "Shakayla's loose coconut milk",
                            Storage = 82,
                            Type = "Coconut milk"
                        },
                        new
                        {
                            ProductId = "10aed344-837d-4621-873e-aeac9394c99f",
                            Name = "Duane's salty soy milk",
                            Storage = 24,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "2ceec543-8fd9-4c7c-855a-c1388a68ca78",
                            Name = "Deangelo's rotten hemp milk",
                            Storage = 59,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "dd9140c5-af1d-4861-9736-e0b4f4a81bb7",
                            Name = "Gaven's numberless walnut milk",
                            Storage = 89,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "0798ae22-c922-4b47-adc5-23feac38020f",
                            Name = "Tea's scientific rice milk",
                            Storage = 15,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "3dbf9e44-fb2f-487b-8b34-7e6e6700e17e",
                            Name = "Cora's early almond milk",
                            Storage = 58,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "ea1aadc3-bd1e-4f43-a46d-e035e7a96282",
                            Name = "Jonah's aware cashew milk",
                            Storage = 79,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "1bba8dfc-07af-414d-b85d-663443612e5b",
                            Name = "Catrina's fallacious almond milk",
                            Storage = 62,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "2534898d-223e-49f8-9a4f-2993458fc5f2",
                            Name = "Kristian's quickest oat milk",
                            Storage = 37,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "3989e76f-0546-4b01-bad6-5d52535e8136",
                            Name = "Jessi's unbiased almond milk",
                            Storage = 76,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "fe7c5123-4141-427e-92ed-e9b41bf88c2a",
                            Name = "Jean's wide hemp milk",
                            Storage = 90,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "b3a8ed8d-be54-40b7-9880-5e7df192b981",
                            Name = "Stephen's torpid walnut milk",
                            Storage = 26,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "d6e96a38-ce76-42d9-95a4-7247ea4dcb7a",
                            Name = "Christa's squealing cashew milk",
                            Storage = 100,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "b48a9bbd-ef6b-4205-8c06-014e891a9faf",
                            Name = "Dominik's fearful oat milk",
                            Storage = 25,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "352139db-6f31-4856-83eb-4142c92a3c44",
                            Name = "Joshua's full macadamia milk",
                            Storage = 44,
                            Type = "Macadamia milk"
                        },
                        new
                        {
                            ProductId = "3e437e24-8d75-4063-acbf-827d3c833d90",
                            Name = "Judith's orange cashew milk",
                            Storage = 85,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "283ff036-d83d-403c-8a67-b25f1c096682",
                            Name = "Kentrell's unequaled whole milk",
                            Storage = 51,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "7786da9f-efb9-4e4d-828b-3cf85f1e63c6",
                            Name = "Kristian's wealthy cashew milk",
                            Storage = 11,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "e554d358-ec1c-4b9b-97a3-97fa999abb64",
                            Name = "Dominik's alive whole milk",
                            Storage = 97,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "3f2a611a-4d0b-41e1-8165-2f8f9a1f66aa",
                            Name = "Jean's scared coconut milk",
                            Storage = 25,
                            Type = "Coconut milk"
                        },
                        new
                        {
                            ProductId = "fd2349a0-3d48-4d9b-ac22-6290d1053495",
                            Name = "Sheldon's tasteless cashew milk",
                            Storage = 80,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "e80064ce-5599-46f6-a2d9-6bc7a1aca872",
                            Name = "Jocelyn's rough soy milk",
                            Storage = 25,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "9466032f-db34-49d3-9ae3-7385cc0082f7",
                            Name = "Chandler's full oat milk",
                            Storage = 32,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "d84696a9-600d-4912-914d-bbb7f6a5e744",
                            Name = "Tea's wide pea milk",
                            Storage = 40,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "50045980-f3c9-408b-83bf-a98db403d42d",
                            Name = "Dillion's taboo hemp milk",
                            Storage = 58,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "81bd9a68-5599-4018-990a-694b519a9bdb",
                            Name = "Korbin's open pea milk",
                            Storage = 94,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "7be33cd3-311a-4418-a24d-a501c8d31465",
                            Name = "Stephen's fearful macadamia milk",
                            Storage = 100,
                            Type = "Macadamia milk"
                        },
                        new
                        {
                            ProductId = "d2f12e7b-f096-4391-ad72-b4517deb24cf",
                            Name = "Jessalyn's fallacious almond milk",
                            Storage = 65,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "50a70194-f239-43f6-81de-25628b27ea5a",
                            Name = "Jaeden's cooing cashew milk",
                            Storage = 33,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "0ac95b83-bdce-497c-b0c3-7c0071419324",
                            Name = "Christa's wealthy whole milk",
                            Storage = 84,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "ff6524a8-ab9c-4320-8c41-17e3a8da268e",
                            Name = "Judith's bumpy almond milk",
                            Storage = 66,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "9001c051-305d-462c-aefb-be220eadae6b",
                            Name = "Jaquez's unequaled hemp milk",
                            Storage = 76,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "0037a064-7ce1-4c97-b8a0-51848775a7a9",
                            Name = "Elliot's recent almond milk",
                            Storage = 50,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "9811f876-ebc9-44f0-88ae-1d087cb940db",
                            Name = "Brittney's unbiased coconut milk",
                            Storage = 96,
                            Type = "Coconut milk"
                        },
                        new
                        {
                            ProductId = "179670c3-e49f-4655-ab71-12a90b912cc5",
                            Name = "Dillion's rough rice milk",
                            Storage = 56,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "602d410e-46e1-4744-9b82-cfc7dd5d0940",
                            Name = "Lucero's wholesale whole milk",
                            Storage = 46,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "aa5ce91a-67e6-4349-b1c2-4c4050efb49e",
                            Name = "Jedidiah's early almond milk",
                            Storage = 49,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "78b2fb8e-4c91-439e-a479-f8c1e9595343",
                            Name = "Kasey's quickest hemp milk",
                            Storage = 4,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "1d52f5a1-4c39-4352-85df-168320fb3575",
                            Name = "Kasey's wide rice milk",
                            Storage = 54,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "2f1ce24b-9536-4988-a8b5-c7d9334b74ce",
                            Name = "Judith's steady pea milk",
                            Storage = 32,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "d3ba0a73-29a1-4802-b284-a498df060c42",
                            Name = "Benjamin's taboo soy milk",
                            Storage = 87,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "1dda5869-263d-460c-8275-3b131e17c601",
                            Name = "Gaven's early cashew milk",
                            Storage = 36,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "7d1d6d3d-160c-4461-9b93-385041a224a2",
                            Name = "Kentrell's loose hemp milk",
                            Storage = 79,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "a3df7049-9b81-476d-a803-e8ed8aca161a",
                            Name = "Johnny's second whole milk",
                            Storage = 54,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "2356a84e-0fbb-4b5b-993c-0bc6c70586e2",
                            Name = "Quincy's whole soy milk",
                            Storage = 10,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "b1b4f84b-57f2-420a-9506-ac0636935ab0",
                            Name = "Kasey's painful pea milk",
                            Storage = 62,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "99370f4e-7b31-4d0f-94ab-bd6dae094ddb",
                            Name = "Nehemiah's salty hemp milk",
                            Storage = 4,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "27ebf833-e1ba-40a6-b101-da4eb71313d8",
                            Name = "Jonah's second hemp milk",
                            Storage = 26,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "264a505c-4d88-4a61-966c-471d5233d8d1",
                            Name = "Korbin's fearful walnut milk",
                            Storage = 27,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "62603a88-f96f-4beb-a0ed-98358826974a",
                            Name = "Deangelo's onerous walnut milk",
                            Storage = 57,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "697a783b-43e4-478e-bd1b-253676e43c0b",
                            Name = "Joshua's existing rice milk",
                            Storage = 73,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "1fcb5bbb-0fa4-40d5-92ae-0e751c18d704",
                            Name = "Lincoln's scared walnut milk",
                            Storage = 71,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "ad3bf06b-9c2d-4c3e-8fdd-d0fec4ef99b6",
                            Name = "Kentrell's rough almond milk",
                            Storage = 40,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "1627d6d8-1a96-4011-8294-49b9f1e90ba8",
                            Name = "Kentrell's scientific macadamia milk",
                            Storage = 1,
                            Type = "Macadamia milk"
                        },
                        new
                        {
                            ProductId = "886fa2ee-e61f-42e8-8f90-80d46f792924",
                            Name = "Catrina's aware macadamia milk",
                            Storage = 64,
                            Type = "Macadamia milk"
                        },
                        new
                        {
                            ProductId = "0597329f-b2fb-49a9-a5fd-13797fa1d7ce",
                            Name = "Marion's torpid soy milk",
                            Storage = 41,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "63937d8a-aaf5-46b4-a997-f78eda7b6157",
                            Name = "Harlie's squealing pea milk",
                            Storage = 47,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "95992ab8-183a-4e19-b404-970e24d5300a",
                            Name = "Elliot's unbiased pea milk",
                            Storage = 48,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "df679bb2-a8b0-41af-a291-02b28c10c4ff",
                            Name = "Tea's strong hemp milk",
                            Storage = 19,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "ce87d24d-e70d-4b21-961c-addc7162f792",
                            Name = "Nehemiah's wealthy cashew milk",
                            Storage = 35,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "38730f3c-009e-4873-995e-7a023a8f759f",
                            Name = "Judith's quickest oat milk",
                            Storage = 84,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "77afcf09-4b31-445d-b33d-66e197dcbdd0",
                            Name = "Karlee's painful rice milk",
                            Storage = 55,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "e250de50-a606-49d9-afa7-fa118c9a3184",
                            Name = "Joshua's rotten oat milk",
                            Storage = 15,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "52c82b59-042b-4b40-8c12-6475156cc87e",
                            Name = "Kristian's bumpy pea milk",
                            Storage = 33,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "ba46543f-2bd3-449e-8e62-ee6f269bfc10",
                            Name = "Jonah's early hemp milk",
                            Storage = 44,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "9373d575-0d21-4e11-80d6-e7e35a836f28",
                            Name = "Stephen's wealthy hemp milk",
                            Storage = 34,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "9a2bfc2f-2a8f-4a62-92b0-dcdcca37bba2",
                            Name = "Felicity's second cashew milk",
                            Storage = 76,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "a83d309f-ebe5-4bed-9555-bc18869d98ca",
                            Name = "Elliot's voiceless cashew milk",
                            Storage = 87,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "41916cd4-9d74-4222-9fa8-114a2d3a64ce",
                            Name = "Zain's wealthy cashew milk",
                            Storage = 71,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            ProductId = "48029d08-8dcb-486e-8cc8-86961f8658dc",
                            Name = "Dominik's rough whole milk",
                            Storage = 83,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "34a5ceb6-0c67-4794-936b-db67c5ff9109",
                            Name = "Karlee's rough soy milk",
                            Storage = 99,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "7cb2ff70-98b4-4735-8cc0-25bc2d37ad44",
                            Name = "Tyquan's wholesale almond milk",
                            Storage = 21,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "ffd3b484-ede9-43da-aad8-d4d318438d7d",
                            Name = "Cora's loose pea milk",
                            Storage = 70,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "2ce0972a-915a-4f42-afe9-09e9364c9668",
                            Name = "Catrina's fallacious coconut milk",
                            Storage = 54,
                            Type = "Coconut milk"
                        },
                        new
                        {
                            ProductId = "6774d933-12ec-4db4-ac3e-215e817a4a56",
                            Name = "Judith's rotten rice milk",
                            Storage = 43,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "2ef1b9a2-870b-4b78-87c1-1d73070c4cd4",
                            Name = "Jedidiah's cumbersome oat milk",
                            Storage = 16,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "b6679277-32a8-4d7c-9e19-2799aa9a3fb3",
                            Name = "Karlee's tan oat milk",
                            Storage = 39,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "4f183948-3744-4e9e-8907-c6f10644cfbf",
                            Name = "Johnny's quickest rice milk",
                            Storage = 41,
                            Type = "Rice milk"
                        },
                        new
                        {
                            ProductId = "f6e801ff-336e-4aa7-879b-13b16bef285f",
                            Name = "Samuel's broad soy milk",
                            Storage = 33,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "663da2d8-bde6-4eb6-94a3-01bf4c3f8c4f",
                            Name = "Rodney's relevant hemp milk",
                            Storage = 56,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "4e46d68b-cd90-4549-8f49-644fd4fe7a61",
                            Name = "Joan's numberless soy milk",
                            Storage = 98,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "4500a34b-e06e-4a5f-89fd-7804611e9e51",
                            Name = "Tea's alive almond milk",
                            Storage = 55,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "33f05a1b-de2e-4319-b279-2313478dd891",
                            Name = "Duane's typical walnut milk",
                            Storage = 89,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "85a307d1-3af5-410a-8cfa-31489fdc9df1",
                            Name = "Benjamin's scared whole milk",
                            Storage = 4,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "87704f41-8529-4268-aaad-5c20023d0db6",
                            Name = "Jaquez's whole oat milk",
                            Storage = 50,
                            Type = "Oat milk"
                        },
                        new
                        {
                            ProductId = "f8021d2c-c37a-4e62-afe6-02487057cc3b",
                            Name = "Kerry's unbiased whole milk",
                            Storage = 21,
                            Type = "Whole milk"
                        },
                        new
                        {
                            ProductId = "e0041dbf-13bf-4371-9b2c-ff575492411e",
                            Name = "Nehemiah's open almond milk",
                            Storage = 23,
                            Type = "Almond milk"
                        },
                        new
                        {
                            ProductId = "7fb4ac10-d5ba-4403-85d1-236ccc76b378",
                            Name = "Jonah's bumpy hemp milk",
                            Storage = 72,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "cc96a41f-bb3a-450c-ae76-683edc71be52",
                            Name = "Michele's alive walnut milk",
                            Storage = 25,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "28327307-f377-4fc4-b497-d85e09552449",
                            Name = "Kristian's divergent soy milk",
                            Storage = 24,
                            Type = "Soy milk"
                        },
                        new
                        {
                            ProductId = "2702fab9-db1c-44bf-a43f-9107cf21e499",
                            Name = "Joan's full pea milk",
                            Storage = 67,
                            Type = "Pea milk"
                        },
                        new
                        {
                            ProductId = "d407b372-2624-4e7b-8e8b-d6b2c1641e5a",
                            Name = "Lance's steady walnut milk",
                            Storage = 59,
                            Type = "Walnut milk"
                        },
                        new
                        {
                            ProductId = "396937ec-6ae7-4a16-977b-de9544c152b1",
                            Name = "Sheldon's tasteless hemp milk",
                            Storage = 4,
                            Type = "Hemp milk"
                        },
                        new
                        {
                            ProductId = "cf5a5299-c4dd-4699-a8d7-1eed6382888b",
                            Name = "Kristian's early coconut milk",
                            Storage = 35,
                            Type = "Coconut milk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
