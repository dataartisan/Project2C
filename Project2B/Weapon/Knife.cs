namespace Project2B
{
    class Knife : AbstractWeapon
    {
        private readonly string _name;

        public Knife()
        {
            _name = "Hunting Knife";
        }

        public override bool Carriable
        {
            get { return true; }
        }

        public override string Name
        {
            get { return _name; }
        }

        public override bool IsOn
        {
            get { return false; }
        }

        public override void TurnON()
        {
            throw new System.NotImplementedException();
        }

        public override void TurnOff()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsSwitchAble
        {
            get { return false; }
        }

        public override bool Equals(AbstractWeapon other)
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

        public override int Weight
        {
            get { return 1; }
        }

        public override int Damage
        {
            get { return 5; }
        }

        public override string ToString()
        {
            return _name;
        }
    
    }
}