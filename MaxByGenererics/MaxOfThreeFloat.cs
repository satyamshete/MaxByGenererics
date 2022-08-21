using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxByGenererics
{
    internal class MaxOfThreeFloat
    {
        internal static void toPrint(float[] array)
        {
            float max;

            max = array[0] > array[1] ? (array[0] > array[2] ? array[0] : array[2]) : (array[1] > array[2] ? array[1] : array[2]);

            Console.WriteLine("Maximum of {0}, {1}, {2}  Number is: {3}", array[0], array[1], array[2], max);
        }
    }
}
