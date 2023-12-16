using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib_dll;

namespace MyClasses
{
    [Hamada(8,"Admin")]
    public class ABC
    {
        public static void SayHi()
        {
            MessageBox.Show("HI");
        }
    }
}
