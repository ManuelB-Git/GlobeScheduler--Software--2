using GlobeScheduler___Software_2.Helpers;
using System.Windows.Controls;


namespace GlobeScheduler___Software_2.Pages
{
  
    public partial class Appointments : Page
    {
        public Appointments()
        {
            InitializeComponent();
            TimePopulate.Populate(TimeComboBox);
        }
    }
}
