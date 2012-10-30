using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NUnit.Framework;
using Project2B.Armors;
using Project2B.Interfaces;


namespace Project2B
{
    //Player class
    public class Player : Actor
    {

        //properties
        private string _actorName;
        private LocationObserverandObservable _actorLocation;
        private HealthMeter _health;
        private int _carryWeight;
        private IList<IItem> items;
        private int _movePenalty;
        private IList<IItem> _coins;
        private PlayerConfig _config;
        private int _lives;
        private int _startingHealth;
        private LocationObserverandObservable _newLocation;
        private int _currentWeight;
        private AbstractWeapon _weapon;
        
		/// <summary>
		/// Contructor
		/// </summary>       

        public Player(string actorName)
        {
            if (actorName == null) throw new ArgumentNullException("actorName");
            _config = new PlayerConfig();
            _actorName = actorName;
            _health = new HealthMeter(_config.StartingHealth);
            _carryWeight = _config.CarryWeight;
            _movePenalty = _config.MovePenalty;
            _lives = _config.Lives;
            items = new List<IItem>();
            _coins = new List<IItem>();
            _startingHealth = _config.StartingHealth;
        }

        /// <summary>
        /// Overrides the health of the player
        /// </summary>

        public int ArmorProtection
        {
            get { return CalcPro(); }

        }
        public AbstractWeapon CurrentWeapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        private int CalcPro()
        {
            return Items.OfType<Armor>().Sum(item => (item as Armor).Protection);
        }

        public override int StartingHealth
        {
            get { return _startingHealth; }
        }
		
		/// <summary>
		/// Retuns items in the list
		/// </summary>
        public override IList<IItem> Items
        {
            get { return items; }
        }
		
		/// <summary>
		/// Returns the penalty for moving
		/// </summary>
        public int MovePenalty
        {
            get { return _movePenalty; }
        }

		/// <summary>
		/// Returns CarryWeight
		/// </summary>
        public int CarryWeight
        {
            get { return _carryWeight; }
        }
		
		/// <summary>
		/// Overrides ActorLocation
		/// </summary>
        public override LocationObserverandObservable ActorLocation
        {
            get { return _actorLocation; }

            set
            {
                if (value != null)
                {
                    _actorLocation = value;
                }
            }


        }
		
		/// <summary>
		/// Overrides ActorLocationNew which is being introduced as wrapper
		/// </summary>
        public override LocationObserverandObservable ActorLocationNew
        {
            get { return _newLocation; }
            set { _newLocation = value; }
        }

        /// <summary>
		/// Allows dropping green marker
		/// </summary>
        public Color DropGreen()
        {
            return Marker._green;

        }

        /// <summary>
		/// Allows Dropping Red Marker
		/// </summary>
        public Color DropRed()
        {
            return Marker._red;

        }

        /// <summary>
		/// Returns ActorName
		/// </summary>
        public override string ActorName
        {
            get { return _actorName; }
        }

        /// <summary>
		/// Do not need this
		/// </summary>
        public override void ExploreTerrain(ILocations startingLocations)
        {
            throw new NotImplementedException();
        }

		/// <summary>
		/// Overrides toString method
		/// </summary>
        public override string ToString()
        {
            return _actorName.ToString();
        }
		
		/// <summary>
		/// Overrides Drop method
		/// </summary>
        public override bool Drop(IItem item)
        {
            if (items.Contains(item))
            {
                
                items.Remove(item);
                Update(new DropEvent(_actorLocation,item,this));
                _currentWeight -= item.Weight;
                return true;
                
            }
            else
            {
                return false;
            }
        
        }
		/// <summary>
		/// Overrides Pickup method
		/// </summary>
        public override bool PickUp(IItem item)
        {
            if (item is Coin)
            {
                _coins.Add(item);
                Update(new PickUpEvent(_actorLocation,item,this));
                return true;
            }
            if (WeightLimitReached == false)
            {
                if (_currentWeight + item.Weight <= _carryWeight)
                {

                    items.Add(item);
                    Update(new PickUpEvent(_actorLocation, item, this));
                    _currentWeight += item.Weight;
                    return true;
                }
            }
            return true;
        }
		/// <summary>
		/// Overrides Eat Method
		/// </summary>
        public override bool Eat(IItem item)
        {
            if (item is AbstractFood)
            {
                if ((item as AbstractFood).IsEdible)
                {
                    if ((item as AbstractFood).EnergyValue + _health.Health > _startingHealth)
                    {
                        _health.Health = _startingHealth;
                        items.Remove(item);
                        _currentWeight -= item.Weight;
                        Update(new EatEvent(_actorLocation, item, this));
                        return true;
                    
                    }
                    else
                    {
                        _health.Health += (item as AbstractFood).EnergyValue;
                        items.Remove(item);
                        _currentWeight -= item.Weight;
                        Update(new EatEvent(_actorLocation, item, this));
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            
            
            }
            else
            {
                return false;
            }

        }
		/// <summary>
		/// Returns true/false for whether
		/// the carrying limit has reached
		/// </summary>
        public bool WeightLimitReached
        {
            get { return _carryWeight == _currentWeight; }
        }
		
		/// <summary>
		/// OnNext Method
		/// </summary>
        public override void OnNext(object request)
        {
            if (request is IDeathEvent)
            {
                if (_lives > 0)
                {
                    _lives--;
                }
                _health.Health = 0;
                if (IsDead == false)
                {
                    _health.Health = _config.StartingHealth;
                }
                else if (IsDead)
                {
                    Globals.GlobalVar = false;
                }

            }
            else if (request is ISurvivedTrap)
            {
                items.Remove(new Key());
            }
            else if(request is IMoveEventEnter)
            {
                _health.Health -= MovePenalty;
                _actorLocation = (request as IMoveEventEnter).Location;
            }
            else if (request is IDeadEndDeath)
            {
                _health.Health = 0;
                _lives = 0;
                Globals.GlobalVar = false;
            }

        }
		/// <summary>
		/// OnError
		/// </summary>
        public override void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }
		
		/// <summary>
		/// When completed, allows to unsubscribe
		/// </summary>
        public override void OnCompleted()
        {
            Unsubscribe();
        }
		/// <summary>
		/// Unsubscribe method
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
		/// Returns number of coins
		/// </summary>
        public override int Coins
        {
            get { return _coins.Count; }
        }
		/// <summary>
		/// Returns health
		/// </summary>
        public override HealthMeter Health
        {
            get { return _health; }
        }
		/// <summary>
		/// Returns whether or not the actor is dead
		/// </summary>
        public override bool IsDead
        {
            get { return _lives == 0; }
        }
		
		/// <summary>
		/// Returns whether or not the actor has Key
		/// </summary>
        public override bool HasKey
        {
            get { return items.Contains(new Key()); }
        }
    }
}