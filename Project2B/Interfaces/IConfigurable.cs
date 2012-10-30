using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface contract to ensure that certain objects are configured
//turns on/off
namespace Project2B
{
    public interface IConfigurable
    {
        bool IsConfigurable { get; }
        bool On { get; set; }
        bool Off { get; set; }
    }

}