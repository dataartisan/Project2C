using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public class UpdateRequest
    {
        private readonly IActor _player;
        private readonly ILocations _location;
        private readonly Flag _flag;

        public UpdateRequest(IActor player, ILocations location, Flag flag)
        {
            _player = player;
            _location = location;
            _flag = flag;
        }

        public Flag Flag
        {
            get { return _flag; }
        }

        public ILocations Location
        {
            get { return _location; }
        }

        public IActor Player
        {
            get { return _player; }
        }
    }
}
