using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface ISwitable creates a contract that the item is switchable
//or not. such as flash light
namespace Project2B
{
    interface ISwitchable
    {

        bool IsSwitchAble { get; }
    }
}
