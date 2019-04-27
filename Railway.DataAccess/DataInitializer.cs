using Railway.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.DataAccess
{
    class DataInitializer : CreateDatabaseIfNotExists<RailwaysContext>
    {
        protected override void Seed(RailwaysContext context)
        {
            context.Places.AddRange(new List<Place>
            {
                new Place
                {
                   PlaceNumber=1,
                   PlacesLocations="нижнее",
                   Price=14172,
                   Class="Люкс"

                },
                new Place
                {
                   PlaceNumber=2,
                   PlacesLocations="верхнее",
                   Price=14172,
                   Class="Люкс"
                },
                new Place
                {
                  PlaceNumber=3,
                   PlacesLocations="нижнее",
                   Price=14172,
                   Class="Люкс"
                },
                new Place
                {
                  PlaceNumber=4,
                   PlacesLocations="верхнее",
                   Price=14172,
                   Class="Люкс"
                },
                new Place
                {
                   PlaceNumber=5,
                   PlacesLocations="нижнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=6,
                   PlacesLocations="верхнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=7,
                   PlacesLocations="нижнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=8,
                   PlacesLocations="верхнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=9,
                   PlacesLocations="нижнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=10,
                   PlacesLocations="верхнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=11,
                   PlacesLocations="нижнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=12,
                   PlacesLocations="верхнее",
                   Price=10731,
                   Class="Купе"
                },
                new Place
                {
                   PlaceNumber=13,
                   PlacesLocations="нижнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                  PlaceNumber=14,
                   PlacesLocations="верхнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                   PlaceNumber=15,
                   PlacesLocations="нижнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                   PlaceNumber=16,
                   PlacesLocations="верхнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                  PlaceNumber=17,
                   PlacesLocations="нижнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                   PlaceNumber=18,
                   PlacesLocations="верхнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                   PlaceNumber=19,
                   PlacesLocations="нижнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                  PlaceNumber=20,
                   PlacesLocations="верхнее",
                   Price=9731,
                   Class="Плацкарт"
                },
                new Place
                {
                   PlaceNumber=21,
                   PlacesLocations="нижнее",
                   Price=4385,
                   Class="Сидячий"
                },
                new Place
                {
                  PlaceNumber=22,
                   PlacesLocations="верхнее",
                   Price=4385,
                   Class="Сидячий"
                },
                new Place
                {
                   PlaceNumber=23,
                   PlacesLocations="нижнее",
                   Price=4385,
                   Class="Сидячий"
                },
                new Place
                {
                  PlaceNumber=24,
                   PlacesLocations="верхнее",
                   Price=4385,
                   Class="Сидячий"
                }
            });

            context.Wagons.AddRange(new List<Wagon>
            {
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=1
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=2
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=3
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=4
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=5
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=6
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=7
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=8
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=9
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=10
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=11
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=12
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=13
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=14
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=15
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=16
                },
                new Wagon
                {
                 Places=context.Places.ToList(),
                  WagonNumber=17
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=18
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=19
                },
                new Wagon
                {
                 Places=context.Places.ToList(),
                  WagonNumber=20
                },
                new Wagon
                {
                   Places=context.Places.ToList(),
                  WagonNumber=21
                },
                new Wagon
                {
                 Places=context.Places.ToList(),
                  WagonNumber=22
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=23
                },
                new Wagon
                {
                  Places=context.Places.ToList(),
                  WagonNumber=24
                }
            });

            context.Trains.AddRange(new List<Train>
            {
                new Train
                {
                  TrainNumber=1,
                  Wagons=context.Wagons.ToList()
                },
                new Train
                {
                  TrainNumber=1,
                  Wagons=context.Wagons.ToList()
                },
                new Train
                {
                   TrainNumber=1,
                  Wagons=context.Wagons.ToList()
                },
                new Train
                {
                  TrainNumber=1,
                  Wagons=context.Wagons.ToList()
                }
            });

            context.Routes.AddRange(new List<Route>
            {
                new Route
                {
                 RouteName="Астана - Кустанай",
                 City=
                    {
                        "Астана",
                        "Атбасар ",
                        "Есиль",
                        "Кушмурун",
                        "Тобол",
                        "Кустанай"
                    }
                },
                new Route
                {
                   RouteName="Астана - Туркестан",
                 City=
                    {
                        "Астана",
                        "Караганды ",
                        "Шу",
                        "Тараз",
                        "Шымкент",
                        "Туркестан"
                    }
                },
                new Route
                {
                   RouteName="Астана - Уральск",
                 City=
                    {
                        "Астана",
                        "Атбасар ",
                        "Есиль",
                        "Кушмурун",
                        "Тобол",
                        "Уральск"
                    }
                },
                new Route
                {
                  RouteName="Астана - Оскемен",
                 City=
                    {
                        "Астана",
                        "Сары Оба ",
                        "Шидерты",
                        "Спутник",
                        "Аксу",
                        "Семей",
                        "Оскемен"
                    }
                }
            });

            context.RouteLists.AddRange(new List<RouteList>
            {
                 new RouteList
                {
                    Routes=context.Routes.ToList()
                }
            });

            context.Users.AddRange(new List<User>
            {
                 new User
                {
                    Email="admin",
                    Password="1"
                }
            });
        }
    }
}
