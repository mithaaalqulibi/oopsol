using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Rectangle
    {
        private int length;
        private int width;
        


        public Rectangle( int length , int width)
        {
            this.length = length;
            this.width = width;
        }
        public int area1()
        {
            return length*width;

        }
        public int area2( int length, int width)
        {
            return width*length;
        }
    }
}
