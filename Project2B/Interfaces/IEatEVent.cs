using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Interfaces;

//interface IEatEvent to ensure the eat concrete implementation
//implements the Eat method
namespace Project2B
{
    public interface IEatEVent:IEvent
    {
        bool Eat(IItem item);

    }
}
