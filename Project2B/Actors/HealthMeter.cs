using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//class to keep track of health of the player
namespace Project2B
{
    public class HealthMeter
    {
        private int _health;

		/// <summary>
		/// Constructor
		/// </summary>
        public HealthMeter(int health)
        {
            _health = health;
        }

        
		/// <summary>
		/// returns health and sets the configured health 
		/// value of the actor/player
		/// </summary>
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
    
    }
}
