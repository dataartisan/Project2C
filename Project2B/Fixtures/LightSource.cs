using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B.Misc
{
    class LightSource:ISwitch
    {
        private bool _isOn;
        
        public bool Carriable
        {
            get { return false; }
        }

        public bool Switch
        {
            get { return _isOn; }
            set { _isOn = value; }
        }
    }
}
