using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Project2B.Armors;
using Project2B.Misc;

//terrain class
namespace Project2B.GameTerrain
{
 
    public class Terrian1 : ITerrian
    {
        private IList<ILocations> _holder;
        private List<LocationObserverandObservable> _holder2;
        private List<string> _loc;
        private const string FileName = @"C:\terrain.txt";
        private const string Filename2 = @"C:\Descriptions.txt";
        private Dictionary<string, string> LocDescription;
        private DataTable _items;

		///<summary>
		/// Executes the terrain build
		///</summary>
        public Terrian1()
        {
            BuildTerrian();
        }

        public DataTable Items
        {
            get { return _items; }
        }

        ///<summary>
		/// Builds the terrain
		///</summary>
        public void BuildTerrian()
        {
            LocDescription = new Dictionary<string, string>();
            _holder2 = new List<LocationObserverandObservable>();
            _holder = new List<ILocations>(); 
            _loc= new List<string>();
            _items = new DataTable();
            /*
             using (var r = new StreamReader(FileName))
             {
             string line;
             while ((line = r.ReadLine()) != null)
                   {
                        _loc.Add(line);
                   }
             }
            foreach (string v in _loc)
            {
               
                
             }
            */
                        _holder.Add(new ContainerLocation(new Location("Entrance Hall")));
                        _holder.Add(new ContainerLocation(new Location("Underpass 1")));
                        _holder.Add(new ContainerLocation(new Location("Underpass 2")));
                        _holder.Add(new ContainerLocation(new Location("Valley 1")));
                        _holder.Add(new ContainerLocation(new Location("Valley 2")));
                        _holder.Add(new ContainerLocation(new Location("Valley 3")));
                        _holder.Add(new ContainerLocation(new Location("Swamp 1")));
                        _holder.Add(new ContainerLocation(new Location("Swamp 2")));
                        _holder.Add(new ContainerLocation(new Location("Swamp 3")));
                        _holder.Add(new ContainerLocation(new Location("Mountain 1")));
                        _holder.Add(new ContainerLocation(new Location("Mountain 2")));
                        _holder.Add(new ContainerLocation(new Location("Mountain 3")));
                        _holder.Add(new ContainerLocation(new Location("River 1")));
                        _holder.Add(new ContainerLocation(new Location("River 2")));
                        _holder.Add(new ContainerLocation(new Location("River 3")));
                        _holder.Add(new ContainerLocation(new Location("Forest 1")));
                        _holder.Add(new ContainerLocation(new Location("Forest 2")));
                        _holder.Add(new ContainerLocation(new Location("Forest 3")));
                        _holder.Add(new ContainerLocation(new Location("Hill 1")));
                        _holder.Add(new ContainerLocation(new Location("Hill 2")));
                        _holder.Add(new ContainerLocation(new Location("Hill 3")));
                        _holder.Add(new ContainerLocation(new Location("Dungeon 1")));
                        _holder.Add(new ContainerLocation(new Location("Dungeon 2")));
                        _holder.Add(new ContainerLocation(new Location("Dungeon 3")));
                        _holder.Add(new ContainerLocation(new Location("Hallway 1")));
                        _holder.Add(new ContainerLocation(new Location("Hallway 2")));

             
                        
            
            MakeExits();
            MakeGrid1();
            MakeGrid2();
            MakeGrid3();
            NewWrap();
            AddDescription();
            AddFixtures();
            BlackOut();
            AddCoins();
            FoodKnifeKeyArmor();
            FoodKnifeKey2();
            SaveDescription();
        }

        ///<summary>
        /// Blacks out the enhanced location
        ///</summary>
       
        
        private void BlackOut()
        {
            (_holder2[1] as ILocationEnchancedWrapper).IsDark = true;
            (_holder2[2] as ILocationEnchancedWrapper).IsDark = true;
        
        }

        ///<summary>
		/// Adds coin
		///</summary>
        private void AddCoins()
        {
            for(int i = 0; i < _holder.Count;i++)
            {
                (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Coin());
                (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Coin());

            }
            (_holder2[0] as ILocationEnchancedWrapper).AddItem(new FlashLight());
        
        }
        
        
       private void FoodKnifeKeyArmor()
       {
           for (int i = 0; i < _holder.Count; i = i+2)
           {
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Beef());
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Key());
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Knife());
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Armor());

           }

        }
       private void FoodKnifeKey2()
       {
           for (int i = 1; i < _holder.Count; i = i + 2)
           {
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Beef());
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Key());
               (_holder2[i] as ILocationEnchancedWrapper).AddItem(new Knife());

           }

       }
        

        
        ///<summary>
		/// Adds fixtures
		///</summary>
        private void AddFixtures()
        {
            (_holder2[1] as ILocationEnchancedWrapper).AddFixture(new LightSource());
            (_holder2[1] as ILocationEnchancedWrapper).AddFixture(new Trap());
            (_holder2[1] as ILocationEnchancedWrapper).AddItem(new FlashLight());
            


        }
		///<summary>
		/// Add description to the location cells
		///</summary>
        private void AddDescription()
        {
            using (var r = new StreamReader(Filename2))
            {
                var i = 0;
                string line;
                try
                {
                    while ((line = r.ReadLine()) != null && i < _holder.Count)
                    {
                        (_holder2[i] as ILocationEnchancedWrapper).Description = line;
                        i++;
                    }
                }
                catch (Exception e)
                {

                    Console.Write("Exception was thrown. Details here: " + e.Message);
                }
               
            }
        }
		///<summary>
		/// this allows us to mark the locations as exits.
		///</summary>
        
        private void MakeExits()
        {
            try
            {
                _holder[6] = new ExitLocations(_holder[6]);
                _holder[20] = new ExitLocations(_holder[20]);
                _holder[16] = new ExitLocations(_holder[16]);
            }
            catch (Exception e)
            {
                
                Console.Write("Exception was thrown. Details here: " + e.Message);
            }
           
        }
    
        ///<summary>
		/// this allows us to build the grids
		///</summary>
        private void MakeGrid1()
        {
            _holder[0].AddNeighbor(_holder[25],Directions.Up);
            _holder[0].AddNeighbor(_holder[1], Directions.Down);
            _holder[0].AddNeighbor(_holder[2], Directions.West);
            _holder[0].AddNeighbor(_holder[5], Directions.East);
            _holder[0].AddNeighbor(_holder[6], Directions.North);
            _holder[0].AddNeighbor(_holder[12], Directions.South);
            _holder[24].AddNeighbor(_holder[2], Directions.South);
            _holder[24].AddNeighbor(_holder[4], Directions.Down);
            _holder[24].AddNeighbor(_holder[7], Directions.East);
            _holder[2].AddNeighbor(_holder[1], Directions.East);
            _holder[2].AddNeighbor(_holder[7], Directions.North);
            _holder[2].AddNeighbor(_holder[3], Directions.West);
            _holder[1].AddNeighbor(_holder[25], Directions.West);
            _holder[1].AddNeighbor(_holder[24], Directions.North);
            _holder[7].AddNeighbor(_holder[12], Directions.North);
            _holder[7].AddNeighbor(_holder[5], Directions.South);
            _holder[7].AddNeighbor(_holder[17], Directions.Down);
            _holder[5].AddNeighbor(_holder[7], Directions.Down);
            _holder[5].AddNeighbor(_holder[18], Directions.Up);
            _holder[12].AddNeighbor(_holder[15], Directions.North);
            _holder[12].AddNeighbor(_holder[7], Directions.South);
            _holder[12].AddNeighbor(_holder[18], Directions.Up);
            _holder[12].AddNeighbor(_holder[9], Directions.East);

        }

        ///<summary>
		/// this allows us to build the grids
		///</summary>
        private void MakeGrid2()
        {
            _holder[3].AddNeighbor(_holder[24], Directions.Up);
            _holder[3].AddNeighbor(_holder[9], Directions.Down);
            _holder[3].AddNeighbor(_holder[7], Directions.West);
            _holder[3].AddNeighbor(_holder[4], Directions.East);
            _holder[9].AddNeighbor(_holder[15], Directions.North);
            _holder[9].AddNeighbor(_holder[25], Directions.South);
            _holder[9].AddNeighbor(_holder[11], Directions.Down);
            _holder[15].AddNeighbor(_holder[24], Directions.Down);
            _holder[15].AddNeighbor(_holder[18], Directions.East);
            _holder[15].AddNeighbor(_holder[14], Directions.West);
            _holder[18].AddNeighbor(_holder[12], Directions.North);
            _holder[18].AddNeighbor(_holder[16], Directions.West);
            _holder[4].AddNeighbor(_holder[18], Directions.West);
            _holder[4].AddNeighbor(_holder[19], Directions.North);
            _holder[16].AddNeighbor(_holder[15], Directions.North);
            _holder[17].AddNeighbor(_holder[4], Directions.South);
            _holder[17].AddNeighbor(_holder[9], Directions.Down);
            _holder[17].AddNeighbor(_holder[13], Directions.East);
            _holder[17].AddNeighbor(_holder[22], Directions.West);
            _holder[13].AddNeighbor(_holder[6], Directions.Up);
            _holder[13].AddNeighbor(_holder[3], Directions.North);
            _holder[13].AddNeighbor(_holder[10], Directions.South);
            _holder[10].AddNeighbor(_holder[15], Directions.Up);
            _holder[10].AddNeighbor(_holder[13], Directions.East);
            _holder[10].AddNeighbor(_holder[8], Directions.North);

        }
        ///<summary>
		/// Build the grids
		///</summary>
        private void MakeGrid3()
        {
            _holder[8].AddNeighbor(_holder[5], Directions.Up);
            _holder[8].AddNeighbor(_holder[2], Directions.Down);
            _holder[8].AddNeighbor(_holder[16], Directions.West);
            _holder[8].AddNeighbor(_holder[19], Directions.East);
            _holder[19].AddNeighbor(_holder[21], Directions.North);
            _holder[19].AddNeighbor(_holder[13], Directions.South);
            _holder[11].AddNeighbor(_holder[20], Directions.South);
            _holder[11].AddNeighbor(_holder[25], Directions.Down);
            _holder[11].AddNeighbor(_holder[3], Directions.East);
            _holder[11].AddNeighbor(_holder[5], Directions.Up);
            _holder[11].AddNeighbor(_holder[18], Directions.North);
            _holder[20].AddNeighbor(_holder[22], Directions.West);
            _holder[14].AddNeighbor(_holder[7], Directions.West);
            _holder[14].AddNeighbor(_holder[4], Directions.North);
            _holder[14].AddNeighbor(_holder[1], Directions.East);
            _holder[14].AddNeighbor(_holder[9], Directions.South);
            _holder[14].AddNeighbor(_holder[23], Directions.Down);
           

        }

        ///<summary>
		/// Mark the start location
		///</summary>
       
        private void NewWrap()
        {
            for (int i = 0; i < _holder.Count(); i++)
            {
                _holder2.Add(new LocationLevelTwoWrap(_holder[i] as ILocationDecorator));
            }
        }
        private void SaveDescription()
        {
            foreach (var j in _holder2)
            {
                LocDescription.Add(j.Name,j.Description);
            }
        }


		///<summary>
		/// returns the start location
		///</summary>
        public LocationObserverandObservable Start
        {
            get { return _holder2[0]; }
        }
		///<summary>
		/// returns the holder
		///</summary>
    
        public List< LocationObserverandObservable> Terrian
        {
            get { return _holder2; }

        }
        
        public LocationObserverandObservable GetLocation(string name)
        {

                foreach (LocationObserverandObservable j in _holder2)
                {
                    if (j.Name.Equals(name))
                        return j;
                }
                throw new Exception();
           
        }   

    }
}