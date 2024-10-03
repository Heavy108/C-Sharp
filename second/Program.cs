using System;


namespace second
{
    class secondProgram
    {
        static void Main(string[] args)
         {
            string userName=" ";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Please enter you fucking name: ");
            userName =Console.ReadLine();
            Console.Write("Please enter you  age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear- userAge);
        }
    }
}