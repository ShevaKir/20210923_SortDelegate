using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class SortSelect : Sort
    {
        public SortSelect(double[] array)
            :base(array)
        {

        }

        public override double[] SortData(Compare cmp)
        {
            if (_timeStart != null)
            {
                _timeStart(this, new RememberTimeEventArgs(DateTime.Now.Ticks));
            }
            
            for (int i = 0; i < _source.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < _source.Length; j++)
                {
                    //if (Check(min, j))
                    if(cmp(_source[min], _source[j]))
                    {
                        min = j;
                    }
                }

                Swap(i, min);
            }

            if (_timeEnd != null)
            {
                _timeEnd(this, new RememberTimeEventArgs(DateTime.Now.Ticks));
            }

            return _source;
        }



        private bool Check(int i, int j)
        {
            if(_check != null)
            {
                _check(this, new PositionValueEventArgs(i, j));
            }

            System.Threading.Thread.Sleep(50);

            return _source[j] < _source[i];
        }

    }
}
