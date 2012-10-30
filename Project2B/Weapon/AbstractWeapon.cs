using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Interfaces;

//Abstract Weapon. This implements partially or wholly IItem and IActive interface.
//IItem interface makes sure that not only the IItem interface is implemented,
//but every underlying class is contracted to implement the ICarriable and IEdible interface.
//This abstract class also implements the IActive interface. 
namespace Project2B
{
    public abstract class AbstractWeapon : IItem, IActive, ISwitchOnOff, ISwitchable, IEquatable<AbstractWeapon>,IWeaponDamage
    {
        public abstract bool Carriable { get; }

        public abstract string Name { get; }


        public bool IsEdible
        {
            get { return false; }
        }

        public abstract bool IsOn { get; }
        public abstract void TurnON();
        public abstract void TurnOff();
        public abstract bool IsSwitchAble { get; }
        public abstract bool Equals(AbstractWeapon other);
        public abstract int Weight { get; }
        public abstract int Damage { get; }
    }
}


