using System.Windows;


namespace GlobeScheduler___Software_2
{
   
    public partial class GlobeMessageBox : Window
    {
        public GlobeMessageBox(string message)
        {
            InitializeComponent();
            MessageLabel.Content = message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
