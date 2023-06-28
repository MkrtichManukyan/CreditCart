using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCart
{
    internal class Validation
    {
        public int Validations(double cartNumber)
        {
            int[] numberList = cartNumber.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int value = 0;
            for (int i = 0; i < numberList.Length; i++)
            {
                if(i == 0)
                {
                    for (int j = 1; j < numberList.Length; j++)
                    {
                        int validits = numberList[j];
                        value += validits;
                        j++;
                    }
                }
                int validit = numberList[i] * 2;
                if (validit > 9)
                {
                    validit = validit - 9;
                }
                value += validit;
                i++;
            }
            return value;
        }
    }
}
