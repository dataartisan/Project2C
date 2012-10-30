using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//class implements ICommand and allows us to exit the game.
namespace Project2B
{
    class ExitGameCommand:ICommand
    {
        private ExitGame _exitGame;
        /// <summary>
		/// Constructor
		/// </summary>
        public ExitGameCommand(ExitGame exitGame)
        {
            _exitGame = exitGame;
        }
		
		/// <summary>
		/// Allows exitting the game.
		/// </summary>
        public void Execute()
        {
            _exitGame.ExitApp();
        }

        
    }
}
