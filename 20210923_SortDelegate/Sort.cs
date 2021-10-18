using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    abstract class Sort
    {
        protected double[] _source;

        protected RememberTime _timeStart;
        protected RememberTime _timeEnd;
        protected PositionValue _check;
        protected PositionValue _swap;

        public Sort(double[] array)
        {
            _source = (double[])array.Clone();
        }
        
        public event RememberTime Start
        {
            add
            {
                _timeStart += value;
            }
            remove
            {
                _timeStart -= value;
            }
        }

        public event RememberTime Stop
        {
            add
            {
                _timeEnd += value;
            }
            remove
            {
                _timeEnd -= value;
            }
        }

        public event PositionValue CheckPosition
        {
            add
            {
                _check += value;
            }
            remove
            {
                _check -= value;
            }
        }

        public event PositionValue SwapPosition
        {
            add
            {
                _swap += value;
            }
            remove
            {
                _swap -= value;
            }
        }


        //public void StartSort(RememberTime timeStart)
        //{
        //    _timeStart = timeStart;
        //}

        //public void StopSort(RememberTime timeStop)
        //{
        //    _timeEnd = timeStop;
        //}

        //public void CheckSort(PositionValue check)
        //{
        //    _check = check;
        //}

        //public void SwapSort(PositionValue swap)
        //{
        //    _swap = swap;
        //}



        public abstract double[] SortData(Compare compare);

        protected virtual bool Check(double first, double second)
        {
            return first > second;
        }

        protected virtual void Swap(int indexI, int indexJ)
        {
            if (_swap != null)
            {
                _swap(this, new PositionValueEventArgs(indexI, indexJ));
            }

            double temp = _source[indexJ];
            _source[indexJ] = _source[indexI];
            _source[indexI] = temp;
        }

    }
}
