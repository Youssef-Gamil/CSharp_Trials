using MyClassLib_dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    [Hamada(8,"Admin")]
    public class ABC
    {
        public void SayHi()
        {
            Console.WriteLine("HI");
        }
    }
}
