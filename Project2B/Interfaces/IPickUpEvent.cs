using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Interfaces;

//interface IPickEvent forces the Pickup concrete implementation
//is implmented as IEvent
namespace Project2B
{
    public interface IPickUpEvent:IEvent
    {
        
    }
}
