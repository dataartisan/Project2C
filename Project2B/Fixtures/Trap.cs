using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//booby trap
namespace Project2B
{
    class Trap : ISwitch, IEquatable<Trap>
    {
        private bool _trapActive;
        private string _name;
		
		
		///<summary>
		/// Constructor
		///</summary>
        public Trap()
        {
            _name = "Trap";
            _trapActive = true;

        }
        /*
        public bool DefeatTrap(IItem item)
        {
            if(item is Key)
            {
                _trapActive = false;
                return true;

            }

            return false;
        }
       */
         
        
		///<summary>
		/// Marks the object as non-carriable
		///</summary>
        public bool Carriable
        {
            get { return false; }
        }
		
		
		///<summary>
		/// switches to true or false
		///</summary>
        public bool Switch
        {
            get { return _trapActive; }
            set { _trapActive = value; }
        }
		/// <summary>
		/// Equals to method
		/// </summary>
        public bool Equals(Trap other)
        {
            if (this._name.Equals(other.Name) && other.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// returns name
		/// </summary>
        public string Name
        {
            get { return _name; }


        }
		/// <summary>
		/// Overrides toString method
		/// </summary>
        public override string ToString()
        {
            return _name;
        }
    
    
    
    }
}
