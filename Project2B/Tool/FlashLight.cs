//class flashlight
namespace Project2B
{
    class FlashLight : AbstractTool
    {
        private bool _active;
        private readonly string _name;

		/// <summary>
		/// Constructor
		/// </summary>
        public FlashLight()
        {
            _name = "Flash Light";
        }
		/// <summary>
		/// Allows turning on
		/// </summary>
        public override void TurnON()
        {
            _active = true;

        }
		
		/// <summary>
		/// Allows turning off
		/// </summary>
        public override void TurnOff()
        {
            _active = false;

        }

        public override bool Equals(AbstractTool other)
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
            get {return 1; }
        }

        /// <summary>
		/// returns carriable object as true
		/// </summary>
        public override bool Carriable
        {
            get { return true; }
        }
		
		/// <summary>
		/// returns name
		/// </summary>
        public override string Name
        {
            get { return _name; }
        }

		/// <summary>
		/// returns as switchable object
		/// </summary>
        public override bool IsSwitchAble
        {
            get { return true; }
        }

		/// <summary>
		/// returns whether or not a particular object is active
		/// </summary>
		
        public override bool IsOn
        {
            get { return _active; }
        }
        public override string ToString()
        {
            return _name;
        }
    
    }
}