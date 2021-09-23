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
            double[] array = new double[10];

            RandomArray.RandomRun(array);

            UI.ShowArray(array);

            SortSelect sortArray = new SortSelect(array);
            //sortArray.StartSort(new RememberTime(TimeSort));
            //sortArray.StopSort(new RememberTime(TimeSort));
            //sortArray.CheckSort(new PositionValue(PositionCheckSort));
            //sortArray.SwapSort(new PositionValue(PositionSwapSort));
            sortArray.StartSort(UI.TimeSort);
            sortArray.StopSort(UI.TimeSort);
            sortArray.SwapSort(UI.PositionSwapSort);
            sortArray.CheckSort(UI.PositionCheckSort);
            sortArray.SortData();

            UI.ShowArray(array);

            Console.ReadKey();
 

        }

        
    }
}
