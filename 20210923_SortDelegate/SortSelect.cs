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

        public override void SortData()
        {
            System.Threading.Thread.Sleep(1000);
            if (_timeStart != null)
            {
                _timeStart(DateTime.Now);
            }
            
            for (int i = 0; i < _source.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < _source.Length; j++)
                {
                    if (Check(min, j))
                    {
                        min = j;
                    }
                }

                Swap(i, min);
            }

            if (_timeEnd != null)
            {
                _timeEnd(DateTime.Now);
            }
            
        }

        private bool Check(int min, int j)
        {
            if(_check != null)
            {
                _check(min, j);
            }

            System.Threading.Thread.Sleep(200);

            return _source[j] < _source[min];
        }

        private void Swap(int i, int j)
        {
            if(_swap != null)
            {
                _swap(i, j);
            }

            System.Threading.Thread.Sleep(200);

            double temp = _source[j];
            _source[j] = _source[i];
            _source[i] = temp;
        }
    }
}
