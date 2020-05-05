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
            catch (Exception ex)
            {
                throw ex;
            }
            return numbers;
        }

        public int LargestFiveNumber(int[] list)
        {
            string numbers = "";
            int[] sorted = { };
            string subString = string.Empty;
            int conVertFiveDigNUmber = 0;
            try
            {
                sorted = list.OrderByDescending(x => x).ToArray();
                foreach (var item in sorted)
                {
                    if (!numbers.Contains(item.ToString()))
                        numbers += item.ToString();
                }

                subString = numbers.Substring(0, 5);
                conVertFiveDigNUmber = Convert.ToInt32(subString);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conVertFiveDigNUmber;
        }
    }
}
