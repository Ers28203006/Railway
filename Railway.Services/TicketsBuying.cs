using Railway.DataAccess;
using Railway.Models;
using System;
using System.Linq;

namespace Railway.Services
{
    public class TicketsBuying
    {
        public static void Input()
        {
            Console.WriteLine("Добро пожаловать в систему заказа железнодорожных билетов.\n" +
                "Для входа в систему введите email:");
            string email = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            Autorization(email, password);
        }
        static void Autorization(string email, string password)
        {
            User user = new User();
            using (var context = new RailwaysContext())
            {
                bool isEntry = false;
                foreach (var u in context.Users.ToList())
                {
                    if (u.Email == email)
                    {
                        isEntry = true;
                        break;
                    }
                }

                if (isEntry == false)
                {
                    Console.WriteLine("Этой учетной записи в системе нет. \n" +
                        "Хотите зарегистрироваться?\n1.- да\n2.- нет");
                    int choice = 0;
                    while (choice == 0)
                    {
                        int.TryParse(Console.ReadLine(), out choice);
                        if (choice <= 0 || choice > 2) choice = 0;
                        else break;
                    }

                    switch (choice)
                    {
                        case 1:
                            Registration(ref user, email, password);
                            Console.WriteLine("Добро пожаловать в систему!");
                            OrderTiket();
                            break;
                        case 2:
                            Console.WriteLine("До свидания!");
                            break;
                    }
                }

                else
                {
                    user = context.Users.FirstOrDefault(u => u.Email == email);
                    if (user.Password == password)
                    {
                        Console.WriteLine("Добро пожаловать в систему!");
                        OrderTiket();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Не верно введен пароль попробуйте снова: ");

                            password = Console.ReadLine();
                            if (user.Password == password)
                            {
                                Console.WriteLine("Добро пожаловать в систему!");
                                OrderTiket();
                                break;
                            }
                        }

                    }
                }

            }

        }

        static void Registration(ref User user, string email, string password)
        {
            using (var context = new RailwaysContext())
            {
                user = new User { Email = email, Password = password };
                context.Users.Add(user);
                context.SaveChanges();

                user = context.Users.FirstOrDefault(u => u.Email == email);
            }
        }

        static void OrderTiket()
        {
            using (var context = new RailwaysContext())
            {
                var routeList = context.RouteLists.ToList();

                Console.WriteLine("Откуда направляетесь:");
                string begin = Console.ReadLine();

                Console.WriteLine("Куда направляетесь:");
                string end = Console.ReadLine();

                int inputSearch1 = 0;
                int countSearch11 = 0;

                for (int i = 0; i < routeList.Count - 3; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == begin)
                            {
                                ++inputSearch1;
                                break;
                            }

                            ++countSearch11;
                        }
                    }
                }

                int outputSearch1 = 0;
                int countSearch12 = 0;

                for (int i = 0; i < routeList.Count - 3; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == end)
                            {
                                ++outputSearch1;
                                break;
                            }
                            ++countSearch12;
                        }
                    }
                }

                if (inputSearch1 > 0 && outputSearch1 > 0 && countSearch11 < countSearch12)
                {
                    for (int i = 0; i < routeList.Count - 3; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");
                                foreach (var place in vagon.Places)
                                {
                                    Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                    Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                    Console.WriteLine($"Класс: {place.Class}");
                                    Console.WriteLine($"Цена: {place.Price}");
                                    Console.WriteLine("*******************");
                                }
                                Console.WriteLine("||||||||||||||||||||||||||||||||");
                            }
                        }
                    }

                }



                int inputSearch2 = 0;
                int countSearch21 = 0;

                for (int i = 1; i < routeList.Count - 2; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == begin)
                            {
                                ++inputSearch2;
                                break;
                            }

                            ++countSearch21;
                        }
                    }
                }

                int outputSearch2 = 0;
                int countSearch22 = 0;

                for (int i = 1; i < routeList.Count - 2; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == end)
                            {
                                ++outputSearch2;
                                break;
                            }
                            ++countSearch22;
                        }
                    }
                }

                if (inputSearch2 > 0 && outputSearch2 > 0 && countSearch21 < countSearch22)
                {
                    for (int i = 1; i < routeList.Count - 2; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");
                                foreach (var place in vagon.Places)
                                {
                                    Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                    Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                    Console.WriteLine($"Класс: {place.Class}");
                                    Console.WriteLine($"Цена: {place.Price}");
                                    Console.WriteLine("*******************");
                                }
                                Console.WriteLine("||||||||||||||||||||||||||||||||");
                            }
                        }
                    }
                }

                int inputSearch3 = 0;
                int countSearch31 = 0;

                for (int i = 2; i < routeList.Count - 1; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == begin)
                            {
                                ++inputSearch3;
                                break;
                            }
                            ++countSearch31;
                        }
                    }
                }

                int outputSearch3 = 0;
                int countSearch32 = 0;

                for (int i = 2; i < routeList.Count - 1; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == end)
                            {
                                ++outputSearch3;
                                break;
                            }
                            ++countSearch32;
                        }
                    }
                }

                if (inputSearch3 > 0 && outputSearch3 > 0 && countSearch31 < countSearch32)
                {
                    for (int i = 2; i < routeList.Count - 1; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");
                                foreach (var place in vagon.Places)
                                {
                                    Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                    Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                    Console.WriteLine($"Класс: {place.Class}");
                                    Console.WriteLine($"Цена: {place.Price}");
                                    Console.WriteLine("*******************");
                                }
                                Console.WriteLine("||||||||||||||||||||||||||||||||");
                            }
                        }
                    }
                }

                int inputSearch4 = 0;
                int countSearch41 = 0;

                for (int i = 3; i < routeList.Count; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == begin)
                            {
                                ++inputSearch4;
                                break;
                            }
                            ++countSearch41;
                        }
                    }
                }

                int outputSearch4 = 0;
                int countSearch42 = 0;

                for (int i = 3; i < routeList.Count; i++)
                {
                    foreach (var route in routeList[i].Routes)
                    {
                        foreach (var city in route.City)
                        {
                            if (city.Name == end)
                            {
                                ++outputSearch4;
                                break;
                            }
                            ++countSearch42;
                        }
                    }
                }

                if (inputSearch4 > 0 && outputSearch4 > 0 && countSearch41 < countSearch42)
                {
                    for (int i = 3; i < routeList.Count; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");
                                foreach (var place in vagon.Places)
                                {
                                    Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                    Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                    Console.WriteLine($"Класс: {place.Class}");
                                    Console.WriteLine($"Цена: {place.Price}");
                                    Console.WriteLine("*******************");
                                }
                                Console.WriteLine("||||||||||||||||||||||||||||||||");
                            }
                        }
                    }
                }

                
                Console.Write("Введите номер вагона: ");
                int wagonNumber = 0;

                while (wagonNumber == 0)
                {
                    int.TryParse(Console.ReadLine(), out wagonNumber);
                    if (wagonNumber <= 0 || wagonNumber > 4) wagonNumber = 0;
                }


                Console.Write("Введите номер места: ");
                int placeNumber = 0;

                while (placeNumber == 0)
                {
                    int.TryParse(Console.ReadLine(), out placeNumber);
                    if (placeNumber <= 0 || placeNumber > 10) placeNumber = 0;
                }


                Console.Clear();
                Console.WriteLine("Информация по приобретенному билету:");
                if (inputSearch1 > 0 && outputSearch1 > 0 && countSearch11 < countSearch12)
                {
                    for (int i = 0; i < routeList.Count - 3; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                if (vagon.WagonNumber == wagonNumber)
                                {
                                    Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");

                                    foreach (var place in vagon.Places)
                                    {
                                        if (place.PlaceNumber == placeNumber)
                                        {
                                            Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                            Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                            Console.WriteLine($"Класс: {place.Class}");
                                            Console.WriteLine($"Цена: {place.Price}");
                                            Console.WriteLine("*******************");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("||||||||||||||||||||||||||||||||");
                                    break;
                                }
                            }
                        }
                    }

                }

                if (inputSearch2 > 0 && outputSearch2 > 0 && countSearch21 < countSearch22)
                {
                    for (int i = 1; i < routeList.Count - 2; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                if (vagon.WagonNumber == wagonNumber)
                                {
                                    Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");

                                    foreach (var place in vagon.Places)
                                    {
                                        if (place.PlaceNumber == placeNumber)
                                        {
                                            Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                            Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                            Console.WriteLine($"Класс: {place.Class}");
                                            Console.WriteLine($"Цена: {place.Price}");
                                            Console.WriteLine("*******************");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("||||||||||||||||||||||||||||||||");
                                    break;
                                }
                            }
                        }
                    }
                }

                if (inputSearch3 > 0 && outputSearch3 > 0 && countSearch31 < countSearch32)
                {
                    for (int i = 2; i < routeList.Count - 1; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                if (vagon.WagonNumber == wagonNumber)
                                {
                                    Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");

                                    foreach (var place in vagon.Places)
                                    {
                                        if (place.PlaceNumber == placeNumber)
                                        {
                                            Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                            Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                            Console.WriteLine($"Класс: {place.Class}");
                                            Console.WriteLine($"Цена: {place.Price}");
                                            Console.WriteLine("*******************");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("||||||||||||||||||||||||||||||||");
                                    break;
                                }
                            }
                        }
                    }
                }

                if (inputSearch4 > 0 && outputSearch4 > 0 && countSearch41 < countSearch42)
                {
                    for (int i = 3; i < routeList.Count; i++)
                    {
                        foreach (var route in routeList[i].Routes)
                        {
                            Console.WriteLine($"№ поезда: {route.Train.TrainNumber}");
                            Console.WriteLine($"Маршрут: {routeList[i].Name}");

                            foreach (var vagon in route.Train.Wagons)
                            {
                                if (vagon.WagonNumber == wagonNumber)
                                {
                                    Console.WriteLine($"Номер вагона: {vagon.WagonNumber}");

                                    foreach (var place in vagon.Places)
                                    {
                                        if (place.PlaceNumber == placeNumber)
                                        {
                                            Console.WriteLine($"Meсто: {place.PlaceNumber}");
                                            Console.WriteLine($"Расположение: {place.PlacesLocations}");
                                            Console.WriteLine($"Класс: {place.Class}");
                                            Console.WriteLine($"Цена: {place.Price}");
                                            Console.WriteLine("*******************");
                                            break;
                                        }
                                    }
                                    Console.WriteLine("||||||||||||||||||||||||||||||||");
                                    break;
                                }
                            }
                        }
                    }
                }


            }
        }
    }
}
