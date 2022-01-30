using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArchers
{
    class Program
    {


        static void Main(string[] args)
        {
            string Bow;
            string Distance;
            string Data;
            string claim;
            int number=0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("Добро пожаловать на летние Олимпийские игры в Токио!");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("Команды:\ninfo-информация о соревнованиях" +
                "\nreg-регистрация участников\nshoot-стрельба\nresult-запись результатов и вывод среднего значения" +
                "\nclaim-подача аппеляции\nexit-закончить олимпиаду");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            List<string> Entry = new List<string>();
            List<int> ShootArray = new List<int>();
        Start:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Введите команду:");
            Data = Console.ReadLine();
            switch (Data)
            {
                case "info":
                    Console.ForegroundColor= ConsoleColor.DarkMagenta;
                    Console.WriteLine("Дистанции: 18 метров, 30 метров или 50 метров"+"\nРазмер мишени зависит " +
                        "от соревновательнойдистанции");
                    Console.WriteLine("Типы луков: \nТрадиционный-сила натяжения такого лука около 15-20 кг." +
                        " \nСкорость полёта стрелы достигает 240 км/ч." +
                        " \nДанный лук используется на Олимпийских играх - наименьшая точность при стрельбе\n " +
                        "\nБлочный-в таких луках используется специальный механизм, который обеспечивает стреле более правильный разгон," +
                        " \nа также облегчает процесс натяжения лука." +
                        " \nСила натяжения около 25-30 кг." +
                        " \nСкорость полёта стрелы из такого лука достигает 320 км/ч. - наивысшая точность при стрельбе");
                    goto Start;

                case "reg":
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    Console.WriteLine("Введите количество участников:");
                    number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < number; i++)
                    {
                        
                        Console.Write($"Введите имя {i} участника:\n");
                        Entry.Add(Console.ReadLine());
                    }
                    Console.WriteLine("Участники зарегистрированы!");
                   
                    goto Start;

                case "shoot":
                    for (int a = 0; a < number;a ++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Выберите дистанцию: 18, 30 или 50 метров");
                        Distance = Console.ReadLine();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("1-Традиционный\n2-Блочный\nВыберите лук:");
                        Bow=Console.ReadLine();

                        Random random=new Random();
                        if (Distance=="18" && Bow == "1")
                        {
                            int shoot1 = random.Next(0, 10);
                            int shoot2 = random.Next(0, 10);
                            int shoot3 = random.Next(0, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }

                        if (Distance == "30" && Bow == "1")
                        {
                            int shoot1 = random.Next(0, 10);
                            int shoot2 = random.Next(0, 10);
                            int shoot3 = random.Next(0, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }

                        if (Distance == "50" && Bow == "1")
                        {
                            int shoot1 = random.Next(0, 10);
                            int shoot2 = random.Next(0, 10);
                            int shoot3 = random.Next(0, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }

                        if (Distance == "18" && Bow == "2")
                        {
                            int shoot1 = random.Next(2, 10);
                            int shoot2 = random.Next(2, 10);
                            int shoot3 = random.Next(2, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }

                        if (Distance == "30" && Bow == "2")
                        {
                            int shoot1 = random.Next(3, 10);
                            int shoot2 = random.Next(3, 10);
                            int shoot3 = random.Next(3, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }

                        if (Distance == "50" && Bow == "2")
                        {
                            int shoot1 = random.Next(4, 10);
                            int shoot2 = random.Next(4, 10);
                            int shoot3 = random.Next(4, 10);
                            Console.WriteLine($"Попал в {shoot1} {shoot2} {shoot3}");
                            Console.WriteLine();
                            int shoots = (shoot1 + shoot2 + shoot3) / 3;
                            ShootArray.Add(shoots);
                        }
                    }
                    goto Start;

                case "result":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Среднее значение:");
                    foreach(int shoot in ShootArray)
                    {
                        Console.WriteLine(shoot);
                    }

                    Console.WriteLine("Участники");
                    foreach (string shoot in Entry)
                    {
                        Console.WriteLine(shoot);
                    }
                    goto Start;

                case "claim":
                    Console.Write("Укажите вашу жалобу:");
                    claim = Console.ReadLine();
                    goto Start;
                case "exit":
                default:
                    Console.WriteLine("Ошибка! Укажите другое значение");
                    goto Exit;
            }
        Exit:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Спасибо, что приняли участие в олимпиаде!");
            
            Console.ReadKey();
        }
    }
}
