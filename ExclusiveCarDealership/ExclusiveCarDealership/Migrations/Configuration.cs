namespace ExclusiveCarDealership.Migrations {
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExclusiveCarDealership.Models.ApplicationDbContext> {
        public string TesTitle(Random rand) {
            if (rand.NextDouble() < .5) {
                return "Coolest Electric Car, rare color";
            }
            if (rand.NextDouble() < .7) {
                return "Now on sale";
            }
            return "Never buy gas again";
        }

        public decimal RandPrice(Random rand) {
            return (decimal)Math.Round((rand.NextDouble() / 1000) * 100000 * 1000);
        }

        public string GetBriefTes() {
            return "An intergalactic SpaceBoat of Light and Wonder";
        }

        public string GetFullTes() {
            return "Has so many knobs and buttons. Just plain awesome you will never need to buy gas again. Seriously we scored a 103/100 on consumer reports.\nSeriously we are so good we just broke consumer reports";
        }

        Random rand = new Random();


        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExclusiveCarDealership.Models.ApplicationDbContext context) {

            for (int i = 0; i < 50; i++) {
                if (rand.NextDouble() > .3) {
                    context.Teslas.AddOrUpdate(
                                    new ElectricCar {
                                        Base = new Vehicle {
                                            Title = TesTitle(rand),
                                            Price = RandPrice(rand),
                                            Make = "Tesla",
                                            Model = "Model S",
                                            BriefDescription = GetBriefTes(),
                                            FullDescription = GetFullTes(),
                                            ImageUrl = "http://i.imgur.com/uLudWcq.jpg",
                                        },
                                        Range = 270,
                                        ChargeTime = 4
                                    }
                                );
                }
                else {
                    context.RollsRoyces.AddOrUpdate(
                                        new GasCar {
                                            Base = new Vehicle {
                                                Title = "Expensive old persons car",
                                                Price = RandPrice(rand),
                                                Make = "Rolls Royce",
                                                Model = "Phantom",
                                                BriefDescription = "Super expensive car, looks kinda pretty",
                                                FullDescription = "You should really be buying the Teslas instead. They are SpaceBoats of light and wonder",
                                                ImageUrl = "http://i.imgur.com/ZD4upuKl",
                                            },
                                            GaseMileage = rand.Next(10, 12)
                                        }
                                    );
                }
            }
        }
    }
}
