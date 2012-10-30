using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public class Key : AbstractTool
   {
       private string _name = "Gold Key";
       

       public override string Name
       {
           get { return _name; }
       }

       public override bool IsSwitchAble
       {
           get { return false; }
       }

       public override bool IsOn
       {
           get { throw new NotImplementedException(); }
       }

       public override void TurnON()
       {
           throw new NotImplementedException();
       }

       public override void TurnOff()
       {
           throw new NotImplementedException();
       }

       public override bool Carriable
       {
           get { return true; }
       }

        public override bool Equals(AbstractTool other)
        {
            if(this._name.Equals(other.Name) && other.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public override int Weight
        {
            get { return 1; }
        }

        public override string ToString()
        {
            return _name;
        }
    
    
    }
}
