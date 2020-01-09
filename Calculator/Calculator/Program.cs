using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter a number: ");

                string inputString = Console.ReadLine();
                decimal numValue;
                bool parsed = decimal.TryParse(inputString, out numValue);

                if (!parsed)
                    Console.WriteLine("Int32.TryParse could not parse '{0}' tp an int. \n", inputString);

                Console.ReadKey();
            }


            Console.WriteLine("C# Console Calcualtor App");
            Console.WriteLine("------------------------\n");

            while (true)
            {

                Console.Write("Enter your first number: ");
                decimal x = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter your second number: ");
                decimal y = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("\nEnter 1 for addition");
                Console.WriteLine("\nEnter 2 for subtraction");
                Console.WriteLine("\nEnter 3 for multiplcation");
                Console.WriteLine("\nEnter 4 for division");
                Console.WriteLine("");

                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {

                    case 1:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x + y);
                        break;

                    case 2:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x - y);
                        break;

                    case 3:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x * y);
                        break;

                    case 4:
                        Console.WriteLine("\nAnswer:");
                        Console.WriteLine(x / y);
                        break;

                }
                Console.WriteLine("\nPress any key to restart...\n");
                Console.ReadKey();
            }

        }

    }
}
