using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal interface IKey
    {
        T CheckKey<T>(out string key)
          where T : DocumentWorker, new();
    }
}
