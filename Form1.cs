namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text + " - " + comboBox2.Text + " Date: " + dateTimePicker1.Text + " Time: " + maskedTextBox1.Text + " Passenger Information: " + textBox1.Text + " TC: " + maskedTextBox3.Text + " Phone Number: " + maskedTextBox4.Text);
            MessageBox.Show("Passenger Registered.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
            
        }
    }
}
