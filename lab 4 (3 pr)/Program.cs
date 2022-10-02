using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm_03
{
    class Chiken
    {
        private string name;
        private int age;


        public Chiken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => name;
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new System.ArgumentException("Age can be between 0 and 15");
                }
                this.age = value;
            }
        }



        private int CalculateProductPerDay(int chiken_age)
        {
            if (chiken_age < 1)
            {
                Console.WriteLine("Chiken doesn`t produce any ages ");
                return 0;
            }
            else
            {
                if (chiken_age > 1 && chiken_age < 10)
                {
                    return 3;
                }
                else
                    return 1;
            }
        }

        public int ProductPerDay
        {
            get
            {
                return CalculateProductPerDay(age);
            }
        }

        class Start
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the chiken name and age:");

                var arg = Console.ReadLine().Split();
                Chiken chiken = new Chiken(arg[0], int.Parse(arg[1]));
                Console.WriteLine($"Chiken {chiken.Name} age of {chiken.Age} can produce {chiken.ProductPerDay} per day");
                Console.WriteLine();
            }
        }
    }
}
