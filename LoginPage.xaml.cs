using System.Windows;
using System.Windows.Forms;


namespace GlobeScheduler___Software_2
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Username_Text.Text == "Test" && Password_Text.Password == "Test")
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
            else
            {
                
                new GlobeMessageBox("Invalid Username or Password").ShowDialog();

            }
        }
    }
}