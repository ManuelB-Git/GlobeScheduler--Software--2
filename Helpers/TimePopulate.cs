
namespace GlobeScheduler___Software_2.Helpers
{
    public static class TimePopulate
    {
        public static void Populate(System.Windows.Controls.ComboBox comboBox)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30)
                {
                    DateTime time = new(1, 1, 1, hour, minute, 0);
                    string timeString = time.ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                    comboBox.Items.Add(timeString);
                }
            }
        }
    }
}
