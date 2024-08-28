using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the item price:"); //asks for users input
            double price = Convert.ToDouble(Console.ReadLine()); //converts users input into price variable
            Console.Write("Please enter the promotional discount:"); //asks for users input
            double discount = Convert.ToDouble(Console.ReadLine()); //converts users input into discount variable
            Console.Write("Please enter the sales tax:"); //asks for users input
            double salesTax = Convert.ToDouble(Console.ReadLine()); //converts users input into salesTax variable

            double totalCost = price - (price * discount) + (price * salesTax); //calculates the total cost of the item
            Console.WriteLine("The total cost comes out to: " +  totalCost); //displays total cost of the item

            Console.ReadKey(); //allows user to read program
        }
    }
}
