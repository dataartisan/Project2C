using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Project2B.Monster;

namespace Project2B
{
    class MonsterSpawner
    {
        private Thread _spawn;
        private ITerrian _terrain;

        public MonsterSpawner(ITerrian terrian)
        {
            _terrain = terrian;
            _spawn = new Thread(Spawner);
            _spawn.Start();
        }

        private void Stop()
        {
           _spawn.Join();
           _spawn = null;
        }
        
        private void Spawner()
        {
            while (Globals.GlobalVar)
            {
               new DeadlyMonster(_terrain.Terrian[new Random().Next(10,14)],_terrain);
               Thread.Sleep(10000);
                if (Globals.GlobalVar == false)
                {
                    Stop();

                }
            }
            
        }
       
    }
}
