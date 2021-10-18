using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class SortInsertion : Sort
    {
        public SortInsertion(double[] array)
            :base(array)
        {

        }

        public override double[] SortData(Compare cmp)
        {
            if(_timeStart != null)
            {
                _timeStart(this, new RememberTimeEventArgs(DateTime.Now.Ticks));                
            }

            for (int i = 1; i < _source.Length; i++)
            {
                double key = _source[i];
                int j = i;

                while (Check(key, j))
                {
                    Swap(j - 1, j);
                    j--;
                }

                _source[j] = key;
            }

            if (_timeEnd != null)
            {
                _timeEnd(this, new RememberTimeEventArgs(DateTime.Now.Ticks));
            }

            return _source;
        }

        private bool Check(double key, int j)
        {
            if(_check != null)
            {
                _check(this, new PositionValueEventArgs(j, j - 1));
            }

            return (j > 0) && (_source[j - 1] > key);
        }

    }
}
