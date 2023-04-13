using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Воробйов";
            string surname = "Александр";
            string temporaryStorage;

            Console.WriteLine($"{name} {surname}");

            temporaryStorage = name;
            name = surname;
            surname = temporaryStorage;

            Console.WriteLine($"{name} {surname}");
            Console.ReadKey();
        }
    }
}
