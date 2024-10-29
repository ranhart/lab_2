namespace lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(180);
            time.Print();
            time = time.Add(1800);
            time.Print();
            time = time++;
            time.Print();
        }
    }
}
