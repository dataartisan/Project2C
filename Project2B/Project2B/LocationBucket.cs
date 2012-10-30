using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    class LocationBucket:IEnumerable
    {
        private Dictionary<string, ILocations> _bucket;

        public LocationBucket()
        {
            _bucket = new Dictionary<string, ILocations>();
        }

        public void RemoveMember(ILocations location)
        {
            _bucket.Remove(location.Name);
        }
        public void AddMember(ILocations location)
        {
            _bucket.Add(location.Name,location);
        }
    

        
        public IEnumerator GetEnumerator()
        {
            return _bucket.GetEnumerator();
        }
    }
}
