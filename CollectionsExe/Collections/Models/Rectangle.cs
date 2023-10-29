using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExe.Collections.Models
{
    class Rectangle
    {
        private int width, length;

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if(value>=0)
                width = value;
            }
        }

        public int Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                 length = value;
            }
        }

        
        public Rectangle() { }
        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;

        }

        public override string ToString()
        {
            return $"Rectangle width {width}, length {length}";
        }
    }

}

