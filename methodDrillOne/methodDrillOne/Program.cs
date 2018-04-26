using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodDrillOne
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Good afternoon! Please enter a numeric value!");
            int userValue = Convert.ToInt32(Console.ReadLine());

            Table table = new Table();
            int result = table.Add(userValue);
            Console.WriteLine("Your number plus 150 is " + result);

            int difference = table.Subtract(userValue);
            Console.WriteLine("Your number subtracted from 1000 is " + difference);

            int product = table.Multiply(userValue);
            Console.WriteLine("Your number multiplied by 6 is " + product);

            Console.ReadLine();
        }
        
    }
}
