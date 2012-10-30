using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Abstract food class. This is abstract class which implements (partially or wholly)
//IItem interface
//IItem interface makes sure that not only the IItem interface is implemented,
//but every underlying class is contracted to implement the ICarriable and IEdible interface.

namespace Project2B
{
    public abstract class AbstractFood : IItem, IEquatable<AbstractFood>
    {
        public abstract bool Carriable { get; }

        public abstract string Name { get; }


        public abstract bool IsEdible { get; }

        public abstract int EnergyValue { get; set; }

        public abstract bool Equals(AbstractFood other);
        public abstract int Weight { get; }
    }
}
