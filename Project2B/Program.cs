using System;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;

namespace Project2B
{
    class Program
    {
		/// <summary>
		/// Main Method runs the program
		/// and enables visual styles
		/// main program is GUI
		/// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.Run(new GameGui());

            //var go = new GameRun();
            //go.GameStart();


        }
    }
}
