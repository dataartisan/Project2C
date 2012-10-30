using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface iitem is being implemented by abstract item classes
//in the class hierarchy so that each corresponding item has a name.
//this interface also ensures that the underlying classes implement the ICarriable, and 
//IEdible.
namespace Project2B
{
    public interface IItem:ICarriable,IEdible,IWeight
    {
        string Name { get; }

    }
}
