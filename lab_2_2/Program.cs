namespace lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(10, 600);
            time.Print();
            time = time.Add(0);
            time.Print();
            time = time--;
            time.Print();
            Console.WriteLine((byte)time);
            bool isZero = time;
            Console.WriteLine(isZero);
            time = 100 + time;
            time.Print();
        }
    }
}
