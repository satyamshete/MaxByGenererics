using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxByGenererics
{
    internal class UsingParams
    {
        public static void FindMax<T>(params T[] array)
        {
            if (array[0].GetType() == typeof(string))
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
            else
            {
                var maxNum = array[0];
                foreach (dynamic number in array)
                {
                    if (number > maxNum)
                    {
                        maxNum = number;
                    }
                }
                Console.WriteLine("max number is: " + maxNum);
            }


        }
    }
}
