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

        public override void SortData()
        {
            if(_timeStart != null)
            {
                _timeStart(DateTime.Now);                
            }

            for (int i = 1; i < _source.Length; i++)
            {
                double key = _source[i];
                int j = i;

                while (Check(key, j))
                {
                    Swap(ref _source[j - 1], ref _source[j], j - 1, j);
                    j--;
                }

                _source[j] = key;
            }

            if (_timeEnd != null)
            {
                _timeEnd(DateTime.Now);
            }
        }

        private bool Check(double key, int j)
        {
            if(_check != null)
            {
                _check(j, j - 1);
            }
            return (j > 0) && (_source[j - 1] > key);
        }

        private void Swap(ref double elementOne, ref double elementTwo, int i, int j)
        {
            if(_swap != null)
            {
                _swap(i, j);
            }

            double temp = elementOne;
            elementOne = elementTwo;
            elementTwo = temp;
        }
    }
}
