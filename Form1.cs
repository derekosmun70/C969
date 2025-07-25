using System.Globalization;

namespace C969_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            string cultureName = CultureInfo.CurrentCulture.Name;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userName.Text == "admin" && passWord.Text == "password")
            {
                MessageBox.Show("Login successful!");
                // Here you can add code to open the main application window
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again."); 
            }
    }
}}
