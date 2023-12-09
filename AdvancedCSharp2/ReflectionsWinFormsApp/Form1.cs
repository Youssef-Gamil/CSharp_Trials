using System.Reflection;

namespace ReflectionsWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_fileName.Text = openFileDialog1.FileName;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.LoadFile(txt_fileName.Text);
            Module m =a.GetModules()[0];
            Type[] t = m.GetTypes();
            foreach (Type item in t) 
            { 
                StreamWriter sw = File.CreateText(string.Format("{0}.cs", item.Name));
                if (item.IsClass)
                {
                    sw.Write("Class ");
                }
                else if (item.IsEnum)
                {
                    sw.Write("Enum ");
                }
                else
                {
                    sw.Write("Struct ");
                }
                sw.Write(item.Name);
                sw.WriteLine("()");
                sw.WriteLine("{");
                sw.WriteLine("}");



                sw.Close();
            }
        }
    }
}