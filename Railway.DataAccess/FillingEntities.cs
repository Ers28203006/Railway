using Railway.Models;
using System.Collections.Generic;
using System.Linq;

namespace Railway.DataAccess
{
    public class FillingEntities
    {
        public static void DatabaseCheck()
        {
            using(var context=new RailwaysContext())
            {
                if (context.RouteLists.Count()==0)
                {
                    Filling();
                }
            }
        }
        static void Filling()
        {
            using (var context = new RailwaysContext())
            {
                #region список маршрутов
                RouteList routeList1 = new RouteList { Name = "Acтана - Костанай" };
                RouteList routeList2 = new RouteList { Name = "Астана - Туркестан" };
                RouteList routeList3 = new RouteList { Name = "Астана - Уральск" };
                RouteList routeList4 = new RouteList { Name = "Астана - Оскемен" };

                context.RouteLists.Add(routeList1);
                context.RouteLists.Add(routeList2);
                context.RouteLists.Add(routeList3);
                context.RouteLists.Add(routeList4);

                context.SaveChanges();
                #endregion

                #region маршруты

                Route route1 = new Route { RouteList = routeList1 };
                Route route2 = new Route { RouteList = routeList2 };
                Route route3 = new Route { RouteList = routeList3 };
                Route route4 = new Route { RouteList = routeList4 };


                List<City> cities = new List<City>
                {

                    new City{ Name="Астана", Route=route1 },
                    new City{ Name="Атбасар", Route=route1 },
                    new City{ Name="Есиль", Route=route1 },
                    new City{ Name="Кушмурун", Route=route1 },
                    new City{ Name="Тобол", Route=route1 },
                    new City{ Name="Костанай", Route=route1 },

                    new City{ Name="Астана", Route=route2 },
                    new City{ Name="Караганды", Route=route2 },
                    new City{ Name="Шу", Route=route2 },
                    new City{ Name="Тараз", Route=route2 },
                    new City{ Name="Шымкент", Route=route2 },
                    new City{ Name="Туркестан", Route=route2 },

                     new City{ Name="Астана", Route=route3 },
                    new City{ Name="Атбасар", Route=route3 },
                    new City{ Name="Есиль", Route=route3 },
                    new City{ Name="Кушмурун", Route=route3 },
                    new City{ Name="Тобол", Route=route3 },
                    new City{ Name="Уральск", Route=route3 },

                    new City{ Name="Астана", Route=route4 },
                    new City{ Name="Сары Оба", Route=route4 },
                    new City{ Name="Шидерты", Route=route4 },
                    new City{ Name="Спутник", Route=route4 },
                    new City{ Name="Аксу", Route=route4 },
                    new City{ Name="Оскемен", Route=route4 }
                };

                context.Cities.AddRange(new List<City>(cities));
                context.SaveChanges();
                #endregion

                #region поезда
                Train train1 = new Train { Id = route1.Id, TrainNumber = 1 };
                Train train2 = new Train { Id = route2.Id, TrainNumber = 2 };
                Train train3 = new Train { Id = route3.Id, TrainNumber = 3 };
                Train train4 = new Train { Id = route4.Id, TrainNumber = 4 };

                context.Trains.AddRange(new List<Train> { train1, train2, train3, train4 });
                context.SaveChanges();
                #endregion

                #region вагоны

                List<Wagon> wagons = new List<Wagon>
                {
                    new Wagon{WagonNumber=1, Train=train1},
                    new Wagon{WagonNumber=2, Train=train1},
                    new Wagon{WagonNumber=3, Train=train1},
                    new Wagon{WagonNumber=4, Train=train1},

                     new Wagon{WagonNumber=1, Train=train2},
                    new Wagon{WagonNumber=2, Train=train2},
                    new Wagon{WagonNumber=3, Train=train2},
                    new Wagon{WagonNumber=4, Train=train2},

                     new Wagon{WagonNumber=1, Train=train3},
                    new Wagon{WagonNumber=2, Train=train3},
                    new Wagon{WagonNumber=3, Train=train3},
                    new Wagon{WagonNumber=4, Train=train3},

                     new Wagon{WagonNumber=1, Train=train4},
                    new Wagon{WagonNumber=2, Train=train4},
                    new Wagon{WagonNumber=3, Train=train4},
                    new Wagon{WagonNumber=4, Train=train4}
                };
                context.Wagons.AddRange(new List<Wagon>(wagons));
                context.SaveChanges();

                #endregion

                #region места в вагоне

                List<Place> places = new List<Place>
                {
                    #region места вагона №1(поезд №1)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[0]
                    },

                    #endregion

                     #region места вагона №2(поезд №1)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[1]
                    },

                    #endregion

                     #region места вагона №3(поезд №1)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[2]
                    },

                    #endregion

                     #region места вагона №4(поезд №1)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[3]
                    },

                    #endregion

                    #region места вагона №1(поезд №2)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[4]
                    },

                    #endregion

                    #region места вагона №2(поезд №2)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[5]
                    },

                    #endregion

                    #region места вагона №3(поезд №2)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[6]
                    },

                    #endregion

                    #region места вагона №4(поезд №2)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[7]
                    },

                    #endregion

                    #region места вагона №1(поезд №3)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[8]
                    },

                    #endregion

                    #region места вагона №2(поезд №3)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[9]
                    },

                    #endregion

                    #region места вагона №3(поезд №3)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[10]
                    },

                    #endregion

                    #region места вагона №4(поезд №3)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[11]
                    },

                    #endregion

                    #region места вагона №1(поезд №4)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[12]
                    },

                    #endregion

                    #region места вагона №2(поезд №4)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[13]
                    },

                    #endregion

                    #region места вагона №3(поезд №4)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[14]
                    },

                    #endregion

                    #region места вагона №1(поезд №4)
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Люкс",
                        PlacesLocations="нижнее",
                        Price=14000,
                        Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=1,
                        Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                       Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=2,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                        Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=3,
                      Class="Купе",
                        PlacesLocations="нижнее",
                        Price=10000,
                         Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=4,
                        Class="Купе",
                        PlacesLocations="верхнее",
                        Price=10000,
                         Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=5,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                         Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=6,
                         Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                         Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=7,
                        Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                       Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=8,
                       Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=9,
                       Class="Плацкарт",
                        PlacesLocations="нижнее",
                        Price=8000,
                         Wagon=wagons[15]
                    },
                    new Place
                    {
                        PlaceNumber=10,
                      Class="Плацкарт",
                        PlacesLocations="верхнее",
                        Price=8000,
                        Wagon=wagons[15]
                    }

                    #endregion
                };

                context.Places.AddRange(new List<Place>(places));
                context.SaveChanges();
                #endregion
            }
        }
    }
}
