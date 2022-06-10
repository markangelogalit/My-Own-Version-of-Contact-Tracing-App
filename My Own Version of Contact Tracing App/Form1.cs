namespace My_Own_Version_of_Contact_Tracing_App
{
    public partial class CTA1 : Form
    {
        public CTA1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CTA1_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1name_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bnt1save_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\admin\Documents\Contact Tracing Info\test.txt");
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("Middle Name: " + tbx2name.Text);    
            file.WriteLine("Last Name: " + tbx3name.Text);
            file.WriteLine("Age: " + tbx4age.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("First Name: " + tbx1name.Text);
        }
    }
}