using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLib_dll;

namespace ReflectionsWinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //this program is used to get attribures data.
        private void btn_get_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_FileName.Text = openFileDialog1.FileName;
                Assembly a = Assembly.LoadFile(txt_FileName.Text);
                Module m = a.GetModules()[0];
                Type[] ts = m.GetTypes();
                foreach ( Type t in ts )
                {
                   Attribute[] atts = Attribute.GetCustomAttributes(t, typeof(HamadaAttribute));
                    foreach (Attribute att in atts)
                    {
                        HamadaAttribute ha = (HamadaAttribute)att;
                        if ( ha.Name == "Ali" )
                        {
                            rtxt_output.AppendText(t.Name);
                        }
                    }
                }
            }
        }
    }
}
