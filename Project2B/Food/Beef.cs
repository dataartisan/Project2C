//Beef class extends the AbstractFood class.
namespace Project2B
{
    class Beef : AbstractFood
    {
        private string _name = "Beef Jerky";
        private int _energy = 5;

		/// <summary>
		/// Returns whether the Beef is carriable object
		/// </summary>
        public override bool Carriable
        {
            get { return true; }
        }
		/// <summary>
		/// returns the name of the object
		/// </summary>
        public override string Name
        {
            get { return _name; }
        }
		/// <summary>
		/// retuns whether the beef is edible.
		/// </summary>
		
        public override bool IsEdible
        {
            get { return true; }
        }
		
		/// <summary>
		/// Returns the energy value of the beef.
		/// </summary>
        public override int EnergyValue
		{
		    get { return _energy; }

            set { _energy = value; }
		}

        public override bool Equals(AbstractFood other)
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

        public override string ToString()
        {
            return _name;
        }
    
    }
}