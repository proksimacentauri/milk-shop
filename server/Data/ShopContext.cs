using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.Models;

    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product {
            Name = "Dillion's unequaled cashew milk",
            Type = "Cashew milk",
            Storage = 99,
            ProductId = "301d5dcf-a2a8-4a34-b26b-efcaa103963c"
        },
        new Product {
            Name = "Monet's powerful cashew milk",
            Type = "Cashew milk",
            Storage = 27,
            ProductId = "1277e861-b33b-485d-b86f-400769d25a82"
        },
        new Product {
            Name = "Julianne's relevant pea milk",
            Type = "Pea milk",
            Storage = 33,
            ProductId = "210aeed2-413b-4e53-98e7-62c9f6fd31ba"
        },
        new Product {
            Name = "Macie's broad walnut milk",
            Type = "Walnut milk",
            Storage = 23,
            ProductId = "72204ea0-29e2-4da8-bf57-648b37268b71"
        },
        new Product {
            Name = "Christa's fearful rice milk",
            Type = "Rice milk",
            Storage = 46,
            ProductId = "06d60157-e9c7-4bd9-b2a6-00fd63bb2033"
        },
        new Product {
            Name = "Shakayla's loose coconut milk",
            Type = "Coconut milk",
            Storage = 82,
            ProductId = "6905f2f6-e80c-4601-8ae6-5408485ef9c5"
        },
        new Product {
            Name = "Duane's salty soy milk",
            Type = "Soy milk",
            Storage = 24,
            ProductId = "10aed344-837d-4621-873e-aeac9394c99f"
        },
        new Product {
            Name = "Deangelo's rotten hemp milk",
            Type = "Hemp milk",
            Storage = 59,
            ProductId = "2ceec543-8fd9-4c7c-855a-c1388a68ca78"
        },
        new Product {
            Name = "Gaven's numberless walnut milk",
            Type = "Walnut milk",
            Storage = 89,
            ProductId = "dd9140c5-af1d-4861-9736-e0b4f4a81bb7"
        },
        new Product {
            Name = "Tea's scientific rice milk",
            Type = "Rice milk",
            Storage = 15,
            ProductId = "0798ae22-c922-4b47-adc5-23feac38020f"
        },
        new Product {
            Name = "Cora's early almond milk",
            Type = "Almond milk",
            Storage = 58,
            ProductId = "3dbf9e44-fb2f-487b-8b34-7e6e6700e17e"
        },
        new Product {
            Name = "Jonah's aware cashew milk",
            Type = "Cashew milk",
            Storage = 79,
            ProductId = "ea1aadc3-bd1e-4f43-a46d-e035e7a96282"
        },
        new Product {
            Name = "Catrina's fallacious almond milk",
            Type = "Almond milk",
            Storage = 62,
            ProductId = "1bba8dfc-07af-414d-b85d-663443612e5b"
        },
        new Product {
            Name = "Kristian's quickest oat milk",
            Type = "Oat milk",
            Storage = 37,
            ProductId = "2534898d-223e-49f8-9a4f-2993458fc5f2"
        },
        new Product {
            Name = "Jessi's unbiased almond milk",
            Type = "Almond milk",
            Storage = 76,
            ProductId = "3989e76f-0546-4b01-bad6-5d52535e8136"
        },
        new Product {
            Name = "Jean's wide hemp milk",
            Type = "Hemp milk",
            Storage = 90,
            ProductId = "fe7c5123-4141-427e-92ed-e9b41bf88c2a"
        },
        new Product {
            Name = "Stephen's torpid walnut milk",
            Type = "Walnut milk",
            Storage = 26,
            ProductId = "b3a8ed8d-be54-40b7-9880-5e7df192b981"
        },
        new Product {
            Name = "Christa's squealing cashew milk",
            Type = "Cashew milk",
            Storage = 100,
            ProductId = "d6e96a38-ce76-42d9-95a4-7247ea4dcb7a"
        },
        new Product {
            Name = "Dominik's fearful oat milk",
            Type = "Oat milk",
            Storage = 25,
            ProductId = "b48a9bbd-ef6b-4205-8c06-014e891a9faf"
        },
        new Product {
            Name = "Joshua's full macadamia milk",
            Type = "Macadamia milk",
            Storage = 44,
            ProductId = "352139db-6f31-4856-83eb-4142c92a3c44"
        },
        new Product {
            Name = "Judith's orange cashew milk",
            Type = "Cashew milk",
            Storage = 85,
            ProductId = "3e437e24-8d75-4063-acbf-827d3c833d90"
        },
        new Product {
            Name = "Kentrell's unequaled whole milk",
            Type = "Whole milk",
            Storage = 51,
            ProductId = "283ff036-d83d-403c-8a67-b25f1c096682"
        },
        new Product {
            Name = "Kristian's wealthy cashew milk",
            Type = "Cashew milk",
            Storage = 11,
            ProductId = "7786da9f-efb9-4e4d-828b-3cf85f1e63c6"
        },
        new Product {
            Name = "Dominik's alive whole milk",
            Type = "Whole milk",
            Storage = 97,
            ProductId = "e554d358-ec1c-4b9b-97a3-97fa999abb64"
        },
        new Product {
            Name = "Jean's scared coconut milk",
            Type = "Coconut milk",
            Storage = 25,
            ProductId = "3f2a611a-4d0b-41e1-8165-2f8f9a1f66aa"
        },
        new Product {
            Name = "Sheldon's tasteless cashew milk",
            Type = "Cashew milk",
            Storage = 80,
            ProductId = "fd2349a0-3d48-4d9b-ac22-6290d1053495"
        },
        new Product {
            Name = "Jocelyn's rough soy milk",
            Type = "Soy milk",
            Storage = 25,
            ProductId = "e80064ce-5599-46f6-a2d9-6bc7a1aca872"
        },
        new Product {
            Name = "Chandler's full oat milk",
            Type = "Oat milk",
            Storage = 32,
            ProductId = "9466032f-db34-49d3-9ae3-7385cc0082f7"
        },
        new Product {
            Name = "Tea's wide pea milk",
            Type = "Pea milk",
            Storage = 40,
            ProductId = "d84696a9-600d-4912-914d-bbb7f6a5e744"
        },
        new Product {
            Name = "Dillion's taboo hemp milk",
            Type = "Hemp milk",
            Storage = 58,
            ProductId = "50045980-f3c9-408b-83bf-a98db403d42d"
        },
        new Product {
            Name = "Korbin's open pea milk",
            Type = "Pea milk",
            Storage = 94,
            ProductId = "81bd9a68-5599-4018-990a-694b519a9bdb"
        },
        new Product {
            Name = "Stephen's fearful macadamia milk",
            Type = "Macadamia milk",
            Storage = 100,
            ProductId = "7be33cd3-311a-4418-a24d-a501c8d31465"
        },
        new Product {
            Name = "Jessalyn's fallacious almond milk",
            Type = "Almond milk",
            Storage = 65,
            ProductId = "d2f12e7b-f096-4391-ad72-b4517deb24cf"
        },
        new Product {
            Name = "Jaeden's cooing cashew milk",
            Type = "Cashew milk",
            Storage = 33,
            ProductId = "50a70194-f239-43f6-81de-25628b27ea5a"
        },
        new Product {
            Name = "Christa's wealthy whole milk",
            Type = "Whole milk",
            Storage = 84,
            ProductId = "0ac95b83-bdce-497c-b0c3-7c0071419324"
        },
        new Product {
            Name = "Judith's bumpy almond milk",
            Type = "Almond milk",
            Storage = 66,
            ProductId = "ff6524a8-ab9c-4320-8c41-17e3a8da268e"
        },
        new Product {
            Name = "Jaquez's unequaled hemp milk",
            Type = "Hemp milk",
            Storage = 76,
            ProductId = "9001c051-305d-462c-aefb-be220eadae6b"
        },
        new Product {
            Name = "Elliot's recent almond milk",
            Type = "Almond milk",
            Storage = 50,
            ProductId = "0037a064-7ce1-4c97-b8a0-51848775a7a9"
        },
        new Product {
            Name = "Brittney's unbiased coconut milk",
            Type = "Coconut milk",
            Storage = 96,
            ProductId = "9811f876-ebc9-44f0-88ae-1d087cb940db"
        },
        new Product {
            Name = "Dillion's rough rice milk",
            Type = "Rice milk",
            Storage = 56,
            ProductId = "179670c3-e49f-4655-ab71-12a90b912cc5"
        },
        new Product {
            Name = "Lucero's wholesale whole milk",
            Type = "Whole milk",
            Storage = 46,
            ProductId = "602d410e-46e1-4744-9b82-cfc7dd5d0940"
        },
        new Product {
            Name = "Jedidiah's early almond milk",
            Type = "Almond milk",
            Storage = 49,
            ProductId = "aa5ce91a-67e6-4349-b1c2-4c4050efb49e"
        },
        new Product {
            Name = "Kasey's quickest hemp milk",
            Type = "Hemp milk",
            Storage = 4,
            ProductId = "78b2fb8e-4c91-439e-a479-f8c1e9595343"
        },
        new Product {
            Name = "Kasey's wide rice milk",
            Type = "Rice milk",
            Storage = 54,
            ProductId = "1d52f5a1-4c39-4352-85df-168320fb3575"
        },
        new Product {
            Name = "Judith's steady pea milk",
            Type = "Pea milk",
            Storage = 32,
            ProductId = "2f1ce24b-9536-4988-a8b5-c7d9334b74ce"
        },
        new Product {
            Name = "Benjamin's taboo soy milk",
            Type = "Soy milk",
            Storage = 87,
            ProductId = "d3ba0a73-29a1-4802-b284-a498df060c42"
        },
        new Product {
            Name = "Gaven's early cashew milk",
            Type = "Cashew milk",
            Storage = 36,
            ProductId = "1dda5869-263d-460c-8275-3b131e17c601"
        },
        new Product {
            Name = "Kentrell's loose hemp milk",
            Type = "Hemp milk",
            Storage = 79,
            ProductId = "7d1d6d3d-160c-4461-9b93-385041a224a2"
        },
        new Product {
            Name = "Johnny's second whole milk",
            Type = "Whole milk",
            Storage = 54,
            ProductId = "a3df7049-9b81-476d-a803-e8ed8aca161a"
        },
        new Product {
            Name = "Quincy's whole soy milk",
            Type = "Soy milk",
            Storage = 10,
            ProductId = "2356a84e-0fbb-4b5b-993c-0bc6c70586e2"
        },
        new Product {
            Name = "Kasey's painful pea milk",
            Type = "Pea milk",
            Storage = 62,
            ProductId = "b1b4f84b-57f2-420a-9506-ac0636935ab0"
        },
        new Product {
            Name = "Nehemiah's salty hemp milk",
            Type = "Hemp milk",
            Storage = 4,
            ProductId = "99370f4e-7b31-4d0f-94ab-bd6dae094ddb"
        },
        new Product {
            Name = "Jonah's second hemp milk",
            Type = "Hemp milk",
            Storage = 26,
            ProductId = "27ebf833-e1ba-40a6-b101-da4eb71313d8"
        },
        new Product {
            Name = "Korbin's fearful walnut milk",
            Type = "Walnut milk",
            Storage = 27,
            ProductId = "264a505c-4d88-4a61-966c-471d5233d8d1"
        },
        new Product {
            Name = "Deangelo's onerous walnut milk",
            Type = "Walnut milk",
            Storage = 57,
            ProductId = "62603a88-f96f-4beb-a0ed-98358826974a"
        },
        new Product {
            Name = "Joshua's existing rice milk",
            Type = "Rice milk",
            Storage = 73,
            ProductId = "697a783b-43e4-478e-bd1b-253676e43c0b"
        },
        new Product {
            Name = "Lincoln's scared walnut milk",
            Type = "Walnut milk",
            Storage = 71,
            ProductId = "1fcb5bbb-0fa4-40d5-92ae-0e751c18d704"
        },
        new Product {
            Name = "Kentrell's rough almond milk",
            Type = "Almond milk",
            Storage = 40,
            ProductId = "ad3bf06b-9c2d-4c3e-8fdd-d0fec4ef99b6"
        },
        new Product {
            Name = "Kentrell's scientific macadamia milk",
            Type = "Macadamia milk",
            Storage = 1,
            ProductId = "1627d6d8-1a96-4011-8294-49b9f1e90ba8"
        },
        new Product {
            Name = "Catrina's aware macadamia milk",
            Type = "Macadamia milk",
            Storage = 64,
            ProductId = "886fa2ee-e61f-42e8-8f90-80d46f792924"
        },
        new Product {
            Name = "Marion's torpid soy milk",
            Type = "Soy milk",
            Storage = 41,
            ProductId = "0597329f-b2fb-49a9-a5fd-13797fa1d7ce"
        },
        new Product {
            Name = "Harlie's squealing pea milk",
            Type = "Pea milk",
            Storage = 47,
            ProductId = "63937d8a-aaf5-46b4-a997-f78eda7b6157"
        },
        new Product {
            Name = "Elliot's unbiased pea milk",
            Type = "Pea milk",
            Storage = 48,
            ProductId = "95992ab8-183a-4e19-b404-970e24d5300a"
        },
        new Product {
            Name = "Tea's strong hemp milk",
            Type = "Hemp milk",
            Storage = 19,
            ProductId = "df679bb2-a8b0-41af-a291-02b28c10c4ff"
        },
        new Product {
            Name = "Nehemiah's wealthy cashew milk",
            Type = "Cashew milk",
            Storage = 35,
            ProductId = "ce87d24d-e70d-4b21-961c-addc7162f792"
        },
        new Product {
            Name = "Judith's quickest oat milk",
            Type = "Oat milk",
            Storage = 84,
            ProductId = "38730f3c-009e-4873-995e-7a023a8f759f"
        },
        new Product {
            Name = "Karlee's painful rice milk",
            Type = "Rice milk",
            Storage = 55,
            ProductId = "77afcf09-4b31-445d-b33d-66e197dcbdd0"
        },
        new Product {
            Name = "Joshua's rotten oat milk",
            Type = "Oat milk",
            Storage = 15,
            ProductId = "e250de50-a606-49d9-afa7-fa118c9a3184"
        },
        new Product {
            Name = "Kristian's bumpy pea milk",
            Type = "Pea milk",
            Storage = 33,
            ProductId = "52c82b59-042b-4b40-8c12-6475156cc87e"
        },
        new Product {
            Name = "Jonah's early hemp milk",
            Type = "Hemp milk",
            Storage = 44,
            ProductId = "ba46543f-2bd3-449e-8e62-ee6f269bfc10"
        },
        new Product {
            Name = "Stephen's wealthy hemp milk",
            Type = "Hemp milk",
            Storage = 34,
            ProductId = "9373d575-0d21-4e11-80d6-e7e35a836f28"
        },
        new Product {
            Name = "Felicity's second cashew milk",
            Type = "Cashew milk",
            Storage = 76,
            ProductId = "9a2bfc2f-2a8f-4a62-92b0-dcdcca37bba2"
        },
        new Product {
            Name = "Elliot's voiceless cashew milk",
            Type = "Cashew milk",
            Storage = 87,
            ProductId = "a83d309f-ebe5-4bed-9555-bc18869d98ca"
        },
        new Product {
            Name = "Zain's wealthy cashew milk",
            Type = "Cashew milk",
            Storage = 71,
            ProductId = "41916cd4-9d74-4222-9fa8-114a2d3a64ce"
        },
        new Product {
            Name = "Dominik's rough whole milk",
            Type = "Whole milk",
            Storage = 83,
            ProductId = "48029d08-8dcb-486e-8cc8-86961f8658dc"
        },
        new Product {
            Name = "Karlee's rough soy milk",
            Type = "Soy milk",
            Storage = 99,
            ProductId = "34a5ceb6-0c67-4794-936b-db67c5ff9109"
        },
        new Product {
            Name = "Tyquan's wholesale almond milk",
            Type = "Almond milk",
            Storage = 21,
            ProductId = "7cb2ff70-98b4-4735-8cc0-25bc2d37ad44"
        },
        new Product {
            Name = "Cora's loose pea milk",
            Type = "Pea milk",
            Storage = 70,
            ProductId = "ffd3b484-ede9-43da-aad8-d4d318438d7d"
        },
        new Product {
            Name = "Catrina's fallacious coconut milk",
            Type = "Coconut milk",
            Storage = 54,
            ProductId = "2ce0972a-915a-4f42-afe9-09e9364c9668"
        },
        new Product {
            Name = "Judith's rotten rice milk",
            Type = "Rice milk",
            Storage = 43,
            ProductId = "6774d933-12ec-4db4-ac3e-215e817a4a56"
        },
        new Product {
            Name = "Jedidiah's cumbersome oat milk",
            Type = "Oat milk",
            Storage = 16,
            ProductId = "2ef1b9a2-870b-4b78-87c1-1d73070c4cd4"
        },
        new Product {
            Name = "Karlee's tan oat milk",
            Type = "Oat milk",
            Storage = 39,
            ProductId = "b6679277-32a8-4d7c-9e19-2799aa9a3fb3"
        },
        new Product {
            Name = "Johnny's quickest rice milk",
            Type = "Rice milk",
            Storage = 41,
            ProductId = "4f183948-3744-4e9e-8907-c6f10644cfbf"
        },
        new Product {
            Name = "Samuel's broad soy milk",
            Type = "Soy milk",
            Storage = 33,
            ProductId = "f6e801ff-336e-4aa7-879b-13b16bef285f"
        },
        new Product {
            Name = "Rodney's relevant hemp milk",
            Type = "Hemp milk",
            Storage = 56,
            ProductId = "663da2d8-bde6-4eb6-94a3-01bf4c3f8c4f"
        },
        new Product {
            Name = "Joan's numberless soy milk",
            Type = "Soy milk",
            Storage = 98,
            ProductId = "4e46d68b-cd90-4549-8f49-644fd4fe7a61"
        },
        new Product {
            Name = "Tea's alive almond milk",
            Type = "Almond milk",
            Storage = 55,
            ProductId = "4500a34b-e06e-4a5f-89fd-7804611e9e51"
        },
        new Product {
            Name = "Duane's typical walnut milk",
            Type = "Walnut milk",
            Storage = 89,
            ProductId = "33f05a1b-de2e-4319-b279-2313478dd891"
        },
        new Product {
            Name = "Benjamin's scared whole milk",
            Type = "Whole milk",
            Storage = 4,
            ProductId = "85a307d1-3af5-410a-8cfa-31489fdc9df1"
        },
        new Product {
            Name = "Jaquez's whole oat milk",
            Type = "Oat milk",
            Storage = 50,
            ProductId = "87704f41-8529-4268-aaad-5c20023d0db6"
        },
        new Product {
            Name = "Kerry's unbiased whole milk",
            Type = "Whole milk",
            Storage = 21,
            ProductId = "f8021d2c-c37a-4e62-afe6-02487057cc3b"
        },
        new Product {
            Name = "Nehemiah's open almond milk",
            Type = "Almond milk",
            Storage = 23,
            ProductId = "e0041dbf-13bf-4371-9b2c-ff575492411e"
        },
        new Product {
            Name = "Jonah's bumpy hemp milk",
            Type = "Hemp milk",
            Storage = 72,
            ProductId = "7fb4ac10-d5ba-4403-85d1-236ccc76b378"
        },
        new Product {
            Name = "Michele's alive walnut milk",
            Type = "Walnut milk",
            Storage = 25,
            ProductId = "cc96a41f-bb3a-450c-ae76-683edc71be52"
        },
        new Product {
            Name = "Kristian's divergent soy milk",
            Type = "Soy milk",
            Storage = 24,
            ProductId = "28327307-f377-4fc4-b497-d85e09552449"
        },
        new Product {
            Name = "Joan's full pea milk",
            Type = "Pea milk",
            Storage = 67,
            ProductId = "2702fab9-db1c-44bf-a43f-9107cf21e499"
        },
        new Product {
            Name = "Lance's steady walnut milk",
            Type = "Walnut milk",
            Storage = 59,
            ProductId = "d407b372-2624-4e7b-8e8b-d6b2c1641e5a"
        },
        new Product {
            Name = "Sheldon's tasteless hemp milk",
            Type = "Hemp milk",
            Storage = 4,
            ProductId = "396937ec-6ae7-4a16-977b-de9544c152b1"
        },
        new Product {
            Name = "Kristian's early coconut milk",
            Type = "Coconut milk",
            Storage = 35,
            ProductId = "cf5a5299-c4dd-4699-a8d7-1eed6382888b"
        }
        );
    }
        public DbSet<server.Models.Product> Product { get; set; } = default!;
    }
