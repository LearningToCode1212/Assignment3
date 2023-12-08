using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Door
    {
        private int Size;
        private int Length;
        private bool Opened;
        private bool Closed;
        public Door(int size, int length, bool open, bool close)
        {
            Size = size;
            Length = length; 
            Opened = open;
            Closed = close;
        }
        public bool open()
        {
            return Opened;
        }
        public bool close()
        {
            return Closed;
        }
    }
}
