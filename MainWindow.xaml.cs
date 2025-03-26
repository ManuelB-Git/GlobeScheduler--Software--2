using GlobeScheduler___Software_2.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace GlobeScheduler___Software_2
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new DashBoard();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                switch (menuItem.Header.ToString())
                {
                    case "Dashboard":
                        Main.Content = new DashBoard();
                        break;
                    case "Customers":
                        Main.Content = new Customers();
                        break;
                    case "Appointments":
                        Main.Content = new Appointments();
                        break;
                    case "Reports":
                        Main.Content = new Reports();
                        break;
                    default:
                        break;
                }
            }

            

        }

    
    }
}