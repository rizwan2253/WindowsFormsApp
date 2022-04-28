using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
   public abstract class DataLayer
    {
        public abstract bool Insert(string sp, string sparam, int iparam);
    }
}
