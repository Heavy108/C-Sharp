using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte userAge=20;
            int numberOfEmployees =510;
            Console.WriteLine(userAge*numberOfEmployees);
            Console.WriteLine(userAge/numberOfEmployees);
            Console.WriteLine("Hello, " + "how are you?" + " I love JavaScript" );

            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.GetType());
            Console.WriteLine((Convert.ToInt32(userInput)).GetType());
            // Console.WriteLine(userInput.GetType());

        }
    }

}
