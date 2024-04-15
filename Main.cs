using CS162_Practice9.Problems;

namespace CS162_Practice9
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void weatherDataButton_Click(object sender, EventArgs e)
        {
            Form weatherDataForm = new WeatherData();
            weatherDataForm.Show();
        }

        private void vendingMachineButton_Click(object sender, EventArgs e)
        {
            Form VendingMachine = new VendingMachine();
            VendingMachine.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
