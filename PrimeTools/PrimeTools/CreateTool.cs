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
                double gcd = Calculations.GCD(a, b, out string explanation);
                gcdTool.Explanation = explanation;
                gcdTool.Result = "Result: gcd(" + a + ", " + b + ") = " + gcd;
            }
            else
            {
                gcdTool.Result = "Invalid input. Please enter valid numbers.";
                gcdTool.Explanation = "";
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
                Calculations.LinearCombination(a, b, out int x, out int y, out string explanation);
                linearCombinationTool.Result = "Result: x = " + x + ", y = " + y;
                linearCombinationTool.Explanation = explanation;
            }
            else
            {
                linearCombinationTool.Result = "Invalid input. Please enter valid numbers.";
                linearCombinationTool.Explanation = "";
            }
        });

        linearCombinationTool.ExplanationCommand = new Command(() =>
        {
            
        });
        
        return linearCombinationTool;
    }
    
    public static Tool EulersTotientTool()
    {
        var EulersTotientTool = new Tool
        {
            Name = "φ(n)",
            Title = "Eulers Totient: φ(n)",
            HowItWorks = "Explanation here",
            InputCount = 1,
            Result = "Result: ",
            Explanation = ""
        };

        for (int i = 0; i < EulersTotientTool.InputCount; i++)
        {
            InputItem item = new InputItem();
            item.Value = "";
            EulersTotientTool.Inputs.Add(item);
        }

        //add variable names
        EulersTotientTool.Inputs[0].Label = "n";

        EulersTotientTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(EulersTotientTool.Inputs[0].Value, out int n))
            {
                int result = Calculations.EulersTotient(n);
                EulersTotientTool.Result = "Result: " + result;
            }
            else
            {
                EulersTotientTool.Result = "Invalid input. Please enter valid numbers.";
            }
        });

        EulersTotientTool.ExplanationCommand = new Command(() => { });

        return EulersTotientTool;
    }
    
    public static Tool CrtTool()
    {
        var crtTool = new Tool
        {
            Name = "CRT",
            Title = "Chinese Remainder Theorem",
            HowItWorks = "Explanation here",
            InputCount = 4,
            Result = "Result: ",
            Explanation = ""
        };

        for (int i = 0; i < crtTool.InputCount; i++)
        {
            InputItem item = new InputItem();
            item.Value = "";
            crtTool.Inputs.Add(item);
        }

        //add variable names
        crtTool.Inputs[0].Label = "a";
        crtTool.Inputs[1].Label = "b";
        crtTool.Inputs[2].Label = "c";
        crtTool.Inputs[3].Label = "d";

        crtTool.ComputeCommand = new Command(() =>
        {
            if (int.TryParse(crtTool.Inputs[0].Value, out int a) &&
                int.TryParse(crtTool.Inputs[1].Value, out int b) &&
                int.TryParse(crtTool.Inputs[2].Value, out int c) &&
                int.TryParse(crtTool.Inputs[3].Value, out int d) &&
                a >= 0 && b > 0 && c >= 0 && d > 0)
            {
                if (Calculations.GCD(b, d, out _) != 1)
                {
                    crtTool.Result = "b and d are not coprime, cannot compute.";
                }
                else
                {
                    int result = Calculations.CRT(a,b,c,d);
                    crtTool.Result = "Result: " + result;
                }
                
                
            }
            else
            {
                crtTool.Result = "Invalid input. Please enter valid numbers.";
            }
        });

        crtTool.ExplanationCommand = new Command(() => { });

        return crtTool;
    }
    
    
    
}