using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_2_1
{
    internal class Person : Random
    {
        public Person() { }
        public Person(string p_name)
        {
            Name = p_name;
        }
        public Person(Person prevPerson)
        {
            Name = prevPerson.Name;
        }

        public string Name;

        public void PrintName()
        {
            Console.WriteLine($"Имя: {Name}");
        }
        public void SetName(string p_name)
        {
            Name = p_name;
        }
        public string Merge() //Соединяет 1 символ поля и последний символ поля
        {
            return Name.Substring(0, 1) + Name.Substring(Name.Length - 1);
        }
        public string ToString()
        {
            return Name;
        }
    }
}
