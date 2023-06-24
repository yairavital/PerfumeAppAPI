//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using PerfumeAppAPI.Data.Entities;

//namespace PerfumeAppAPI.Data
//{
//    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
//    {
//        public void Configure(EntityTypeBuilder<Product> builder)
//        {
//            builder.HasData(
//                new Product
//                {
//                    Id = "1",
//                    ImgSrc = "https://img.zap.co.il/pics/6/9/5/0/47700596c.gif",
//                    Name = "chanelBlu",
//                    Price = 245,
//                    Gender = Enums.Gender.Man,
//                    ProductType = Enums.ProductType.Perfume,
//                    OnSale = false,
//                },
//                       new Product
//                       {
//                           Id = "2",
//                           ImgSrc = "https://ksp.co.il/shop/items/512/50083.jpg?V=23020508",
//                           Name = "SauvageDior",
//                           Price = 200,
//                           Gender = Enums.Gender.Man,
//                           ProductType = Enums.ProductType.Perfume,
//                           OnSale = false,
//                       },
//                       new Product
//                       {
//                           Id = "3",
//                           ImgSrc = "https://la-essence.com/wp-content/uploads/2021/12/Cat_491009_1064-300x300.jpg",
//                           Name = "Lacost Home",
//                           Price = 185,
//                           Gender = Enums.Gender.Man,
//                           ProductType = Enums.ProductType.Perfume,
//                           OnSale = false,
//                       },
//                       new Product
//                       {
//                           Id = "4",
//                           ImgSrc = "./assets/Images/PerfumesImages/Explorer.jpg",
//                           Name = "Explorer",
//                           Price = 175,
//                           Gender = Enums.Gender.Man,
//                           ProductType = Enums.ProductType.Perfume,
//                           OnSale = true,
//                       },
//                        new Product
//                        {
//                            Id = "5",
//                            ImgSrc = "./assets/Images/PerfumesImages/Hermes-Terre-DHermes-Parfum-200ml-.jpeg",
//                            Name = "Terre DHermes",
//                            Price = 160,
//                            Gender = Enums.Gender.Man,
//                            ProductType = Enums.ProductType.Perfume,
//                            OnSale = true,
//                        },
//                         new Product
//                         {
//                             Id = "6",
//                             ImgSrc = "https://www.lovenmour.co.il/images/thumbs/002/0022419_-tester-dior-homme-sport-125ml-edt-_360.jpeg",
//                             Name = "DIOR HOMME SPORT",
//                             Price = 190,
//                             Gender = Enums.Gender.Man,
//                             ProductType = Enums.ProductType.Perfume,
//                             OnSale = false,
//                         },
//                          new Product
//                          {
//                              Id = "7",
//                              ImgSrc = "./assets/Images/PerfumesImages/StrongerArmaniMan.jpg",
//                              Name = "STRONGER ARMANI",
//                              Price = 245,
//                              Gender = Enums.Gender.Man,
//                              ProductType = Enums.ProductType.Perfume,
//                              OnSale = false,
//                          },
//                          new Product
//                          {
//                              Id = "8",
//                              ImgSrc = "./assets/Images/PerfumesImages/HUGO_BOSS_BOTTLED.jpg",
//                              Name = "HUGO BOSS BOTTLED",
//                              Price = 150,
//                              Gender = Enums.Gender.Man,
//                              ProductType = Enums.ProductType.Perfume,
//                              OnSale = false,
//                          },
//                           new Product
//                           {
//                               Id = "9",
//                               ImgSrc = "https://img.zap.co.il/pics/2/2/9/3/41023922c.gif",
//                               Name = "Coco Chanel",
//                               Price = 145,
//                               Gender = Enums.Gender.Female,
//                               ProductType = Enums.ProductType.Perfume,
//                               OnSale = true,
//                           },
//                            new Product
//                            {
//                                Id = "10",
//                                ImgSrc = "./assets/Images/PerfumesImages/ChanelWoman.jpeg",
//                                Name = "Gabrielle",
//                                Price = 245,
//                                Gender = Enums.Gender.Female,
//                                ProductType = Enums.ProductType.Perfume,
//                                OnSale = true,
//                            },
//                            new Product
//                            {
//                                Id = "11",
//                                ImgSrc = "./assets/Images/PerfumesImages/ChanelWoman.jpeg",
//                                Name = "Icon Roses",
//                                Price = 200,
//                                Gender = Enums.Gender.Female,
//                                ProductType = Enums.ProductType.Perfume,
//                                OnSale = true,
//                            },
//                            new Product
//                            {
//                                Id = "12",
//                                ImgSrc = "https://img.zap.co.il/pics/5/2/5/6/51736525c.gif",
//                                Name = "Icon Sense",
//                                Price = 120,
//                                Gender = Enums.Gender.Female,
//                                ProductType = Enums.ProductType.Perfume,
//                                OnSale = true,
//                            },
//                            new Product
//                            {
//                                Id = "13",
//                                ImgSrc = "./assets/Images/PerfumesImages/MonParisWoman.png",
//                                Name = "Mon Paris",
//                                Price = 250,
//                                Gender = Enums.Gender.Female,
//                                ProductType = Enums.ProductType.Perfume,
//                                OnSale = false,
//                            },
//                             new Product
//                             {
//                                 Id = "14",
//                                 ImgSrc = "./assets/Images/PerfumesImages/Lancom1Woman.jpg",
//                                 Name = "Lancom",
//                                 Price = 180,
//                                 Gender = Enums.Gender.Female,
//                                 ProductType = Enums.ProductType.Perfume,
//                                 OnSale = false,
//                             },
//                              new Product
//                              {
//                                  Id = "15",
//                                  ImgSrc = "https://img.zap.co.il/pics/0/6/1/1/42951160c.gif",
//                                  Name = "ROBERTO CAVALLI",
//                                  Price = 200,
//                                  Gender = Enums.Gender.Female,
//                                  ProductType = Enums.ProductType.Perfume,
//                                  OnSale = false,
//                              },
//                               new Product
//                               {
//                                   Id = "16",
//                                   ImgSrc = "./assets/Images/PerfumesImages/EuphoriaWoman.jpg",
//                                   Name = "Euphoria",
//                                   Price = 175,
//                                   Gender = Enums.Gender.Female,
//                                   ProductType = Enums.ProductType.Perfume,
//                                   OnSale = false,
//                               },
//                                new Product
//                                {
//                                    Id = "17",
//                                    ImgSrc = "https://il.loccitane.com/media/catalog/product/cache/868d7666b4c2dfc365705813a2412c33/2/4/24et050c20.png",
//                                    Name = "Loccitane",
//                                    Price = 100,
//                                    Gender = Enums.Gender.Female,
//                                    ProductType = Enums.ProductType.Perfume,
//                                    OnSale = false,
//                                },
//                                 new Product
//                                 {
//                                     Id = "18",
//                                     ImgSrc = "https://www.kerastase-usa.com/on/demandware.static/-/Sites-kerastase-master-catalog/default/dw855b5ca9/2019/full-size/blond-absolu/kerastase-blond-absolu-masque-ultra-violet-purple-hair-mask.png",
//                                     Name = "Kerastase",
//                                     Price = 45,
//                                     Gender = Enums.Gender.Female,
//                                     ProductType = Enums.ProductType.HairCair,
//                                     OnSale = false,
//                                 },
//                                 new Product
//                                 {
//                                     Id = "19",
//                                     ImgSrc = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-G7m_QiKgKe4h8dVKMgFSM29-Ns3lNqeoPA&usqp=CAU",
//                                     Name = "SheaMoisture",
//                                     Price = 13,
//                                     Gender = Enums.Gender.Female,
//                                     ProductType = Enums.ProductType.HairCair,
//                                     OnSale = false,
//                                 },
//                                  new Product
//                                  {
//                                      Id = "20",
//                                      ImgSrc = "https://media.allure.com/photos/60ae7a8d05e44d9caa4bda2a/1:1/w_1200,h_1200,c_limit/Pantene%20Pro-V%20Soothing%20Recovery%20Mask%20for%20Unruly%20Frizzy%20Hair.jpg",
//                                      Name = "Pantene",
//                                      Price = 15,
//                                      Gender = Enums.Gender.Female,
//                                      ProductType = Enums.ProductType.HairCair,
//                                      OnSale = false,
//                                  },
//                                   new Product
//                                   {
//                                       Id = "21",
//                                       ImgSrc = "https://media.allure.com/photos/60ae83569b3b5f2e8e7ae2d0/1:1/w_1300,h_1300,c_limit/Eva%20NYC%20Therapy%20Session%20Hair%20Mask.jpg",
//                                       Name = "Eva NYC",
//                                       Price = 20,
//                                       Gender = Enums.Gender.Female,
//                                       ProductType = Enums.ProductType.HairCair,
//                                       OnSale = false,
//                                   },
//                                    new Product
//                                    {
//                                        Id = "22",
//                                        ImgSrc = "./assets/Images/BlowDryConcentrate.png",
//                                        Name = "Blow Dry Concentrate",
//                                        Price = 45,
//                                        Gender = Enums.Gender.Female,
//                                        ProductType = Enums.ProductType.HairCair,
//                                        OnSale = false,
//                                    }
















//                );
//        }
//    }
//}
