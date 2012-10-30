
namespace Project2B.Armors
{
    public class Armor : AbstractArmor
    {
        private int _weight;
        private WeightConfig _config;

        public Armor()
        {
            _config = new WeightConfig();
            _weight = _config.ConfigWeight;
        }
        
        public override bool Carriable
        {
            get { return true; }
        }

        public override bool IsEdible
        {
            get { return false; }
        }

        public override int Weight
        {
            get { return _weight; }
        }

        public override string Name
        {
            get {return  "Armor"; }
        }

        public override bool Equals(AbstractArmor other)
        {
            if (this.Name.Equals(other.Name) && other.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int Protection
        {
            get { return 4; }
        }

        public override string ToString()
        {
            return Name;
        }
    
    
    }
}