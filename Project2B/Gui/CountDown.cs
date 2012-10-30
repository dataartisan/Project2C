using System;
using System.Windows.Forms;

namespace Project2B
{
    public delegate void del();
    class CountDown : Label
    {
        private Timer timer;
        private int hours;
        private int minutes;
        private int seconds;
        private del callBack;

        public CountDown(int hours, int minutes, int seconds, del callBack)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.SetText();

            this.callBack = callBack;

            this.timer = new Timer();
            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.seconds--;
            if (this.seconds < 0)
            {
                this.seconds = 59;
                this.minutes--;
                if (this.minutes < 0)
                {
                    this.minutes = 59;
                    this.hours--;
                    if (this.hours < 0)
                    {
                        this.hours = 0;
                        this.minutes = 0;
                        this.seconds = 0;

                        // remove event handler
                        this.timer.Tick -= new EventHandler(TimerTick);

                        // call CountDown exit
                        this.exit();
                    }
                }
            }

            this.SetText();
        }

        private void exit()
        {
            this.SetText();

            this.timer.Stop();
            this.timer.Dispose();

            // call callBack function if set
            if (this.callBack != null)
                this.callBack();
        }

        private void SetText()
        {
            this.Text = (this.hours.ToString()).PadLeft(2, '0') + ":" +
                  (this.minutes.ToString()).PadLeft(2, '0') + ":" +
                  (this.seconds.ToString()).PadLeft(2, '0');
        }

        public Timer Timer
        {
            get { return this.timer; }
        }

    }
}
