using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class Sort
    {
        protected double[] _source;

        protected RememberTime _timeStart;
        protected RememberTime _timeEnd;
        protected PositionValue _check;
        protected PositionValue _swap;

        public Sort(double[] array)
        {
            _source = array;
        }

        public void StartSort(RememberTime timeStart)
        {
            _timeStart = timeStart;
        }

        public void StopSort(RememberTime timeStop)
        {
            _timeEnd = timeStop;
        }

        public void CheckSort(PositionValue check)
        {
            _check = check;
        }

        public void SwapSort(PositionValue swap)
        {
            _swap = swap;
        }

        public virtual void SortData()
        {

        }

    }
}
