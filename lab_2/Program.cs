namespace lab_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест конструктора 1:");
            Person person = new Person(); //Конструктор 1
            person.PrintName();
            Console.WriteLine("Тест конструктора 2:");
            Console.WriteLine("Введите имя: ");
            string x = Console.ReadLine();
            Person person1 = new Person(x); //Конструктор 2
            person1.PrintName();
            Console.WriteLine("Тест конструктора копирования:");
            Person person2 = new Person(person); //Конструктор копирования
            person2.PrintName();
            Console.WriteLine("Тест метода SetName:");
            Console.WriteLine("Введите имя: ");
            x = Console.ReadLine();
            Person person3 = new Person();
            person3.SetName(x);
            person3.PrintName();
            Console.WriteLine("Тест метода Merge:");
            string str = person3.Merge(); 
            Console.WriteLine(str);
            Console.WriteLine("Тест перегрузки ToString():");
            Console.WriteLine(person.ToString());
            Console.WriteLine("Тест конструктора дочернего класса:");
            Musician musician = new Musician("Саша", "гитара"); //Конструктор дочернего класса
            Console.WriteLine("Тест методов дочернего класса:");
            musician.PrintName();
            musician.PrintSkill();
            musician.PlayNotes(6);
            Musician musician1 = new Musician(person1.ToString()); //Конструктор дочернего класса
            musician1.PrintName();
            musician1.SetSkill("Пианино");
            musician1.PrintSkill();
        }
    }
}
