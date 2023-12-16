using MyClassLib_dll;
using System.Reflection;

namespace TestReflection_WinFormApp
{
    public partial class Form1 : Form
    {
        Type[] ts;
        MethodInfo[] mis;

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
                //    list_Classes.Items.Add(t);
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
            string x = list_Classes.SelectedItem.ToString();  //To get selected method name
            mis = ts.FirstOrDefault(t => t.FullName.Equals(x, StringComparison.OrdinalIgnoreCase)).GetMethods(); // to search for it in types by using LINQ
            foreach (MethodInfo mi in mis)
            {
                list_functions.Items.Add(mi.Name);
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //string x = list_Classes.SelectedItem.ToString();  //To get selected method name
            //object y = Activator.CreateInstance(ts.FirstOrDefault(t => t.FullName.Equals(x, StringComparison.OrdinalIgnoreCase)));
            mis[list_functions.SelectedIndex].Invoke(null, null);
        }
    }
}