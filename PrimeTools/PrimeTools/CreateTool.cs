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
            Input1 = "",
            Input2 = "",
            Result = "Result: ",
            Explanation = ""
        };

        gcdTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(gcdTool.Input1, out int a) &&
                int.TryParse(gcdTool.Input2, out int b) && a > 0 && b > 0)
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
            HowItWorks = "ax + by = d\n" + "Given a and b, solver for x and y\n" + "where d = gcd(a, b), i.e. where ax + by = gcd(a,b)",
            Input1 = "",
            Input2 = "",
            Result = "Result: ",
            Explanation = ""
        };
        
        linearCombinationTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(linearCombinationTool.Input1, out int a) &&
                int.TryParse(linearCombinationTool.Input2, out int b) && a > 0 && b > 0)
            {
                //(int x, int y) = Calculations.GCD(a, b);
                int x = 12;
                int y = 14;
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