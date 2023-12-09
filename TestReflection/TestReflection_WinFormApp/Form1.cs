using MyClassLib_dll;
using System.Reflection;

namespace TestReflection_WinFormApp
{
    public partial class Form1 : Form
    {
        Type[] ts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_FileName.Clear();
                list_Classes.Items.Clear();
                txt_FileName.Text = openFileDialog1.FileName;
                //dll file
                Assembly a = Assembly.LoadFile(openFileDialog1.FileName);
                //module
                Module m = a.GetModules()[0];
                //type = class
                ts = m.GetTypes();
                foreach (Type t in ts)
                {
                    //Attribute att = Attribute.GetCustomAttribute(t,typeof(HamadaAttribute));
                    // if (t.IsClass && !t.Name.EndsWith("Attribute") && !t.Name.StartsWith("<>"))
                    if (Attribute.IsDefined(t, typeof(HamadaAttribute)))
                    {
                        list_Classes.Items.Add(t);
                    }
                }
            }
        }

        private void list_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_functions.Items.Clear();
            //method = function
            MethodInfo[] mis = ts[list_Classes.SelectedIndex].GetMethods();
            foreach (MethodInfo mi in mis)
            {
                list_functions.Items.Add(mi.Name);
            }
        }
    }
}