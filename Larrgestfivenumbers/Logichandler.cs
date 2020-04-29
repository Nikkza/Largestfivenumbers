﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larrgestfivenumbers
{
    public class Logichandler
    {
        public int[] GetNumbersOneByOne(string num)
        {
            List<int> list = new List<int>();
            var parse = num.ToCharArray();
            int[] numbers = Array.ConvertAll(parse, c => (int)Char.GetNumericValue(c));

            return numbers;
        }

        public int[] LargestFiveNumber(int[] list)
        {
            string numbers = "";
            var sorted = list.OrderByDescending(x => x).ToArray();
            foreach (var item in sorted)
            {
                if (!numbers.Contains(item.ToString()))
                    numbers += item.ToString();
            }

            var substring = numbers.Substring(0, 5);
            var convertToInt = Convert.ToInt32(substring);
            int[] test = { convertToInt };

            return test;
        }
    }
}
