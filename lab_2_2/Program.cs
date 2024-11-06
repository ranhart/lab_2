namespace lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество часов и минут: ");
            string h = Console.ReadLine();
            string m = Console.ReadLine();
            if (byte.TryParse(h, out byte hours))
            {
                if (uint.TryParse(m, out uint minutes))
                {
                    Time time = new Time(hours, minutes);
                    time.Print();
                    Console.WriteLine("Введите сколько минут добавить: ");
                    string m2 = Console.ReadLine();
                    if (uint.TryParse(m2, out uint minutes2))
                    {
                        time = time.Add(minutes2);
                        Console.WriteLine("Тест метода Add: ");
                        time.Print();
                        Console.WriteLine("Тест унарных операторов: ");
                        time = time++;
                        time.Print();
                        time = time--;
                        time.Print();
                        Console.WriteLine("Тест явных и неявных пробразований: ");
                        Console.WriteLine((byte)time);
                        bool isZero = time;
                        Console.WriteLine(isZero);
                        Console.WriteLine("Введите сколько минут добавить: ");
                        string m3 = Console.ReadLine();
                        if (uint.TryParse(m3, out uint minutes3))
                        {
                            time = time + minutes3;
                            Console.WriteLine("Тест бинарного оператора +: ");
                            time.Print();
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода");
                            return;
                        }
                        Console.WriteLine("Введите сколько минут вычесть: ");
                        string m4 = Console.ReadLine();
                        if (uint.TryParse(m4, out uint minutes4))
                        {
                            time = time - minutes4;
                            Console.WriteLine("Тест бинарного оператора -: ");
                            time.Print();
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                        return;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }
        }
    }
}
