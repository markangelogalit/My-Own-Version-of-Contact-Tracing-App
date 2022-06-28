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
            StreamReader reader = new StreamReader(@"C:\Users\admin\Documents\Contact Tracing Info\test.txt");
            String all = reader.ReadToEnd();
            MessageBox.Show(all);   
         
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            string Date = tbx1.Text;
            int dateResults = 0;
            StreamReader sr = new StreamReader(@"C:\Users\admin\Documents\Contact Tracing Info\test.txt");
            while (!sr.EndOfStream) 
            {
                string contents = sr.ReadToEnd();
                if (contents.Contains(Date))
                {
                    dateResults++;
                    dates.Add(contents);
                }

            }
            if (dateResults == 0)
            {
                MessageBox.Show("No records found");
            }
            else
            {
                sr.Close(); 
                foreach (string contents in dates)
                {
                    MessageBox.Show(contents);
                }
            }
        }
    }
}
