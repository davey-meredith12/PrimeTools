//using Org.Xml.Sax;

namespace PrimeTools;

public static class CreateTool
{
    public static Tool GcdTool()
    {
        var gcdTool = new Tool
        {
            Name = "GCD",
            Title = "Greatest Common Divisor",
            HowItWorks = "a = qb + r\n" + "gcd(a,b) = gcd(b,r)\n" + "Go until a,b are equal or until the remainder is 0",
            InputCount = 2,
            Result = "Result: ",
            Explanation = ""
        };

        for (int i = 0; i < gcdTool.InputCount; i++)
        {
            InputItem item = new InputItem();
            item.Value = "";
            gcdTool.Inputs.Add(item);
        }

        //add variable names
        gcdTool.Inputs[0].Label = "a";
        gcdTool.Inputs[1].Label = "b";

        gcdTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(gcdTool.Inputs[0].Value, out int a) &&
                int.TryParse(gcdTool.Inputs[1].Value, out int b) && a > 0 && b > 0)
            {
                double gcd = Calculations.GCD(a, b);
                gcdTool.Result = "Result: gcd(" + a + ", " + b + ") = " + gcd;
            }
            else
            {
                gcdTool.Result = "Invalid input. Please enter valid numbers.";
            }
        });

        gcdTool.ExplanationCommand = new Command(() =>
        {
            
        });
        
        return gcdTool;
    }

    public static Tool LinearCombinationTool()
    {
        var linearCombinationTool = new Tool
        {
            Name = "Linear Combination",
            Title = "Linear Combination",
            HowItWorks = "ax + by = d\n" + "Given a and b, solve for x and y\n" + "where d = gcd(a, b), i.e. where ax + by = gcd(a,b)",
            InputCount = 2,
            Result = "Result: ",
            Explanation = ""
        };
        
        for (int i = 0; i < linearCombinationTool.InputCount; i++)
        {
            InputItem item = new InputItem();
            item.Value = "";
            linearCombinationTool.Inputs.Add(item);
        }

        //add variable names
        linearCombinationTool.Inputs[0].Label = "a";
        linearCombinationTool.Inputs[1].Label = "b";
        
        
        linearCombinationTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(linearCombinationTool.Inputs[0].Value, out int a) &&
                int.TryParse(linearCombinationTool.Inputs[1].Value, out int b) && a > 0 && b > 0)
            {
                Calculations.LinearCombination(a, b, out int x, out int y);
                linearCombinationTool.Result = "Result: x = " + x + ", y = " + y;
            }
            else
            {
                linearCombinationTool.Result = "Invalid input. Please enter valid numbers.";
            }
        });

        linearCombinationTool.ExplanationCommand = new Command(() =>
        {
            
        });
        
        return linearCombinationTool;
    }
}