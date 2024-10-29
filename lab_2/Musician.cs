using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_1
{
    internal class Musician : Person 
    {
        public Musician() { }
        public Musician(string p_name)
        {
            Name = p_name;
        }
        public Musician(string p_name, string p_skill)
        {
            Name = p_name;
            Skill = p_skill;
        }

        public string Skill;

        public void SetSkill(string p_skill)
        {
            Skill = p_skill;
        }

        public void PrintSkill()
        {
            Console.WriteLine($"{Name} играет на инструменте: {Skill}");
        }

        public void PlayNotes(int num)
        {
            Random random = new Random();
            string[] Notes = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            Console.Write($"{Name} сыграл(а) {num} нот на инструменте {Skill}: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(Notes[random.Next(0, 12)] + " ");
            }
        }
    }
}
