using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public class Flag
    {
        public Flag()
        {
            RedFlag = false;
            GreenFlag = false;
            Left = false;
            Enter = false;
        }

        public bool Enter { get; set; }

        public bool Left { get; set; }

        public bool GreenFlag { get; set; }

        public bool RedFlag { get; set; }
    }
}
