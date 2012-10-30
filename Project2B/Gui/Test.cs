using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Project2B.Gui
{
    internal class Test : Panel
    {
        private uint time;
        private CountDown timerContainer;

        public Test(uint time)
        {
            this.time = time;
        }

        public Test Perform()
        {


            // create timer

            del callBack = this.End;

            this.timerContainer = new CountDown(0, 0, 5, callBack);
            this.timerContainer.AutoSize = true;
            this.timerContainer.BackColor = Color.White;
            this.timerContainer.Timer.Start();

            this.Controls.Add(this.timerContainer);

            return this;
        }

        public void End()
        {
            MessageBox.Show("CountDown Completed");
        }
    }
}