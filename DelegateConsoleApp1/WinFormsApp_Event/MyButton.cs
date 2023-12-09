using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Event
{
    internal class MyButton:Button
    {
        protected override void OnClick(EventArgs e) //function
        {
              base.OnClick(e);
          //  MessageBox.Show("On Click");
        }
    }
}
