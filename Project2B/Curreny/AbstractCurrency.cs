using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Abstract currency. Implements IItem interface.
//IItem interface makes sure that not only the IItem interface is implemented,
//but every underlying class is contracted to implement the ICarriable and IEdible interface.

namespace Project2B
{
    public abstract class AbstractCurrency : IItem, IEquatable<AbstractCurrency>
    {
        public abstract bool Carriable { get; }

        public abstract string Name { get; }
		
		/// <summary>
		/// Does not need to be implemented
		/// </summary>
        public bool IsEdible
        {
            get { throw new NotImplementedException(); }
        }

        
        public abstract bool Equals(AbstractCurrency other);
        public abstract int Weight { get; }
    }
}
