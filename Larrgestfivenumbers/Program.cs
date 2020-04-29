using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larrgestfivenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Logichandler logic = new Logichandler();
            string number = Console.ReadLine();
            var listOfNumbers = logic.GetNumbersOneByOne(number);
            var fiveDigitsNumber = logic.LargestFiveNumber(listOfNumbers);
            Console.WriteLine($"Higest five digist number : {string.Join("",fiveDigitsNumber)}");
            Console.ReadLine();
        }
    }
}
