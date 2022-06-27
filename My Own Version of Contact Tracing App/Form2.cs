using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Own_Version_of_Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@": \Users\admin\Documents\Contact Tracing Info");
            String all = reader.ReadToEnd();    
            MessageBox.Show(all);   
        }
    }
}
