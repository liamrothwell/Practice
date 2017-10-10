using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MPG_comparison
{
    public partial class MpgComparison : Form
    {
        private readonly List<Car> _cars = new List<Car>();

        public MpgComparison()
        {
            InitializeComponent();
            HideAllText();
        }

        private void HideAllText()
        {
            car1PerWeek.Text = "";
            car1PerMonth.Text = "";
            car1PerYear.Text = "";
            car2PerMonth.Text = "";
            car2PerWeek.Text = "";
            car2PerYear.Text = "";
            car3PerMonth.Text = "";
            car3PerWeek.Text = "";
            car3PerYear.Text = "";
            Car1CompareCar2.Text = "";
            Car1CompareCar3.Text = "";
            Car2CompareCar1.Text = "";
            Car2CompareCar3.Text = "";
            Car3CompareCar1.Text = "";
            Car3CompareCar2.Text = "";
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void label35_Click(object sender, EventArgs e)
        {
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void AddCarsToList()
        {
            if (Car1FuelCost.Text != string.Empty && Car1Insurance.Text != string.Empty &&
                Car1MPG.Text != string.Empty && Car1Tax.Text != string.Empty && Car1Name.Text != string.Empty &&
                Car1Tax.Text != string.Empty && milesPerWeek.Text != string.Empty)
            {
                var car1 = new Car()
                {
                    Name = Car1Name.Text,
                    Mpg = Car1MPG.Value,
                    MilesPerWeek = milesPerWeek.Value,
                    FuelCost = Car1FuelCost.Value,
                    Tax = Car1Tax.Value,
                    Insurance = Car1Insurance.Value,
                    Monthly = Car1Monthly.Value
                };
                _cars.Add(car1);
            }
            
            if (Car2FuelCost.Text != string.Empty && Car2Insurance.Text != string.Empty &&
                Car2MPG.Text != string.Empty && Car2Tax.Text != string.Empty && Car2Name.Text != string.Empty &&
                Car2Tax.Text != string.Empty && milesPerWeek.Text != string.Empty)
            {
                var car2 = new Car()
                {
                    Name = Car2Name.Text,
                    Mpg = Car2MPG.Value,
                    MilesPerWeek = milesPerWeek.Value,
                    FuelCost = Car2FuelCost.Value,
                    Tax = Car2Tax.Value,
                    Insurance = Car2Insurance.Value,
                    Monthly = Car2Monthly.Value
                };
                _cars.Add(car2);

            }
            
            if (Car3FuelCost.Text != string.Empty && Car3Insurance.Text != string.Empty &&
                Car3MPG.Text != string.Empty && Car3Tax.Text != string.Empty && Car3Name.Text != string.Empty &&
                Car3Tax.Text != string.Empty && milesPerWeek.Text != string.Empty)
            {
                var car3 = new Car()
                {
                    Name = Car3Name.Text,
                    Mpg = Car3MPG.Value,
                    MilesPerWeek = milesPerWeek.Value,
                    FuelCost = Car3FuelCost.Value,
                    Tax = Car3Tax.Value,
                    Insurance = Car3Insurance.Value,
                    Monthly = Car3Monthly.Value
                };
                _cars.Add(car3);

            }

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            _cars.Clear();
            AddCarsToList();

            var car1 = _cars.ElementAtOrDefault(0) != null ? _cars[0] : null;
            var car2 = _cars.ElementAtOrDefault(1) != null ? _cars[1] : null;
            var car3 = _cars.ElementAtOrDefault(2) != null ? _cars[2] : null;

            if (car1 != null)
            {
                car1PerWeek.Text = car1.AddCostToString(car1.CalculateWeeklyCost()).Item1;
                car1PerMonth.Text = car1.AddCostToString(car1.CalculateWeeklyCost()).Item2;
                car1PerYear.Text = car1.AddCostToString(car1.CalculateWeeklyCost()).Item3;
            }

            if (car2 != null)
            {
                car2PerWeek.Text = car2.AddCostToString(car2.CalculateWeeklyCost()).Item1;
                car2PerMonth.Text = car2.AddCostToString(car2.CalculateWeeklyCost()).Item2;
                car2PerYear.Text = car2.AddCostToString(car2.CalculateWeeklyCost()).Item3;
                if (car1 != null) Car1CompareCar2.Text = car1.CompareCost(car1, _cars)[0];
                if (car1 != null) Car2CompareCar1.Text = car2.CompareCost(car2, _cars)[0];
            }

            if (car3 == null) return;
            car3PerWeek.Text = car3.AddCostToString(car3.CalculateWeeklyCost()).Item1;
            car3PerMonth.Text = car3.AddCostToString(car3.CalculateWeeklyCost()).Item2;
            car3PerYear.Text = car3.AddCostToString(car3.CalculateWeeklyCost()).Item3;
            if (car1 != null) Car1CompareCar3.Text = car1.CompareCost(car1, _cars)[1];
            if (car2 != null) Car2CompareCar3.Text = car2.CompareCost(car2, _cars)[1];
            if (car1 != null) Car3CompareCar1.Text = car3.CompareCost(car3, _cars)[0];
            if (car2 != null) Car3CompareCar2.Text = car3.CompareCost(car3, _cars)[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Car1CompareCar2_Click(object sender, EventArgs e)
        {
        }

        private void milesPerWeek_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}