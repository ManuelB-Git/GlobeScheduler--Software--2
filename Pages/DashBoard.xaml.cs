
using GlobeScheduler___Software_2.Helpers;
using System.Windows.Controls;

namespace GlobeScheduler___Software_2
{
   
    public partial class DashBoard : Page
    {
        public DashBoard()
        {
            InitializeComponent();
            TimePopulate.Populate(TimeComboBox);
        }
    }
}
