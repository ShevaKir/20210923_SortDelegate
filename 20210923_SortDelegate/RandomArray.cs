using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class RandomArray
    {
        public static void RandomRun(double[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }
    }
}
