using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    class GameRun
    {
        private ITerrian _game1 = Terrian1.Instance;
        private IRecord log = TripRecorder.Instance;
        private ILocations _start;
        private IExploreAlgorithm _first = new Algorithm1();
        private IActor player = new Player("Bob");
        private int count = 23;

        public void GameStart()
        {
            _game1.BuildTerrian();
            _start = _game1.Start;
            (log as TripRecorder).Subscribe(_start as LocationDecorator);
            (_first as Algorithm1).Explore(player, _start, count);

            (_start as LocationDecorator).EndUpdate();

            Console.WriteLine(log.GetRecordLog());

        }

    }
}
