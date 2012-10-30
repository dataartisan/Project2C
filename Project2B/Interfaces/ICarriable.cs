using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//contract to force object to make sure they are marked as carriable or not
namespace Project2B
{
    public interface ICarriable
    {
        bool Carriable { get; }
    
    }
}
