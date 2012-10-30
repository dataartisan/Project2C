using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project2B.Events;
using Project2B.Interfaces;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Project2B
{
    public partial class GameGui : Form, IObservable<object>,IObserver<object>
    {
        private GameRun _game;
        private LocationObserverandObservable _start;
        private Actor _player;
        private Directions _dir;
        private LocationObserverandObservable _currentLocation;
        private LocationObserverandObservable _lookDirection;
        private StringBuilder description;
        private static List<IObserver<object>> _observers = new List<IObserver<object>>();
        private MonsterSpawner _spawn;
        private Timer _tmr;
        private Timer _tmr2;
        private Timer _tmr3;
        public GameGui()
        {
            InitializeComponent();
            
            
        }
        

       

        private void HideLook()
        {
            WestButton.Hide();
            NorthButton.Hide();
            SouthButton.Hide();
            EastButton.Hide();
            UpButton.Hide();
            DownButton.Hide();
            LookGoPanel.Refresh();

        }
        private void ShowLook()
        {
            DisplayDown(_player.ActorLocation.GetNeighbors);
            DisplayEast(_player.ActorLocation.GetNeighbors);
            DisplayWest(_player.ActorLocation.GetNeighbors);
            DisplayNorth(_player.ActorLocation.GetNeighbors);
            DisplaySouth(_player.ActorLocation.GetNeighbors);
            DisplayUp(_player.ActorLocation.GetNeighbors);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var j = PlayerNameText.Text.Trim();
            if (j.Length < 1)
            {
                MessageBox.Show("Please enter a valid player name","Error");

            }
            else
            {
                InitalSetup();
            }
       
        }
        private void RestoreHealth()
        {
            var j = _game.Player;
            PlayerHealthBar.Value = (j as Actor).StartingHealth;
            PlayerHealthLabel.Text = ((j as Actor).ActorName + "'s Health");
            HealthNumber.Text = (PlayerHealthBar.Value.ToString());
            PlayerHealthPanel.Refresh();

        }
        
        private void UpDateHealth()
        {   
            _tmr.Start();
            _tmr.Interval = 1;
            var j = _game.Player;


            PermaDeathCheck();
            
            PlayerHealthBar.Value = (j as Actor).Health.Health;
            HealthNumber.Text = (PlayerHealthBar.Value.ToString());
            PlayerHealthPanel.Refresh();

           
        }
        private void DisplayPlayerHealth()
        {
            var j = _game.Player;
            PlayerHealthBar.Minimum = 0;
            PlayerHealthBar.Maximum = (j as Actor).Health.Health;
            PlayerHealthBar.Value = (j as Actor).Health.Health;
            PlayerHealthLabel.Text = ((j as Actor).ActorName + "'s Health");
            HealthNumber.Text = (PlayerHealthBar.Value.ToString() );
            PlayerHealthPanel.Refresh();
        }

        private void HideMainDisplayShowDes()
        {
            LocationShapePanel.Hide();
            LocationShapePanel.Refresh();
        }
        private void ShowDisplayLocation()
        {
            var locationObserverandObservable = CurrentLocation();
            if (locationObserverandObservable != null)
            {
                var t = locationObserverandObservable.GetNeighbors;

                DisplayUp(t);
                DisplayDown(t);
                DisplayNorth(t);
                DisplaySouth(t);
                DisplayEast(t);
                DisplayWest(t);
            }
            LocationShapePanel.Refresh();
            LookGoPanel.Refresh();
            DisplayLocationItems();
            UpdateTopButtons();
            DisplayPlayerItems();
            DisplayPlayerCoins();
            



        }

        private void UpdateTopButtons()
        {
           if(_currentLocation.HasLightSource)
           {
               LightOnButton.Show();
               LightOnButton.Refresh();
               LightOffButton.Show();
               LightOffButton.Refresh();
               LocationSwitchPanel.Refresh();
           }
           if(_currentLocation.HasDrawBridge)
           {
               LowerButton.Show();
               RaiseButton.Show();
               LocationSwitchPanel.Refresh();
           }
           else
           {
               LightOnButton.Hide();
               LightOnButton.Refresh();
               LightOffButton.Hide();
               LightOffButton.Refresh();
               LowerButton.Hide();
              LowerButton.Refresh();
               RaiseButton.Hide();
               RaiseButton.Refresh();
               LocationSwitchPanel.Refresh();
           }
           LocationSwitchPanel.Refresh();
        
        }

        private LocationObserverandObservable CurrentLocation()
        {
            var j = _player.ActorLocation;
            return (j);
        }

        private void DisplayLocationItems()
        {
            LocationList.DataSource = null;
            
            var j = new BindingList<IItem>(_player.ActorLocation.Items);
            LocationList.DataSource = j;
           /* 
            foreach (var j in _player.ActorLocation.Items)
            {
                LocationList.Items.Add(j);
            }
            */

            LocationItemPanel.Refresh();
            LocationList.Refresh();
        
       }
        private void DisplayPlayerItems()
        {

            PlayerList.DataSource = _player.Items;
            PlayerItemPanel.Refresh();
            PlayerList.Refresh();
        }
        
        private void DisplayUp(IDictionary<Directions, ILocations> locationses)
        {
            if(locationses.ContainsKey(Directions.Up))
            {
                UpLine.Show();
                Up.Show();
                UpButton.Show();
            }
            else
            {
                UpLine.Hide();
                Up.Hide();
                UpButton.Hide();
            }
        
        }
        private void DisplayDown(IDictionary<Directions, ILocations> locationses)
        {
            if (locationses.ContainsKey(Directions.Down))
            {
                DownLine.Show();
                Down.Show();
                DownButton.Show();
            }
            else
            {
                DownLine.Hide();
                Down.Hide();
                DownButton.Hide();
            }

        }
        private void DisplayNorth(IDictionary<Directions, ILocations> locationses)
        {
            if (locationses.ContainsKey(Directions.North))
            {
                NorthLine.Show();
                North.Show();
                NorthButton.Show();
            }
            else
            {
                NorthLine.Hide();
                North.Hide();
                NorthButton.Hide();
            }

        }
        private void DisplaySouth(IDictionary<Directions, ILocations> locationses)
        {
            if (locationses.ContainsKey(Directions.South))
            {
                SouthLine.Show();
                South.Show();
                SouthButton.Show();
            }
            else
            {
                SouthLine.Hide();
                South.Hide();
                SouthButton.Hide();
            }

        }
        private void DisplayWest(IDictionary<Directions, ILocations> locationses)
        {
            if (locationses.ContainsKey(Directions.West))
            {
                WestLine.Show();
                West.Show();
                WestButton.Show();
            }
            else
            {
                WestLine.Hide();
                West.Hide();
                WestButton.Hide();
            }

        }
        private void DisplayEast(IDictionary<Directions, ILocations> locationses)
        {
            if (locationses.ContainsKey(Directions.East))
            {
                EastLine.Show();
                East.Show();
                EastButton.Show();
                

            }
            else
            {
                EastLine.Hide();
                East.Hide();
                EastButton.Hide();
            }

        }
        
        

        private void LookDescriptionHide()
        {
            LookDescription.Hide();
        }
       
        private void InitalSetup()
        {
            _game = new GameRun(PlayerNameText.Text);
            NameEnterPanel.Hide();
            _tmr = new Timer();
            _tmr2 = new Timer();
            _tmr3 = new Timer();
            DisplayPlayerHealth();
            _start = (LocationObserverandObservable) _game.Start;
            _player = (_game.Player as Actor);
            LookDescriptionHide();
            _start.EnterLocation(_player);
            _currentLocation = _player.ActorLocationNew;
            DisplayLocationItems();
            description = new StringBuilder();
            UpdateTopButtons();
            LookDescription.Show();
            ExitCheck();
            HideLook();
            ReturnButton.Hide();
            Subscribe(_player);
            _player.Subscribe(this);
            _spawn = new MonsterSpawner(_game.Terrain);
            UpDateLocation();
            _game.Terrain.Start.Subscribe(this);



        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            TripLogBox.Text = _game.GetLog;
            
        }

        private void LocationItemButton_Click(object sender, EventArgs e)
        {
            if (LocationList.SelectedItem != null)
            {
                _player.PickUp((IItem)LocationList.SelectedItem);
                //LocationList.Items.Remove(LocationList.SelectedItem);
                PlayerCoinDisplay.Text = LocationList.Items.Count.ToString();
                PlayerCoinDisplay.Refresh();
                PlayerList.DataSource = null;
                DisplayPlayerItems();
                DisplayPlayerCoins();
                DisplayLocationItems();
            
            
            }

        }

        private void DisplayPlayerCoins()
        {
            PlayerCoinDisplayPanel.Refresh();
            PlayerCoinDisplay.Text = (_player as Actor).ActorName + " has " + _player.Coins + " coins.";
        }

        private void PlayerItemDropButton_Click(object sender, EventArgs e)
        {

            if (PlayerList.SelectedItem != null)
            {

                _player.Drop(PlayerList.SelectedItem as IItem);
               // LocationList.Items.Add(PlayerList.SelectedItem);
                PlayerList.DataSource = null;
                DisplayPlayerItems();
                DisplayLocationItems();
            }
        }


        private void PlayerItemEatButton_Click(object sender, EventArgs e)
        {

            if (PlayerList.SelectedItem != null)
            {
                if ((PlayerList.SelectedItem as IItem).IsEdible)
                {
                    _player.Eat(PlayerList.SelectedItem as IItem);
                    UpDateHealth();
                    PlayerList.DataSource = null;
                    DisplayPlayerItems();
                    DisplayLocationItems();

                }
            }
        }

        private void PlayerItemTurnOnButton_Click(object sender, EventArgs e)
        {
            if (CurrentLocation().HasLightSource == false && CurrentLocation().IsDark)
            {
                if((PlayerList.SelectedItem is AbstractTool))
                {
                    if ((PlayerList.SelectedItem as AbstractTool).IsSwitchAble)
                    {
                       (PlayerList.SelectedItem as AbstractTool).TurnON();
                        ShowDisplayLocation();
                        LookButton.Show();
                        LookButton.Enabled = true;
                        ReturnButton.Show();
                        ReturnButton.Enabled = true;
                        LookGoPanel.Refresh();

                        TurnOffButton.Show();
                        PlayerItemTurnOnButton.Show();
                        
                        PlayerItemPanel.Refresh();

                    }
                    else
                    {
                        TurnOffButton.Hide();
                        PlayerItemTurnOnButton.Hide();
                        PlayerItemPanel.Refresh();
                    }
                
                
                }
             }
        
            else if(PlayerList.SelectedItem is AbstractWeapon)
            {
                if((PlayerList.SelectedItem as AbstractWeapon).IsSwitchAble)
                {
                    (PlayerList.SelectedItem as AbstractWeapon).TurnON();
                    TurnOffButton.Show();
                    PlayerItemTurnOnButton.Show();
                    PlayerItemPanel.Refresh();
                    EquipWeaponButton.Show();
                    UnEquipPlayerWeapon.Show();
                }
                else
                {
                    TurnOffButton.Hide();
                    PlayerItemTurnOnButton.Hide();
                    EquipWeaponButton.Show();
                    UnEquipPlayerWeapon.Show();
                    PlayerItemPanel.Refresh();
                    
                }
            
            }
        
        }

        private void PlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PlayerList.SelectedItem is AbstractFood)
            {
                PlayerItemEatButton.Show();
                PlayerItemDropButton.Show();
                PlayerItemTurnOnButton.Hide();
                TurnOffButton.Hide();
                EquipWeaponButton.Hide();
                UnEquipPlayerWeapon.Hide();
                PlayerItemPanel.Refresh();
            }
            if (PlayerList.SelectedItem is AbstractCurrency)
            {
                PlayerItemDropButton.Show();
                PlayerItemEatButton.Hide();
                PlayerItemTurnOnButton.Hide();
                TurnOffButton.Hide();
                EquipWeaponButton.Hide();
                UnEquipPlayerWeapon.Hide();
                PlayerItemPanel.Refresh();

            }
            if (PlayerList.SelectedItem is AbstractTool)
            {
                if ((PlayerList.SelectedItem as AbstractTool).IsSwitchAble)
                {
                    PlayerItemDropButton.Show();
                    PlayerItemEatButton.Hide();
                    EquipWeaponButton.Hide();
                    UnEquipPlayerWeapon.Hide();
                    PlayerItemTurnOnButton.Show();
                    TurnOffButton.Show();
                    PlayerItemPanel.Refresh();

                }
                else
                {
                    PlayerItemDropButton.Show();
                    PlayerItemEatButton.Hide();
                    EquipWeaponButton.Hide();
                    UnEquipPlayerWeapon.Hide();
                    PlayerItemTurnOnButton.Hide();
                    TurnOffButton.Hide();
                    PlayerItemPanel.Refresh();
                }

            }
            if ((PlayerList.SelectedItem is AbstractWeapon))
            {
                if ((PlayerList.SelectedItem as AbstractWeapon).IsSwitchAble)
                {

                    PlayerItemDropButton.Show();
                    PlayerItemEatButton.Hide();
                    PlayerItemTurnOnButton.Show();
                    TurnOffButton.Show();
                    EquipWeaponButton.Show();
                    UnEquipPlayerWeapon.Show();
                    PlayerItemPanel.Refresh();
                }
                else
                {
                    PlayerItemDropButton.Show();
                    PlayerItemEatButton.Hide();
                    PlayerItemTurnOnButton.Hide();
                    TurnOffButton.Hide();
                    EquipWeaponButton.Show();
                    UnEquipPlayerWeapon.Show();
                    PlayerItemPanel.Refresh(); 
                }
            
            }
        
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {

            if (CurrentLocation().HasLightSource == false && CurrentLocation().IsDark == false)
            {
                if ((PlayerList.SelectedItem is AbstractTool))
                {
                    if ((PlayerList.SelectedItem as AbstractTool).IsSwitchAble)
                    {
                        (PlayerList.SelectedItem as AbstractTool).TurnOff();
                        HideMainDisplayShowDes();
                        LookButton.Hide();
                        LookButton.Enabled = false;
                        ReturnButton.Hide();
                        ReturnButton.Enabled = false;
                        LookGoPanel.Refresh();
                        

                    }
                }
            }

            else if (PlayerList.SelectedItem is AbstractWeapon)
            {
                if ((PlayerList.SelectedItem as AbstractWeapon).IsSwitchAble)
                {
                    (PlayerList.SelectedItem as AbstractWeapon).TurnOff();

                }

            }
        
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            TripLogBox.Clear();
        }

        private void LookButton_Click(object sender, EventArgs e)
        {
            
            GoButton.Hide();
            GoButton.Enabled = false;
            ReturnButton.Show();
            ShowLook();
            LookGoPanel.Refresh();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            LookButton.Show();
            LookButton.Enabled = true;
            GoButton.Show();
            GoButton.Enabled = true;
            ReturnButton.Hide();
            HideLook();
            LookDescription.Clear();
            LookDescription.Refresh();
            LookGoPanel.Refresh();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            LookButton.Hide();
            LookButton.Enabled = false;
            ReturnButton.Show();
            ShowLook();
            LookGoPanel.Refresh();
        }

        private void DirectionGoLook(Directions dir)
        {
            LocationObserverandObservable L = _player.ActorLocation;
            var P = L.GetNeighbors[dir];
            var T = _game.Terrain.GetLocation(P.Name);

            if (LookButton.Enabled == false)
            {
                
                if (_player.ActorLocation.HasDrawBridge)
                {
                    if (_player.ActorLocation.IsOn(new DrawBridge()))
                    {
                        Update(new DeathEvent(_player));
                    }
                }

                LocationObserverandObservable observerandObservable = L;

                if (observerandObservable != null && observerandObservable.GetNeighbors.ContainsKey(dir))
                {
                    
                    L.ExitLocation(_player);
                    _currentLocation = T;
                    _currentLocation.EnterLocation(_player);
                    CurrentLocationUpdatePanels();

                }
            }
            if (LookButton.Enabled)
            {
                
                LocationObserverandObservable observerandObservable = L;
                if (observerandObservable.GetNeighbors.ContainsKey(dir))
                {
                    _lookDirection = T;
                    LookDescription.Show();
                    description.Append("Location name: ");
                    description.Append(_lookDirection.Name);
                    description.AppendLine();
                    description.Append("Location description: ");
                    description.Append(_lookDirection.Description);
                    LookDescription.Text = description.ToString();
                    LookDescription.Refresh();
                    LocationLookPanel.Refresh();
                    description.Clear();
                }
            }


        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.Up);
        }

        private void CurrentLocationUpdatePanels()
        {
            UpDateHealth();
            ShowDisplayLocation();
            BlackOut();
            PermaDeathCheck();
            ClearLookLog();
            ExitCheck();
            ReturnButton.Hide();
            LookButton.Show();
            GoButton.Show();
            HideLook();
            LookGoPanel.Refresh();
            UpDateLocation();
        }

        private void ClearLookLog()
        {
            LookDescription.Clear();
            LookDescription.Refresh();
        }

        private void PermaDeathCheck()
        {
            if(_player.IsDead)
            {
                MessageBox.Show("You have no lives left, exiting game.", "Game Exiting");
                _tmr.Stop();
                _tmr2.Stop();
                Application.Exit();

            }
            else if(_player.Health.Health == 0 && _player.IsDead == false)
            {
                RestoreHealth();
            }

        
        }

        private  void BlackOut()
        {
            if(_currentLocation.HasLightSource)
            {
                LookButton.Hide();
                LookButton.Enabled = false;
                ReturnButton.Hide();
                ReturnButton.Enabled = false;
            }
            else if(_currentLocation.IsDark == false)
            {
                LookButton.Show();
                LookButton.Enabled = true;
                ReturnButton.Show();
                ReturnButton.Enabled = true;
            }
            else if(_currentLocation.IsDark)
            {
                LookButton.Hide();
                LookButton.Enabled = false;
                ReturnButton.Hide();
                ReturnButton.Enabled = false;
            }
        
        }

        private void LightOnButton_Click(object sender, EventArgs e)
        {
            if (_currentLocation.HasLightSource)
            {
                if(_currentLocation.IsDark)
                {
                    _currentLocation.IsDark = false;
                    LookButton.Show();
                    LookButton.Enabled = true;
                    ReturnButton.Show();
                    ReturnButton.Enabled = true;
                    LookGoPanel.Refresh();
                }
                

            }

        }

        private void LightOffButton_Click(object sender, EventArgs e)
        {

            if (_currentLocation.HasLightSource)
            {
                if (_currentLocation.IsDark == false)
                {
                    _currentLocation.IsDark = true;
                    LookButton.Hide();
                    LookButton.Enabled = false;
                    ReturnButton.Hide();
                    ReturnButton.Enabled = false;
                    LookGoPanel.Refresh();
                }


            }
       
        
        
        }

        private void RaiseButton_Click(object sender, EventArgs e)
        {
            if (_currentLocation.HasDrawBridge)
            {
                if (_currentLocation.IsOn(new DrawBridge()) == false)
                {
                    _currentLocation.TurnOnFixture(new DrawBridge());
                }


            }
        }

        private void LowerButton_Click(object sender, EventArgs e)
        {
            if (_currentLocation.HasDrawBridge)
            {
                if (_currentLocation.IsOn(new DrawBridge()))
                {
                    _currentLocation.TurnOffFixture(new DrawBridge());
                }


            }

        }

        public IDisposable Subscribe(IObserver<object> observers)
        {
            if (!_observers.Contains(observers))
                _observers.Add(observers);
            return new Unsubscriber(_observers, observers);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<object>> _observers;
            private IObserver<object> _observer;

            public Unsubscriber(List<IObserver<object>> observers, IObserver<object> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void Update(IEvent eEvent)
        {
            foreach (var observer in _observers)
            {
                
                observer.OnNext(eEvent);
                
            }
        }
        public void Update()
        {
            foreach (var observer in _observers)
            {
                if (observer is IRecord)
                {
                    observer.OnNext(this);
                    
                }


            }

        }
         
        public void EndUpdate()
        {
            for (int index = 0; index < _observers.Count; index++)
            {
                var observer = _observers[index];
                
                    observer.OnCompleted();
            }
            _observers.Clear();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.Down);
        
        }

        private void NorthButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.North);
        }

        private void SouthButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.South);
        }

        private void EastButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.East);
        }

        private void WestButton_Click(object sender, EventArgs e)
        {
            DirectionGoLook(Directions.West);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Playing, You collected " + _player.Coins + " total coins.");
            Application.Exit();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ExitButton.Hide();
            ContinueButton.Hide();
            ExitOrContinuePanel.Refresh();
        }
        private void ExitCheck()
        {
            

            if(_player.ActorLocation.IsIExit())
            {
                MessageBox.Show("An exit has been found, will you keep looking or exit ?");
                ExitButton.Show();
                ContinueButton.Show();
                ExitOrContinuePanel.Refresh();

            }
            else
            {
                ExitButton.Hide();
                ContinueButton.Hide();
                ExitOrContinuePanel.Refresh();
            }
        }

        private void EquipWeaponButton_Click(object sender, EventArgs e)
        {

            if (PlayerList.SelectedItem != null)
            {
                if ((PlayerList.SelectedItem as IItem) is AbstractWeapon)
                {
                    (_player as Player).CurrentWeapon = PlayerList.SelectedItem as AbstractWeapon;

                }
            }

        }

        private void UnEquipPlayerWeapon_Click(object sender, EventArgs e)
        {
            if ((PlayerList.SelectedItem as IItem) is AbstractWeapon)
            {
                (_player as Player).CurrentWeapon = null;

            }
        }

       private void UpDateLocation()
       {
           LocationNameText.Text = _currentLocation.Name;
           LocationNameText.Refresh();
       }


        public void OnNext(object value)
        {

            if(value is MonsterEncounterEvent)
            {
                MessageBox.Show("5 seconds to equip weapon or die.....");
            }
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}

