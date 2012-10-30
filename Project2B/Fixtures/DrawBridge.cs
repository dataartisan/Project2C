using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    class DrawBridge:ISwitch
    {
        private bool _isOn;
        
		/// <summary>
		/// returns that this is not a carriable object
		/// </summary>
        public bool Carriable
        {
            get { return false; }
        }
		/// <summary>
		/// allows switching on and off
		/// </summary>
        public bool Switch
        {
            get { return _isOn; }
            set { _isOn = value; }
        }
    }
}
