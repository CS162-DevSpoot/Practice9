namespace CS162_Practice9.Problems
{
    struct sodaDrink
    {
        public int IDENT;
        public decimal price;
        public int invetory;
    }
    public partial class VendingMachine : Form
    {
        public VendingMachine()
        {
            InitializeComponent();
        }

        private sodaDrink[] sodas = new sodaDrink[4];

        private decimal totalSales = 0m;

        private void form_OnLoad(object sender, EventArgs e)
        {
            sodas[0] = new sodaDrink
            {
                IDENT = 0,
                price = 1.0m,
                invetory = 20
            };

            sodas[1] = new sodaDrink
            {
                IDENT = 1,
                price = 1.25m,
                invetory = 20
            };

            sodas[2] = new sodaDrink
            {
                IDENT = 2,
                price = 1.50m,
                invetory = 20
            };

            sodas[3] = new sodaDrink
            {
                IDENT = 3,
                price = 1.75m,
                invetory = 20
            };
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pepsiClicked(object sender, EventArgs e)
        {
            if (sodas[0].invetory == 0) { MessageBox.Show("Out of Stock."); return; }
            totalSales += sodas[0].price;
            sodas[0].invetory -= 1;

            totalSalesLabel.Text = totalSales.ToString("c");
            inventory1Label.Text = sodas[0].invetory.ToString();
        }

        private void drPepperClicked(object sender, EventArgs e)
        {
            if (sodas[1].invetory == 0) { MessageBox.Show("Out of Stock."); return; }
            totalSales += sodas[1].price;
            sodas[1].invetory -= 1;

            totalSalesLabel.Text = totalSales.ToString("c");
            inventory2Label.Text = sodas[1].invetory.ToString();
        }

        private void rootbeerClicked(object sender, EventArgs e)
        {
            if (sodas[2].invetory == 0) { MessageBox.Show("Out of Stock."); return; }
            totalSales += sodas[2].price;
            sodas[2].invetory -= 1;

            totalSalesLabel.Text = totalSales.ToString("c");
            inventory3Label.Text = sodas[2].invetory.ToString();
        }

        private void cokeClicked(object sender, EventArgs e)
        {
            if (sodas[3].invetory == 0) { MessageBox.Show("Out of Stock."); return; }
            totalSales += sodas[3].price;
            sodas[3].invetory -= 1;

            totalSalesLabel.Text = totalSales.ToString("c");
            inventory4Label.Text = sodas[3].invetory.ToString();
        }
    }
}
