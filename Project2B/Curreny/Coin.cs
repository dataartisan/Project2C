using System;
//concrete class Coin implements the abstract currency.
namespace Project2B
{
    class Coin : AbstractCurrency
    {
        private readonly string _name;
		
		/// <summary>
		/// Default constructor
		/// </summary>
        public Coin()
        {
           
            _name = "Coin";
        }
		/// <summary>
		/// Returns whether the Coin is carriable object
		/// </summary>
        public override bool Carriable
        {
            get { return true; }
        }
		
		/// <summary>
		/// Returns the coin's name
		/// </summary>
        public override string Name
        {
            get {return _name; }
        }
		/// <summary>
		/// Overrides equals method
		/// </summary>
        public override bool Equals(AbstractCurrency other)
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

        /// <summary>
		/// Overrides toString method
		/// </summary>
        public override string ToString()
        {
            return _name;
        }
    
    }
}