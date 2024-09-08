using SlimeRancherWikiAPI.Models;
using System;
using System.Reflection;

namespace SlimeRancherWikiAPI.Data
{
    public class Seed
    {
        public static async void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Slimes.Any())
                {
                    /*==-- DIETS --==*/

                    Diet fruit = new Diet { Name = "Фрукти", ImgUrl = "diets/Fruit.webp", };
                    Diet veggie = new Diet { Name = "Овочі", ImgUrl = "diets/Veggie.webp", };
                    Diet meat = new Diet { Name = "М'ясо", ImgUrl = "diets/Meat.webp", };
                    Diet omnivorous = new Diet { Name = "Всеїдний", ImgUrl = "diets/All.webp", };

                    await context.AddRangeAsync(fruit, veggie, meat, omnivorous);


                    /*==-- LOACTIONS --==*/

                    Location theDryReef = new Location { Name = "Сухий Риф", ImgUrl = "locations/The_Dry_Reef.webp", };
                    Location theIndigoQuarry = new Location { Name = "Індиговий Кар'єр", ImgUrl = "locations/Indigo_Quarry.webp", };
                    Location theMossBlanket = new Location { Name = "Моховий Покрив", ImgUrl = "locations/The_Moss_Blanket.webp", };
                    Location theAncientRuins = new Location { Name = "Стародавні Руїни", ImgUrl = "locations/The_Ancient_Ruins.webp", };
                    Location theGlassDesert = new Location { Name = "Скляна Пустеля", ImgUrl = "locations/The_Glass_Desert.webp", };
                    Location theWilds = new Location { Name = "Дикі Землі", ImgUrl = "locations/The_Wilds.webp", };
                    Location nimbleValley = new Location { Name = "Швидка Долина", ImgUrl = "locations/Nimble_Valley.webp", };
                    Location theSlimeulation = new Location { Name = "Слаймуляція", ImgUrl = "locations/Slimeulation.webp", };
                    Location theSlimeSea = new Location { Name = "Слаймове Море", ImgUrl = "locations/The_Slime_Sea.webp", };

                    await context.AddRangeAsync(theDryReef, theIndigoQuarry, theMossBlanket, theAncientRuins,
                        theGlassDesert, theWilds, nimbleValley, theSlimeulation, theSlimeSea);


                    /*==-- FRUITS --==*/

                    Food pogofruit = new Food
                    {
                        Name = "Погофрукт",
                        ImgUrl = "diets/fruits/Pogofruit.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food cuberry = new Food
                    {
                        Name = "Кубниця",
                        ImgUrl = "diets/fruits/Cuberry.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food mintMango = new Food
                    {
                        Name = "М'ятне манго",
                        ImgUrl = "diets/fruits/Mint_Mango.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                        },
                    };

                    Food phaseLemon = new Food
                    {
                        Name = "Фазовий лимон",
                        ImgUrl = "diets/fruits/Phase_Lemon.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                        },
                    };

                    Food pricklePear = new Food
                    {
                        Name = "Колюча груша",
                        ImgUrl = "diets/fruits/Prickle_Pear.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        },
                    };

                    Food kookadoba = new Food
                    {
                        Name = "Кукадоба",
                        ImgUrl = "diets/fruits/Kookadoba.webp",
                        Diet = fruit,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    await context.AddRangeAsync(pogofruit, cuberry, mintMango, phaseLemon, pricklePear, kookadoba);


                    /*==-- VEGGIE --==*/

                    Food carrot = new Food
                    {
                        Name = "Морква",
                        ImgUrl = "diets/veggie/Carrot.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food ocaOca = new Food
                    {
                        Name = "Ока-ока",
                        ImgUrl = "diets/veggie/Oca_Oca.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                        },
                    };

                    Food heartBeet = new Food
                    {
                        Name = "Серцебуряк",
                        ImgUrl = "diets/veggie/Heart_Beet.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food silverParsnip = new Food
                    {
                        Name = "Срібний пастернак",
                        ImgUrl = "diets/veggie/Silver_Parsnip.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        },
                    };

                    Food oddOnion = new Food
                    {
                        Name = "Дивна цибуля",
                        ImgUrl = "diets/veggie/Odd_Onion.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                        },
                    };

                    Food gildedGinger = new Food
                    {
                        Name = "Позолочений імбир",
                        ImgUrl = "diets/veggie/Gilded_Ginger.webp",
                        Diet = veggie,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        },
                    };

                    await context.AddRangeAsync(carrot, ocaOca, heartBeet, silverParsnip, oddOnion, gildedGinger);


                    /*==-- MEAT --==*/

                    Food chickadoo = new Food
                    {
                        Name = "Курчатко",
                        ImgUrl = "diets/meats/Chickadoo.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food henHen = new Food
                    {
                        Name = "Кур-курочка",
                        ImgUrl = "diets/meats/Hen_Hen.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food roostro = new Food
                    {
                        Name = "Півень",
                        ImgUrl = "diets/meats/Roostro.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food stonyChickadoo = new Food
                    {
                        Name = "Кам'янисте курчатко",
                        ImgUrl = "diets/meats/Stony_Chickadoo.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food stonyHen = new Food
                    {
                        Name = "Кам'яниста курочка",
                        ImgUrl = "diets/meats/Stony_Hen.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food briarChickadoo = new Food
                    {
                        Name = "Чагарникове курчатко",
                        ImgUrl = "diets/meats/Briar_Chickadoo.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                        },
                    };

                    Food briarHen = new Food
                    {
                        Name = "Чагарникова курочка",
                        ImgUrl = "diets/meats/Briar_Hen.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                        },
                    };

                    Food paintedChickadoo = new Food
                    {
                        Name = "Фарбоване курчатко",
                        ImgUrl = "diets/meats/Painted_Chickadoo.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        },
                    };

                    Food paintedHen = new Food
                    {
                        Name = "Фарбована курочка",
                        ImgUrl = "diets/meats/Painted_Hen.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        },
                    };

                    Food elderHen = new Food
                    {
                        Name = "Старенька курочка",
                        ImgUrl = "diets/meats/Elder_Hen.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    Food elderRoostro = new Food
                    {
                        Name = "Старенький півень",
                        ImgUrl = "diets/meats/Elder_Roostro.webp",
                        Diet = meat,
                        FoodLocation = new List<FoodLocation>
                        {
                            new FoodLocation{ Location = theDryReef, LocationId = theDryReef.Id, },
                            new FoodLocation{ Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new FoodLocation{ Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new FoodLocation{ Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new FoodLocation{ Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new FoodLocation{ Location = theWilds, LocationId = theWilds.Id, },
                        },
                    };

                    await context.AddRangeAsync(chickadoo, henHen, roostro, stonyChickadoo, stonyHen, briarChickadoo,
                        briarHen, paintedChickadoo, paintedHen, elderHen, elderRoostro);


                    /*==-- SLIMES --==*/

                    Slime pinkSlime = new Slime
                    {
                        Name = "Рожевий слайм",
                        ImgUrl = "slimes/Pink_Slime.webp",
                        FavFood = null,
                        Toy = new Toy
                        {
                            Name = "Пляжний м'яч",
                            ImgUrl = "toys/Beach_Ball.webp",
                            Price = 300
                        },
                        Plort = new Plort
                        {
                            Name = "Рожевий плорт",
                            ImgUrl = "plorts/PlortPINK.webp",
                            MinPrice = 2,
                            AvgPrice = 15,
                            MaxPrice = 27
                        },
                        Diet = omnivorous,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime rockSlime = new Slime
                    {
                        Name = "Кам'яний слайм",
                        ImgUrl = "slimes/Rock_Slime.webp",
                        FavFood = heartBeet,
                        Toy = new Toy
                        {
                            Name = "Великий камінь",
                            ImgUrl = "toys/Big_Rock.webp",
                            Price = 400
                        },
                        Plort = new Plort
                        {
                            Name = "Кам'яний плорт",
                            ImgUrl = "plorts/PlortROCK.webp",
                            MinPrice = 8,
                            AvgPrice = 28,
                            MaxPrice = 48
                        },
                        Diet = veggie,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime tabbySlime = new Slime
                    {
                        Name = "Смугастий слайм",
                        ImgUrl = "slimes/Tabby_Slime.webp",
                        FavFood = stonyHen,
                        Toy = new Toy
                        {
                            Name = "Клубок пряжі",
                            ImgUrl = "toys/Yarn_Ball.webp",
                            Price = 400
                        },
                        Plort = new Plort
                        {
                            Name = "Смугастий плорт",
                            ImgUrl = "plorts/PlortTABBY.webp",
                            MinPrice = 9,
                            AvgPrice = 29,
                            MaxPrice = 49
                        },
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime phosphorSlime = new Slime
                    {
                        Name = "Фосфорний слайм",
                        ImgUrl = "slimes/Phosphor_Slime.webp",
                        FavFood = cuberry,
                        Toy = new Toy
                        {
                            Name = "Нічник",
                            ImgUrl = "toys/Night_Light.webp",
                            Price = 400
                        },
                        Plort = new Plort
                        {
                            Name = "Фосфорний плорт",
                            ImgUrl = "plorts/PlortPHOSPHOR.webp",
                            MinPrice = 9,
                            AvgPrice = 28,
                            MaxPrice = 46
                        },
                        Diet = fruit,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime radSlime = new Slime
                    {
                        Name = "Рад-слайм",
                        ImgUrl = "slimes/Rad_Slime.webp",
                        FavFood = ocaOca,
                        Toy = new Toy
                        {
                            Name = "Енергоблок",
                            ImgUrl = "toys/Power_Cell.webp",
                            Price = 500
                        },
                        Plort = new Plort
                        {
                            Name = "Рад-плорт",
                            ImgUrl = "plorts/PlortRAD.webp",
                            MinPrice = 12,
                            AvgPrice = 55,
                            MaxPrice = 97
                        },
                        Diet = veggie,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime boomSlime = new Slime
                    {
                        Name = "Бум-слайм",
                        ImgUrl = "slimes/Boom_Slime.webp",
                        FavFood = briarHen,
                        Toy = new Toy
                        {
                            Name = "Вибуховий м'яч",
                            ImgUrl = "toys/Bomb_Ball.webp",
                            Price = 500
                        },
                        Plort = new Plort
                        {
                            Name = "Бум-плорт",
                            ImgUrl = "plorts/PlortBOOM.webp",
                            MinPrice = 18,
                            AvgPrice = 54,
                            MaxPrice = 89
                        },
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime honeySlime = new Slime
                    {
                        Name = "Медовий слайм",
                        ImgUrl = "slimes/Honey_Slime.webp",
                        FavFood = mintMango,
                        Toy = new Toy
                        {
                            Name = "Жужільна бджілка",
                            ImgUrl = "toys/Buzzy_Bee.webp",
                            Price = 500
                        },
                        Plort = new Plort
                        {
                            Name = "Медовий плорт",
                            ImgUrl = "plorts/PlortHONEY.webp",
                            MinPrice = 17,
                            AvgPrice = 53,
                            MaxPrice = 88
                        },
                        Diet = fruit,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                        }
                    };

                    Slime puddleSlime = new Slime
                    {
                        Name = "Калюжний слайм",
                        ImgUrl = "slimes/Puddle_Slime.webp",
                        FavFood = null,
                        Toy = new Toy
                        {
                            Name = "Гумова качечка",
                            ImgUrl = "toys/Rubber_Ducky.webp",
                            Price = 500
                        },
                        Plort = new Plort
                        {
                            Name = "Калюжний плорт",
                            ImgUrl = "plorts/PlortPUDDLE.webp",
                            MinPrice = 19,
                            AvgPrice = 56,
                            MaxPrice = 92
                        },
                        Diet = null,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime crystalSlime = new Slime
                    {
                        Name = "Кристалевий слайм",
                        ImgUrl = "slimes/Crystal_Slime.webp",
                        FavFood = oddOnion,
                        Toy = new Toy
                        {
                            Name = "Кришталева куля",
                            ImgUrl = "toys/Crystal_Ball.webp",
                            Price = 600
                        },
                        Plort = new Plort
                        {
                            Name = "Кристалевий плорт",
                            ImgUrl = "plorts/PlortCRYSTAL.webp",
                            MinPrice = 24,
                            AvgPrice = 75,
                            MaxPrice = 125
                        },
                        Diet = veggie,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                        }
                    };

                    Slime hunterSlime = new Slime
                    {
                        Name = "Мисливець-слайм",
                        ImgUrl = "slimes/Hunter_Slime.webp",
                        FavFood = roostro,
                        Toy = new Toy
                        {
                            Name = "Плюшева курочка",
                            ImgUrl = "toys/Stuffed_Chicken.webp",
                            Price = 600
                        },
                        Plort = new Plort
                        {
                            Name = "Мисливець-плорт",
                            ImgUrl = "plorts/PlortHUNTER.webp",
                            MinPrice = 18,
                            AvgPrice = 73,
                            MaxPrice = 127
                        },
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime quantumSlime = new Slime
                    {
                        Name = "Квантовий слайм",
                        ImgUrl = "slimes/Quantum_Slime.webp",
                        FavFood = phaseLemon,
                        Toy = new Toy
                        {
                            Name = "Кубик-загадка",
                            ImgUrl = "toys/Puzzle_Cube.webp",
                            Price = 600
                        },
                        Plort = new Plort
                        {
                            Name = "Квантовий плорт",
                            ImgUrl = "plorts/PlortQUANTUM.webp",
                            MinPrice = 21,
                            AvgPrice = 73,
                            MaxPrice = 124
                        },
                        Diet = fruit,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime fireSlime = new Slime
                    {
                        Name = "Вогняний слайм",
                        ImgUrl = "slimes/Fire_Slime.webp",
                        FavFood = null,
                        Toy = new Toy
                        {
                            Name = "Вугільна цеглина",
                            ImgUrl = "toys/Charcoal_Brick.webp",
                            Price = 700
                        },
                        Plort = new Plort
                        {
                            Name = "Вогняний плорт",
                            ImgUrl = "plorts/PlortFIRE.webp",
                            MinPrice = 27,
                            AvgPrice = 60,
                            MaxPrice = 92
                        },
                        Diet = null,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime dervishSlime = new Slime
                    {
                        Name = "Вихорний слайм",
                        ImgUrl = "slimes/Dervish_Slime.webp",
                        FavFood = pricklePear,
                        Toy = new Toy
                        {
                            Name = "Гіроскопічна дзиґа",
                            ImgUrl = "toys/Gyro_Top.webp",
                            Price = 700
                        },
                        Plort = new Plort
                        {
                            Name = "Вихорний плорт",
                            ImgUrl = "plorts/PlortDERVISH.webp",
                            MinPrice = 33,
                            AvgPrice = 96,
                            MaxPrice = 159
                        },
                        Diet = fruit,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime tangleSlime = new Slime
                    {
                        Name = "Ліанний слайм",
                        ImgUrl = "slimes/Tangle_Slime.webp",
                        FavFood = paintedHen,
                        Toy = new Toy
                        {
                            Name = "Сонячний друг",
                            ImgUrl = "toys/Sol_Mate.webp",
                            Price = 700
                        },
                        Plort = new Plort
                        {
                            Name = "Ліанний плорт",
                            ImgUrl = "plorts/PlortTANGLE.webp",
                            MinPrice = 32,
                            AvgPrice = 94,
                            MaxPrice = 155
                        },
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime mosaicSlime = new Slime
                    {
                        Name = "Мозаїчний слайм",
                        ImgUrl = "slimes/Mosaic_Slime.webp",
                        FavFood = silverParsnip,
                        Toy = new Toy
                        {
                            Name = "Дискокуля",
                            ImgUrl = "toys/Disco_Ball.webp",
                            Price = 700
                        },
                        Plort = new Plort
                        {
                            Name = "Мозаїчний плорт",
                            ImgUrl = "plorts/PlortMOSAIC.webp",
                            MinPrice = 30,
                            AvgPrice = 100,
                            MaxPrice = 170
                        },
                        Diet = veggie,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime saberSlime = new Slime
                    {
                        Name = "Саблезубий слайм",
                        ImgUrl = "slimes/Saber_Slime.webp",
                        FavFood = null,
                        Toy = new Toy
                        {
                            Name = "Стего-друг",
                            ImgUrl = "toys/Stego_Buddy.webp",
                            Price = 700
                        },
                        Plort = new Plort
                        {
                            Name = "Саблезубий плорт",
                            ImgUrl = "plorts/PlortSABER.webp",
                            MinPrice = 31,
                            AvgPrice = 78,
                            MaxPrice = 134
                        },
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theWilds, LocationId = theWilds.Id, },
                        }
                    };

                    Slime quicksilverSlime = new Slime
                    {
                        Name = "Ртутний слайм",
                        ImgUrl = "slimes/Quicksilver_Slime.webp",
                        FavFood = null,
                        Toy = null,
                        Plort = new Plort
                        {
                            Name = "Ртутний плорт",
                            ImgUrl = "plorts/PlortQUICKSILVER.webp",
                            MinPrice = 0,
                            AvgPrice = 0,
                            MaxPrice = 0
                        },
                        Diet = null,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = nimbleValley, LocationId = nimbleValley.Id, },
                        }
                    };

                    Slime glitchSlime = new Slime
                    {
                        Name = "Глітч-слайм",
                        ImgUrl = "slimes/Glitch_Slime.webp",
                        FavFood = null,
                        Toy = null,
                        Plort = null,
                        Diet = null,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theSlimeulation, LocationId = theSlimeulation.Id, },
                        }
                    };

                    Slime goldSlime = new Slime
                    {
                        Name = "Золотий слайм",
                        ImgUrl = "slimes/Gold_Slime.webp",
                        FavFood = gildedGinger,
                        Toy = null,
                        Plort = new Plort
                        {
                            Name = "Золотий плорт",
                            ImgUrl = "plorts/PlortGOLD.webp",
                            MinPrice = 100,
                            AvgPrice = 381,
                            MaxPrice = 661
                        },
                        Diet = null,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    Slime luckySlime = new Slime
                    {
                        Name = "Слайм удачі",
                        ImgUrl = "slimes/Lucky_Slime.webp",
                        FavFood = null,
                        Toy = null,
                        Plort = null,
                        Diet = meat,
                        SlimeLocation = new List<SlimeLocation>
                        {
                            new SlimeLocation { Location = theDryReef, LocationId = theDryReef.Id, },
                            new SlimeLocation { Location = theMossBlanket, LocationId = theMossBlanket.Id, },
                            new SlimeLocation { Location = theIndigoQuarry, LocationId = theIndigoQuarry.Id, },
                            new SlimeLocation { Location = theAncientRuins, LocationId = theAncientRuins.Id, },
                            new SlimeLocation { Location = theGlassDesert, LocationId = theGlassDesert.Id, },
                        }
                    };

                    await context.AddRangeAsync(pinkSlime, rockSlime, tabbySlime, phosphorSlime, radSlime, boomSlime,
                        honeySlime, puddleSlime, crystalSlime, hunterSlime, quantumSlime, fireSlime, dervishSlime,
                        tangleSlime, mosaicSlime, saberSlime, quicksilverSlime, glitchSlime, goldSlime, luckySlime);

                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
