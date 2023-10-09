using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Moloko";
            int age;

            Console.WriteLine("There is a man called " + name + " Guess how old He is: ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You guessed that he is " + age + " years old");
            Console.ReadLine();
        }
    }
}
