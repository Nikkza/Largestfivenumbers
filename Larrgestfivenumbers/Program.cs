using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largestfivenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Logichandler logic = new Logichandler();
                string number = Console.ReadLine();
                var listOfNumbers = logic.GetNumbersOneByOne(number);
                var fiveDigitsNumber = logic.LargestFiveNumber(listOfNumbers);
                Console.WriteLine($"Higest five digist number : {string.Join("", fiveDigitsNumber)}");
            }
        }
    }
}
