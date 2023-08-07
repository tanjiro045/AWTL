namespace CalculateAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentDate = dateTimePicker1.Value.Year;
            int birthDate = dateTimePicker2.Value.Year;
            int age = (int)(currentDate - birthDate);
            label3.Text = "Age in years: " + age.ToString();
        }
    }
}