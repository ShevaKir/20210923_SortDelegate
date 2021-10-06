using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210923_SortDelegate
{
    class PositionValueEventArgs : EventArgs
    {
        private int _position1;
        private int _position2;

        public PositionValueEventArgs(int position1, int position2)
        {
            _position1 = position1;
            _position2 = position2;
        }

        public int Position1
        {
            get
            {
                return _position1;
            }
        }

        public int Position2
        {
            get
            {
                return _position2;
            }
        }

    }
}
