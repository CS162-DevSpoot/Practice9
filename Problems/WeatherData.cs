namespace CS162_Practice9.Problems
{

    struct Weather
    {
        public DateTime date;
        public decimal precipitation;
        public int highTemp;
        public int lowTemp;
    }
    public partial class WeatherData : Form
    {

        private Dictionary<string, Weather> weatherDictionary = new Dictionary<string, Weather>();
        public WeatherData()
        {
            InitializeComponent();
        }

        private void closeButton_Cliked(object sender, EventArgs e)
        {
            Close();
        }

        private void form_OnLoad(object sender, EventArgs e)
        {
            try
            {
                DateTime? lowestDate = null;
                DateTime? highestDate = null;

                StreamReader weatherFile = File.OpenText("weather.txt");

                while (!weatherFile.EndOfStream)
                {
                    //Date;Precipitation;HighTemp;LowTemp
                    string dataLine = weatherFile.ReadLine();
                    string[] data = dataLine.Split(";");

                    Weather currentWeather = new Weather { 
                        date = DateTime.Parse(data[0]),
                        precipitation = decimal.Parse(data[1]),
                        highTemp = int.Parse(data[2]),
                        lowTemp = int.Parse(data[3])
                    };

                    if(lowestDate == null || lowestDate > currentWeather.date)
                    {
                        lowestDate = currentWeather.date;
                    }

                    if(highestDate == null || highestDate < currentWeather.date) {
                        highestDate = currentWeather.date;
                    }

                    weatherDictionary[data[0]] = currentWeather;

                }

                weatherFile.Close();
                dateTimePicker.MinDate = (DateTime) lowestDate;
                dateTimePicker.MaxDate = (DateTime) highestDate;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Weather? getWeather()
        {
            try
            {
                string selectedDate = dateTimePicker.Value.ToString("d");

              
                return weatherDictionary[selectedDate];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void displayWeather(Weather weather)
        {
            try
            {
                dateLabel.Text = weather.date.ToString("d");
                precipitationLabel.Text = weather.precipitation.ToString("p");
                highTempLabel.Text = weather.highTemp.ToString();
                lowestTempLabel.Text = weather.lowTemp.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datetimePicker_Changed(object sender, EventArgs e)
        {
            Weather? selectedWeather = getWeather();

            if(selectedWeather == null) { MessageBox.Show("No data available for the selected date."); return; }
            displayWeather((Weather) selectedWeather);
        }
    }
}
