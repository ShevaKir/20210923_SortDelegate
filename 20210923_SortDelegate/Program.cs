using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];

            RandomArray.RandomRun(array);
            UI.ShowArray(array);

            EnterCounter countSwap = new EnterCounter();
            EnterCounter countCheck = new EnterCounter();

            SortInsertion sortArray = new SortInsertion(array);
            sortArray.Start += UI.TimeSort;
            sortArray.Start += countCheck.ResetCount;
            sortArray.Start += countSwap.ResetCount;
            sortArray.Stop += UI.TimeSort;
            sortArray.SwapPosition += UI.PositionSwapSort;
            sortArray.SwapPosition += countSwap.DoIncrement;
            sortArray.CheckPosition += UI.PositionCheckSort;
            sortArray.CheckPosition += countCheck.DoIncrement;

            //передача метода сравнения
            //sortArray.SortData(IsMoreThan);

            //анонимный метод
            /*sortArray.SortData(delegate (double first, double second)
            {
                return first > second;
            });*/

            //лямбда
            double[] arraySort = sortArray.SortData((first, second) => first > second);


            UI.ShowArray(array);
            UI.ShowArray(arraySort);
            Console.WriteLine(countSwap.Count);
            Console.WriteLine(countCheck.Count);


            Console.ReadKey();
 

        }


        public static bool IsMoreThan(double first, double second)
        {
            return first > second;
        }

        public static bool IsLessThan(double first, double second)
        {
            return first < second;
        }

    }
}
