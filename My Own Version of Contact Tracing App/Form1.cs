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
            StreamWriter file = new StreamWriter(@"C:\Users\admin\Documents\Contact Tracing Info\test.txt", true);
            file.WriteLine("First Name: " + tbx1name.Text);
            file.WriteLine("Middle Name: " + tbx2name.Text);    
            file.WriteLine("Last Name: " + tbx3name.Text);
            file.WriteLine("Age: " + tbx4age.Text);
            file.WriteLine("Birth Date: " + tbx5bdate.Text);    
            file.WriteLine("Contact Number: " + tbx6number.Text);
            file.WriteLine("Email: " + tbx7email.Text);
            file.WriteLine("Temperature: " + tbxtemp8.Text);
            file.WriteLine("Current Address: " + tbx9address.Text);
            file.WriteLine("Time-In: " + tbx10in.Text);
            file.WriteLine("Time-Out: " + tbx11out.Text);
            file.WriteLine("Last Place Visited: " + tbx12visited.Text);
            file.WriteLine("Question1: " + tbx13expe.Text);
            file.WriteLine("Question2: " + tbx14colleagues.Text);
            file.WriteLine("Question3: " + tbx15city.Text);
            file.WriteLine("Date: " + tbx16date.Text);
            file.Close();




        }

        private void bnt2vi_Click(object sender, EventArgs e)
        {
         
          
            Form2 f2 = new Form2();
            f2.ShowDialog();    
        }

        private void bnt3qr_Click(object sender, EventArgs e)
        {
            
        }
    }
}