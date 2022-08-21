using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxByGenererics
{
    internal class MaximumUsingParamsWithoutGenerics
    {
        internal static void toPrint(params int[] array)
        {
            int Max = 0;
            foreach (var number in array)
            {
                if (number > Max)
                {
                    Max = number;
                }
            }

            Console.WriteLine("Maximum Valus of Int is :" + Max);
        }
        internal static void toPrint(params float[] array)
        {
            float Max = 0;
            foreach (var number in array)
            {
                if (number > Max)
                {
                    Max = number;
                }
            }

            Console.WriteLine("Maximum Valus of Float is :" + Max);
        }
        internal static void toPrint(params string[] array)
        {
            var maxString = array[0];
            var maxLength = maxString.ToString().Length;

            foreach (dynamic element in array)
            {
                if (element.ToString().Length > maxLength)
                {
                    maxLength = element.ToString().Length;
                    maxString = element;
                }

            }
            Console.WriteLine("String of max length is :" + maxString);
        }
    }
}
