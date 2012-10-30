using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Abstract Tool Class. This implements (partially or wholly IItem interface).
//IItem interface makes sure that not only the IItem interface is implemented,
//but every underlying class is contracted to implement the ICarriable and IEdible interface.
namespace Project2B
{
    public abstract class AbstractTool : IItem, ISwitchOnOff, ISwitchable, IEquatable<AbstractTool>
    {
        public abstract bool Carriable { get; }

        public abstract string Name { get; }

        public bool IsEdible
        {
            get { throw new NotImplementedException(); }
        }

        public abstract bool IsSwitchAble { get; }
        public abstract bool IsOn { get; }


        public abstract void TurnON();
        public abstract void TurnOff();
        public abstract bool Equals(AbstractTool other);
        public abstract int Weight { get; }
    }
}
