using System;
using System.Collections.Generic;

public class Car
{
    public string Name { get; set; }
    public decimal Mpg { get; set; }
    public decimal MilesPerWeek { get; set; }
    public decimal FuelCost { get; set; }
    public decimal Tax { get; set; }
    public decimal Insurance { get; set; }
    public decimal Monthly { get; set; }

    public decimal CalculateWeeklyCost()
    {
        var gallonsRequired = MilesPerWeek / Mpg;

        var fuelCostInGallons = (FuelCost / 100) * (decimal)4.55;

        var result = (fuelCostInGallons * gallonsRequired);

        if (Insurance != 0)
        {
            result = result + (Insurance / 52);
        }

        if (Tax != 0)
        {
            result = result + (Tax / 52);
        }

        if (Monthly != 0)
        {
            result = result + ((Monthly * 12) / 52);
        }

        return result;

    }

    public Tuple<string, string, string> AddCostToString(decimal cost)
    {
        var weekly = "Will cost £" + $"{cost:0.00}" + " Per Week.";
        var monthly = "Will cost £" + $"{cost * 4:0.00}" + " Per Month.";
        var yearly = "Will cost £" + $"{cost * 52:0.00}" + " Per Year.";

        return new Tuple<string, string, string>(weekly, monthly, yearly);
    }

    public List<string> CompareCost(Car currentCar, List<Car> cars)
    {
        var comparisons = new List<string>();

        foreach (var secondcar in cars)
        {
            if (secondcar == this) continue;
            var result = currentCar.CalculateWeeklyCost()*52 - secondcar.CalculateWeeklyCost()*52;
            if (result < 0)
            {
                var result1 = result * -1;
                comparisons.Add("£" + $"{result1:0.00}" + " less than " + secondcar.Name + " per Year.\n");
            }
            if (result > 0)
            {
                comparisons.Add("£" + $"{result:0.00}" + " more than " + secondcar.Name + " per Year.\n");
            }
            if (result == 0)
            {
                comparisons.Add("Will cost the same as " + secondcar.Name + ".\n");

            }
        }

        return comparisons;
    }
}

