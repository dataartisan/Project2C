using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project2B
{
 
    public sealed class Terrian1 : ITerrian
    {
        private IList<ILocations> _holder;
        private List<string> _loc;
        private const string FileName = "c:\terrain.txt";
        private static Terrian1 _instance;

        private Terrian1 (){}


        public void BuildTerrian()
        {
            
            _holder = new List<ILocations>(); 
            _loc= new List<string>(); 
            using (var r = new StreamReader(FileName))
            {
                   string line;
                   
                   while ((line = r.ReadLine()) != null)
                   {
                       _loc.Add(line);
                   }
            }
            foreach (var v in _loc)
            {
               
                _holder.Add(new ContainerLocation(new Location(v)));
            }

            MakeExits();
            MakeGrid1();
            MakeGrid2();
            MakeGrid3();


        }
    
        private void MakeExits()
        {
            _holder[23] = new ExitLocations(_holder[23]);
            _holder[22] = new ExitLocations(_holder[22]);
            _holder[21] = new ExitLocations(_holder[21]);
        }
    

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
        private void MakeGrid2()
        {
            _holder[3].AddNeighbor(_holder[24], Directions.Up);
            _holder[3].AddNeighbor(_holder[9], Directions.Down);
            _holder[3].AddNeighbor(_holder[7], Directions.West);
            _holder[3].AddNeighbor(_holder[4], Directions.East);
            _holder[9].AddNeighbor(_holder[15], Directions.North);
            _holder[9].AddNeighbor(_holder[25], Directions.South);
            _holder[9].AddNeighbor(_holder[11], Directions.South);
            _holder[15].AddNeighbor(_holder[24], Directions.Down);
            _holder[15].AddNeighbor(_holder[18], Directions.East);
            _holder[15].AddNeighbor(_holder[14], Directions.East);
            _holder[18].AddNeighbor(_holder[12], Directions.North);
            _holder[18].AddNeighbor(_holder[16], Directions.West);
            _holder[4].AddNeighbor(_holder[18], Directions.West);
            _holder[4].AddNeighbor(_holder[19], Directions.North);
            _holder[16].AddNeighbor(_holder[15], Directions.North);
            _holder[17].AddNeighbor(_holder[4], Directions.South);
            _holder[17].AddNeighbor(_holder[9], Directions.Down);
            _holder[17].AddNeighbor(_holder[13], Directions.Down);
            _holder[13].AddNeighbor(_holder[6], Directions.Up);
            _holder[13].AddNeighbor(_holder[3], Directions.North);
            _holder[13].AddNeighbor(_holder[10], Directions.South);
            _holder[10].AddNeighbor(_holder[15], Directions.Up);
            _holder[10].AddNeighbor(_holder[13], Directions.East);
            _holder[10].AddNeighbor(_holder[8], Directions.East);

        }

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
            _holder[11].AddNeighbor(_holder[5], Directions.East);
            _holder[11].AddNeighbor(_holder[18], Directions.North);
            _holder[20].AddNeighbor(_holder[22], Directions.West);
            _holder[14].AddNeighbor(_holder[7], Directions.West);
            _holder[14].AddNeighbor(_holder[4], Directions.North);
            _holder[14].AddNeighbor(_holder[1], Directions.North);
            _holder[14].AddNeighbor(_holder[9], Directions.South);
            _holder[14].AddNeighbor(_holder[23], Directions.Down);
           

        }

        public static Terrian1 Instance
        {
            get { return _instance ?? (_instance = new Terrian1()); }
        }
        
        public ILocations Start
        {
            get { return _holder[0]; }
        }
    
    
    }
}