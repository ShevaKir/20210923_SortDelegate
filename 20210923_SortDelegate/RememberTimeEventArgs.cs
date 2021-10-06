using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class RememberTimeEventArgs : EventArgs
    {
        private long _tick;

        public RememberTimeEventArgs(long tick)
        {
            _tick = tick;
        }

        public long Tick
        {
            get
            {
                return _tick;
            }
        }

    }
}
