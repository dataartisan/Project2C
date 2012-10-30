using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface GetRecordLog ensures that class implementing
//this interface - the ones which records the log
//implement this method.
namespace Project2B
{
    public interface IRecord
    {

        string GetRecordLog();

    }
}
