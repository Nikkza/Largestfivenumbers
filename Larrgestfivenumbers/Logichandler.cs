using System;
using System.Linq;

namespace Largestfivenumbers
{
    public class Logichandler
    {
        public int[] GetNumbersOneByOne(string num)
        {
            int[] numbers = { };
            try
            {
                var parse = num.ToCharArray();
                numbers = Array.ConvertAll(parse, c => (int)Char.GetNumericValue(c));
            }
            catch (Exception)
            {

                throw;
            }
            return numbers;
        }

        public int[] LargestFiveNumber(int[] list)
        {
            string numbers = "";
            int[] sorted = { };
            try
            {
                sorted = list.OrderByDescending(x => x).ToArray();
                foreach (var item in sorted)
                {
                    if (!numbers.Contains(item.ToString()))
                        numbers += item.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

            var substring = numbers.Substring(0, 5);
            var convertToInt = Convert.ToInt32(substring);
            int[] test = { convertToInt };

            return test;
        }
    }
}
