using System;
using Project2B.GameTerrain;

namespace Project2B
{
    //this builds the game and allows to run via main method.
    class GameRun
    {
        private readonly ITerrian _game1;
        private IRecord log;
        private LocationObserverandObservable _start;
        private IActor player;
        /// <summary>
		/// Contructor
		/// </summary>
        public GameRun(string name)
        {
            _game1 = new Terrian1();
            log = SuperTripRecorder.Instance;
            _start = _game1.Start;
            player = new Player(name);
            
            GameStart();
        }
		/// <summary>
		/// Start the game
		/// </summary>

        private void GameStart()
        {
            (player as Actor).Subscribe(_game1.Start as LocationObserverandObservable);
            (_game1.Start as LocationObserverandObservable).Subscribe(player as Actor);
            
            _start = _game1.Start;

            var tripRecorder = log as SuperTripRecorder;
            if (tripRecorder != null)
                tripRecorder.Subscribe(_start as LocationObserverandObservable );
                tripRecorder.Subscribe(player as Actor);
        }
        
		/// <summary>
		/// returns _game object
		/// </summary>
        public ITerrian Terrain
        {
            get { return _game1; }
        }
		
		/// <summary>
		/// returns wrapped TripRecorderLog
		/// </summary>
        public string GetLog
        {
            get { return (log as SuperTripRecorder).GetRecordLog(); }
        }
		/// <summary>
		/// returns startLocation
		/// </summary>
        public LocationObserverandObservable Start
        {
            get { return _start; }
        }
		/// <summary>
		/// returns player
		/// </summary>
        public IActor Player
        {
            get { return player; }
        }
    
    }
}
