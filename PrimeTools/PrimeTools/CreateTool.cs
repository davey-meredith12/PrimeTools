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
}