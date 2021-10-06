using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class EnterCounter
    {
        private int _count;

        public void DoIncrement(object sender, EventArgs e)
        {
            _count++;
        }

        public void ResetCount(object sender, EventArgs e)
        {
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

    }
}
