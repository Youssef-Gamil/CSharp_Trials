using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_lambdaConsoleApp
{
    internal class MyList<T>:List<T>
    {
        public List<T> Find(Func<T, bool> abc)
        {
            List<T> list = new List<T>();
            foreach (T item in this)
            {
                if(abc(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
