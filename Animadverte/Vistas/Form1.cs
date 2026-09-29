namespace Animadverte
{
    public partial class Form1 : Form
    {
        //Start the aplication with a login form, if the user is logged in, the main form will be shown
        public Form1()
        {
            InitializeComponent();
        }
        //Login button for open or not the Main form
        private void button1_Click(object sender, EventArgs e)
        {
            //Main Form declaration
            Main mainForm = new Main();
            //varable to call "Login" metoth
            bool result = Login(UserNameTBox.Text, PasswordTBox.Text);
            //If the login is successful, the main form will be shown, if not, a message box will be shown
            if (result)
            {
               mainForm.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }
        private bool Login(string username, string password)
        {
            // Implement your login logic here
            // Return true for successful login, false for failed login
            if (username == "admin" && password == "password")
            {
                return true; // Successful login
            }
            else
            {
                return false; // Failed login
            }
        }
    }
}
