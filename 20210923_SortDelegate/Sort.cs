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
            _source = array;
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



        public abstract void SortData();

    }
}
