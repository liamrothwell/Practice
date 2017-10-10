using System;

public class Car
{

    public string Name { get; set; }
    public decimal Mpg { get; set; }
    public decimal FuelCost { get; set; }
    public decimal Tax { get; set; }
    public decimal Insurance { get; set; }
    public decimal Monthly { get; set; }

    public decimal CalculateWeeklyCost()
    {
        decimal gallonsRequired = (decimal)milesPerWeek.Value / Car.Mpg;

        decimal fuelCostInGallons = (Car.FuelCost / 100) * (decimal)4.55;

        return (fuelCostInGallons * gallonsRequired) + (Car.Insurance / 52) + (Car.Tax / 52) + (Car.Monthly / 4);

    }

    public Tuple<string, string, string> addCostToString(decimal cost)
    {
        string Weekly = "Will cost £" + String.Format("{0:0.00}", cost) + " Per Week.";
        string Monthly = "Will cost £" + String.Format("{0:0.00}", cost * 4) + " Per Month.";
        string Yearly = "Will cost £" + String.Format("{0:0.00}", cost * 52) + " Per Year.";

        return new Tuple<String, String, String>(Weekly, Monthly, Yearly);
    }

    public Tuple<string, string> CompareCost(decimal firstCar, decimal secondCar)
    {
        decimal result = firstCar - secondCar;
        string nextCarName = "";

        foreach (var car in )
        {
            
        }

        if (nextCar == 1)
        {
            nextCarName = Car1Name.Text;
        }
        else if (nextCar == 2)
        {
            nextCarName = Car2Name.Text;
        }
        else if (nextCar == 3)
        {
            nextCarName = Car3Name.Text;
        }

        if (result < 0)
        {
            decimal result1 = result * -1;
            return "£" + String.Format("{0:0.00}", result1 * 52) + " less than " + nextCarName + " per Year.";
        }
        if (result > 0)
        {
            return "£" + String.Format("{0:0.00}", result * 52) + " more than " + nextCarName + " per Year.";
        }

        return "Will cost the same as " + nextCarName + ".";
    }
}

