using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Project2B.Monster
{
    class DeadlyMonster : AbstractMonster
    {
        private int _monsterHealth;
        private LocationObserverandObservable _current;
        private ITerrian _ter;
        private Thread _monster;
        private object _locker;

        public DeadlyMonster(LocationObserverandObservable terrain, ITerrian terrain1)
        {
            _monsterHealth = 100;
            _current = terrain;
            _ter = terrain1;
            _locker = new object();
            _monster = new Thread(Search); 
            _monster.Start();
        }
        
        public override bool Equals(AbstractMonster other)
        {
            if (this.MonsterName.Equals(other.MonsterName) && other.GetType() == this.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        private void Move()
        {
            var J = new Random().Next(1, 6);

            switch(J)
            {
                    case 1:
                    if(_current.GetNeighbors.ContainsKey(Directions.Up))
                    {   
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.Up];
                        _current = _ter.GetLocation(p.Name);
                        

                    }
                    break;
                    case 2:
                    if (_current.GetNeighbors.ContainsKey(Directions.Down))
                    {
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.Down];
                        _current = _ter.GetLocation(p.Name);
                        
                    }
                    break;
                    case 3:
                    if (_current.GetNeighbors.ContainsKey(Directions.North))
                    {
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.North];
                        _current = _ter.GetLocation(p.Name);
                        
                    }
                    break;
                    case 4:
                    if (_current.GetNeighbors.ContainsKey(Directions.South))
                    {
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.South];
                        _current = _ter.GetLocation(p.Name);
                       
                    }
                    break;
                    case 5:
                    if (_current.GetNeighbors.ContainsKey(Directions.East))
                    {
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.East];
                        _current = _ter.GetLocation(p.Name);

                    }
                    break;
                    case 6:
                    if (_current.GetNeighbors.ContainsKey(Directions.West))
                    {
                        _current.ExitLocation(this);
                        var p = _current.GetNeighbors[Directions.West];
                        _current = _ter.GetLocation(p.Name);
                        
                    }
                    break;
            
            
            }
         
        }
      
        public override string ToString()
        {
            return MonsterName;
        }
        
        public override string MonsterName
        {
            get { return "Deadly Monster"; }
        }

        public override int MonsterHealth
        {
            get { return _monsterHealth; }
        }

        private void Stop()
        {
            _monster.Join();
            _monster = null;
        }
        
        public override void Search()
        {
            while (Globals.GlobalVar)
            {
                Thread.Sleep(1000);
                _current.EnterLocation(this);
                if (_current.GetNeighbors.Count == 0)
                {
                    Stop();
                }
                else if(_current.Players.Count > 0)
                {

                    var J = _current.Players;
                    for (int i = 0; i < J.Count; i++)
                    {
                        Fight(J[i]);
                    }
                   
                  
                }
                else
                {
                    Look();
                    Move();
                }
            
            }
            if(Globals.GlobalVar != true)
            {
                Stop();
            }
        
        }

        public override void Look()
        {
            var j = _current.GetNeighbors.GetEnumerator();

            while (j.MoveNext())
            {
                if (j != null)
                {
                    var P = j.Current.Value;
                    var N = _ter.GetLocation(P.Name);
                    if (N.Players.Count > 0)
                    {
                        _current.ExitLocation(this);
                        _current = N;
                        

                    }

                }
            }  
            
        }

        

        public override void Fight(IActor actor)
        {
           Thread.Sleep(5000);
            while (_monsterHealth > 0 && (actor as Player).Health.Health > 0)
            {
                if ((actor as Player).CurrentWeapon != null)
                {
                    _monsterHealth -= (actor as Player).CurrentWeapon.Damage;
                }
               
                if (AttackPower > (actor as Player).ArmorProtection)
                {
                    if((actor as Player).Health.Health - AttackPower < 0)
                    {
                        (actor as Player).Health.Health = 0;
                    }
                    else
                    {
                        (actor as Player).Health.Health -= (AttackPower - (actor as Player).ArmorProtection);
                    }
                    
                }
               
            }
            if (_monsterHealth > 0)
            {
                (actor as Player).OnNext(new DeathEvent(actor));
                Look();
                Move();
            }
            else if (_monsterHealth <=0)
            {
                _current.ExitLocation(this);
                Stop();
                
            }
        }

        public override int AttackPower
        {
            get { return 6; }
           
        }

        public override void ExploreTerrain(ILocations startingLocation)
        {
            throw new System.NotImplementedException();
        }

        public override LocationObserverandObservable ActorLocation
        {
            get { return _current; }
            set { _current = value; }
        }

        public override LocationObserverandObservable ActorLocationNew
        {
            get { return _current; }
            set { _current = value; }
        }
    }
}