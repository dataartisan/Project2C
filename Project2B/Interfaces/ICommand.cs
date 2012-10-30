using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    public interface ICommand
    {
        void Execute();
        //public abstract void Undo(); we will include this later
    }
}
