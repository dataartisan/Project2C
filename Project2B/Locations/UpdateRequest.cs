namespace Project2B
{
    public class UpdateRequest
    {
        private readonly IActor _player;
        private readonly ILocations _location;
        private readonly Flag _flag;

		
		///<summary>
		/// Constructor
		///</summary>
        public UpdateRequest(IActor player, ILocations location, Flag flag)
        {
            _player = player;
            _location = location;
            _flag = flag;
        }
		
		///<summary>
		/// Returns Flag
		///</summary>
        public Flag Flag
        {
            get { return _flag; }
        }

		
		///<summary>
		/// Returns location
		///</summary>
        public ILocations Location
        {
            get { return _location; }
        }

		
		///<summary>
		/// Returns Player
		///</summary>
        public IActor Player
        {
            get { return _player; }
        }
    }
}
