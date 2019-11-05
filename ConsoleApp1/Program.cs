using System;
using System.Collections.Generic;

namespace ConsoleApp1
{


    class Mashin
    {
        public string Name;
        public int Age;

        public Mashin(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}; Age:{Age}");
        }

    }
    
    class Program
    { 



    static void Main(string[] args)
        {
            Console.WriteLine("input digits: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string Snum = Convert.ToString(num);
            var numbers = new List<int>();
            char[] arrchar = Snum.ToCharArray();
            int[] arrint = new int[arrchar.Length];
            for (int i = 0; i < arrchar.Length; i++)
            {

                arrint[i] = (int)Char.GetNumericValue(arrchar[i]);
                numbers.Add(arrint[i]);
            }
            numbers.Sort();
            numbers.Reverse();
            string Something = string.Join("", numbers);
            int Final = Convert.ToInt32(Something);
            Console.WriteLine(Final);
        }
    }
}
