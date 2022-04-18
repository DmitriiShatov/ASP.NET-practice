using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class TestData
    {
        public static void Init(BikeContext context) 
        {
            if (!context.Models.Any()) 
            {
                context.Models.AddRange(
                    new Model
                    {
                        Name = "Mount"
                    },
                    new Model
                    {
                        Name = "Sport"
                    },
                    new Model
                    {
                        Name = "Split"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Types.Any()) 
            {
                context.Types.AddRange(
                    new Type 
                    {
                        Name = "Kid"
                    },
                    new Type 
                    {
                        Name = "Man"
                    },
                    new Type 
                    {
                        Name = "Women"
                    });
                context.SaveChanges();
            }
            if (!context.Styles.Any()) 
            {
                context.Styles.AddRange(
                    new Style 
                    {
                        Name = "MountaineBike"
                    },
                    new Style
                    {
                        Name = "SportBike"
                    },
                    new Style 
                    {
                        Name = "RoadBike"
                    });
                context.SaveChanges();
            }
            if (!context.Bikes.Any()) 
            {
                context.Bikes.AddRange(
                    new Bike 
                    {
                        Name = "Rocket",
                        Company = "Lollipop",
                        StyleId = 1,
                        ModelId = 1,
                        TypeId = 1,
                        Price = 1200
                    },
                    new Bike
                    {
                        Name = "Buldozer",
                        Company = "BeastArea",
                        StyleId = 2,
                        ModelId = 2,
                        TypeId = 2,
                        Price = 4200
                    },
                    new Bike
                    {
                        Name = "Rocket",
                        Company = "Lollipop",
                        StyleId = 3,
                        ModelId = 3,
                        TypeId = 3,
                        Price = 1400
                    },
                    new Bike
                    {
                        Name = "ArenaWarrior",
                        Company = "ColoradosBike",
                        StyleId = 2,
                        ModelId = 1,
                        TypeId = 3,
                        Price = 6300
                    },
                    new Bike
                    {
                        Name = "Collapse",
                        Company = "CollapseCorp",
                        StyleId = 3,
                        ModelId = 3,
                        TypeId = 2,
                        Price = 4200
                    },
                    new Bike
                    {
                        Name = "SeriosSam",
                        Company = "Lollipop",
                        StyleId = 3,
                        ModelId = 1,
                        TypeId = 2,
                        Price = 3330
                    },
                    new Bike
                    {
                        Name = "Rocket",
                        Company = "Lollipop",
                        StyleId = 2,
                        ModelId = 2,
                        TypeId = 2,
                        Price = 1600
                    },
                    new Bike
                    {
                        Name = "Lollipop",
                        Company = "Lollipop",
                        StyleId = 1,
                        ModelId = 1,
                        TypeId = 1,
                        Price = 1700
                    });
                context.SaveChanges();
            }
        }
    }
}
