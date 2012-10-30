using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Events;
using Project2B.Misc;
using Project2B.Monster;

//this class was created to Wrap the location - adds functions like observers and observable. Contains items, fixtures
//events, counts etc.
namespace Project2B
{
    public class LocationLevelTwoWrap : LocationObserverandObservable,IEquatable<LocationObserverandObservable>
    {
       private ILocationDecorator _location;
       private List<IItem> _items;
       private StringBuilder _description;
       private List<IFixture> _fixture;
       private bool _isDark;
       private IDictionary<Directions, ILocations> _neighbors;
        private readonly object _lockentrance;
        private readonly object _lockexit;
        private bool _hasMonster;
       
	   /// <summary>
	   /// Constructor
	   /// </summary>
	   public LocationLevelTwoWrap(ILocationDecorator location)
       {
           _location = location;
           _description = new StringBuilder();
           _items = new List<IItem>();
	       _lockentrance = new object();
           _fixture = new List<IFixture>();
          _lockexit= new object();

       
       }
       public override string ToString()
       {
           return Name;
       }
        public override bool HasMonster
        {
            get { return _hasMonster; }
        }

        /// <summary>
		/// Sets value and returns if the location is dark
		/// </summary>
        public override bool IsDark
        {
            get { return _isDark; }
            set { _isDark = value; }
        }
		
		 /// <summary>
	   /// Returns fixture
	   /// </summary>
        public override List<IFixture> Fixture
       {
           get { return _fixture; }
       }
		 /// <summary>
	   /// Allows adding fixture
	   /// </summary>
        public override void AddFixture(IFixture item)
        {
            if(_fixture.Contains(item) == false)
            {
                _fixture.Add(item);
            }
        }

        public override IList<IActor> Players
        { 
          get
          {
              lock (_lockentrance)
              {
                  return _location.Players;
              }
              
          }
        }   

        /// <summary>
	   /// Update requests
	   /// </summary>
        public override UpdateRequest Request
        {
            get {
                
                
                    return _location.Request;
               
                 }
        }

		 /// <summary>
	   /// Returns Enumerator
	   /// </summary>
       public override IEnumerator GetEnumerator()
       {
           return _location.GetEnumerator();
       }
		
		 /// <summary>
	   /// Returns PlayerMarker
	   /// </summary>
       public override object GetPlayerMarker(IActor player)
        {
            return _location.GetPlayerMarker(player);
        }
		
		 /// <summary>
	   /// Returns if the location is dead end
	   /// </summary>
        public override bool DeadEndCheck(ILocations location)
        {
            return _location.DeadEndCheck(location);
        }
		 /// <summary>
	   /// returns neighbors
	   /// </summary>
        public override IDictionary<Directions, ILocations> GetNeighbors
        {
            get{
                lock (_lockentrance)
                {
                    _neighbors = _location.GetNeighbors;
                    return _neighbors;
                }
                
            }
        }

        
      
		 /// <summary>
	   /// Allows adding neighbors
	   /// </summary>
       public override void AddNeighbor(ILocations to, Directions direction)
       {
            _location.AddNeighbor(to,direction);
       }
		
		 /// <summary>
	   /// Allows removing Neighbor
	   /// </summary>
       public override void RemoveNeighbor(Directions direction)
       {
            _location.RemoveNeighbor(direction);
       }
		
		 /// <summary>
	   /// Allows entering a location
	   /// </summary>
       public override void EnterLocation(IActor player)
       {
           lock (_lockentrance)
           {
               if (player is AbstractMonster)
               {
                   if(Players.Count > 0)
                   {
                       Update(new MonsterEncounterEvent(this, player));
                   }
                  /* 

                   while ((player as AbstractMonster).ActorLocationNew == this)
                   {
                       _hasMonster = true;
                   }
               */
               }
               else
               {


                   player.ActorLocation = this;
                   player.ActorLocationNew = this;
                   Update(new MoveEventEnter(this, player));

                   if (this.GetNeighbors.Count == 0)
                   {
                       Update(new DeadEndDeath(player));
                   }
                   else if (_fixture.Contains(new Trap()))
                   {
                       var j = _fixture[_fixture.IndexOf(new Trap())];
                       if ((j as ISwitch).Switch)
                       {
                           if (player is Actor)
                           {
                               if ((player as Actor).HasKey)
                               {
                                   (j as ISwitch).Switch = false;
                                   Update(new SurvivedTrap(this, player));
                               }

                           }
                           else
                           {
                               Update(new DeathEvent(player));
                           }
                       }


                   }
                   _location.EnterLocation(player);
               }
           }

       }
		 /// <summary>
	   /// Allows leaving a location
	   /// </summary>
        public override void ExitLocation(IActor player)
       {
           lock (_lockentrance)
           {
               if (player is AbstractMonster)
               {
                   _hasMonster = false;
                   _location.ExitLocation(player);
               }
               else
               {
                   if (HasDrawBridge)
                   {
                       var j = FindFixture(new DrawBridge());
                       if (IsOn(j))
                       {
                           Update(new DeathEvent(player));
                       }
                       else
                       {
                           _location.ExitLocation(player);
                           Update(new MoveEventExit(this, player));

                       }
                   }
                   else
                   {
                       _location.ExitLocation(player);
                       Update(new MoveEventExit(this, player));
                   }

               }
           }
       }
		 /// <summary>
	   /// override String name
	   /// </summary>
       public override string Name
       {
           get { return _location.Name; }
       }
		 /// <summary>
	   /// returns count
	   /// </summary>
       public override int Count
       {
           get { return _location.Count; }
       }
		 /// <summary>
	   /// returns if the locaiton is Exit
	   /// </summary>
       public override bool IsIExit()
       {
           return _location is IExit;
       }
       /// <summary>
	   /// Allows adding items
	   /// </summary>
       public override void AddItem(IItem item)
       {
           if(item != null)
           {
               _items.Add(item);

           }
       }
	 /// <summary>
	   /// Returns list of items
	   /// </summary>
       public override List<IItem> Items
       {
           get { return _items; }
       }
		 /// <summary>
	   /// Update methods for observers
	   /// </summary>
       public override void OnNext(object request)
       {
            if(request is IDropEvent)
            {
                _items.Add((request as IDropEvent).Item);
            }

           
            else if (request is IPickUpEvent)
            {


                    RemoveItem((request as IPickUpEvent).Item);

            
            }
           
       }
		 /// <summary>
	   /// Allows removing item
	   /// </summary>
        private void RemoveItem(IItem item)
        {

            if (item != null)
            {

                IItem go = null;
                var t = _items.GetEnumerator();
                while (t.MoveNext())
                {
                    if (t.Current != null)
                    {
                        if (t.Current.ToString().Equals(item.ToString()))
                        {
                            go = t.Current;
                        }
                    }
                }

                if (go != null)
                {
                    _items.Remove(go);
                }

           }
        }
        /// <summary>
	   /// Returns description
	   /// </summary>
        public override string Description
       {
           get { return _description.ToString(); }    
           set
           {
               _description.Append(value);
               _description.AppendLine();
           }

       }
	    /// <summary>
	   /// Allows clearing description
	   /// </summary>
       public override void ClearDescription()
       {
           _description.Clear();
       }
                                    
        /// <summary>
	   /// On Error, prints error message
	   /// </summary>
       public override void OnError(Exception error)
       {
           Console.WriteLine(error.Message);
       }
		 /// <summary>
	   /// Unsubscribes when completed
	   /// </summary>
       public override void OnCompleted()
       {
           Unsubscribe();
       }
	 /// <summary>
	   /// Utility unsubscribe method
	   /// </summary>
       public void Unsubscribe()
       {
           foreach (var disposable in _unsubscriber)
           {
               disposable.Dispose();
           }

       }
	   
	    /// <summary>
	   /// Subscribe method
	   /// </summary>
       public void Subscribe(IObservable<object> provider)
       {
           if (provider != null)
               _unsubscriber.Add(provider.Subscribe(this));

       }
	   
	    /// <summary>
	   /// Returns of the location has lightsource
	   /// </summary>
        public override bool HasLightSource
        {
             get { return _fixture.Contains(new LightSource()); } 
        }
		/// <summary>
	   /// returns hasDrawBridge
	   /// </summary>
        public override bool HasDrawBridge
        {
            get { return _fixture.Contains(new DrawBridge()); }
        }
		
		 /// <summary>
	   /// Returns hasTrap
	   /// </summary>
        public override bool HasTrap
        {
            get { return _fixture.Contains(new Trap()); }
        }

         /// <summary>
	   /// Finding Fixture
	   /// </summary>
        private IFixture FindFixture( IFixture fixture)
        {   var j = _fixture[_fixture.IndexOf(fixture)];
            return j;
        }
		 /// <summary>
	   /// Turn on a feature
	   /// </summary>
        public override bool IsOn(IFixture fixture)
        {
              if (HasLightSource || HasDrawBridge || HasTrap)
              {
                    return ReturnSwitch(fixture);
              }
              else
              {
                  return false;
              }    
        }
		 /// <summary>
	   /// Sets Switch
	   /// </summary>
        private void SetSwitch(bool val, IFixture fixt)
        {
            var j = FindFixture(fixt);
            (j as ISwitch).Switch = val;
        }
		
		 /// <summary>
	   /// Return switch
	   /// </summary>
        private bool ReturnSwitch(IFixture val)
        {
            var j = FindFixture(val);
            return (j as ISwitch).Switch;
        }
		 /// <summary>
	   /// Allows turning in a fixture
	   /// </summary>
        public override void TurnOnFixture(IFixture val)
        {
            if (val is ISwitch)
            {
                if ( HasLightSource || HasDrawBridge || HasTrap)
                {
                    SetSwitch(true,val);
                }
            }

        }
		
		 /// <summary>
	   /// Allows turning off a fixture
	   /// </summary>
        public override void TurnOffFixture(IFixture val )
        {
            if (val is ISwitch )
            {
                if (HasLightSource || HasDrawBridge || HasTrap)
                {
                    SetSwitch(false, val);
                }
            }
        }

		 /// <summary>
	   /// Equals method
	   /// </summary>
        public bool Equals(LocationObserverandObservable other)
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
    }
}
