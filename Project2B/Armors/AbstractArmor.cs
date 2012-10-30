using System;

namespace Project2B.Armors
{
    public abstract class AbstractArmor : IItem, IEquatable<AbstractArmor>
    {
        public abstract bool Carriable { get; }
        public abstract bool IsEdible { get; }
        public abstract int Weight { get; }
        public abstract string Name { get; }
        public abstract bool Equals(AbstractArmor other);
        public abstract int Protection { get; }
    }
}
