using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class UI
    {
        public static void ShowArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }
            Console.WriteLine();
        }

        public static void TimeSort(object sender, RememberTimeEventArgs eventArgs)
        {
            Console.WriteLine("Time: {0}", eventArgs.Tick);
        }

        public static void PositionCheckSort(object sender, PositionValueEventArgs eventArgs)
        {
            Console.WriteLine("Element Check first: {0}, Element Check second: {1}", 
                    eventArgs.Position1, eventArgs.Position2);
        }
        public static void PositionSwapSort(object sender, PositionValueEventArgs eventArgs)
        {
            Console.WriteLine("Element Swap first: {0}, Element Swap second: {1}", 
                    eventArgs.Position1, eventArgs.Position2);
        }
    }
}
