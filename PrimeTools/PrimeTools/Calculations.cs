namespace PrimeTools;

public static class Calculations
{
    /// <summary>
    /// Calculates the greatest common divisor between two numbers using the Euclidean Algorithm.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int GCD(int a, int b, out string explanation)
    {
        if (a < b)
        {
            (a, b) = (b, a);
        }
        explanation = $"Solving gcd({a}, {b})\n \n";  // Initialize explanation string
        
        while (b != 0)  // Loop until b becomes 0
        {
            explanation += $"{a} = {b} * {a / b} + {a % b}\n";  // Show division and remainder

            a = a % b;  // Perform modulo operation
            (a, b) = (b, a);  // Swap a and b to continue the algorithm
        }

        explanation += "\n";
        explanation += $"So gcd is {a}";  // Final GCD value when b is 0
        return a;
    }


    /// <summary>
    /// Solves ax + by = gcd(a, b). Stores the x and y result in the
    /// variables x and y.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="x1"></param>
    /// <param name="y"></param>
    public static int LinearCombination(int a, int b, out int x, out int y, out string explanation)
    {
        explanation = "";
    
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        int x1, y1;
    
        // Recursive call
        int gcd = LinearCombination(b, a % b, out x1, out y1, out _);
    
        // Compute x and y
        x = y1;
        y = x1 - (a / b) * y1;

        // Append explanation details

        return gcd;
    }
    
    /// <summary>
    /// Calculates Eulers Totient of n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int EulersTotient(int n)
    {
        int result = n;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
                result -= result / i;
            }
        }

        if (n > 1)
        {
            result -= result / n;
        }

        return result;
    }


    /// <summary>
    /// Calculate the number of x s.t x = a(mod b) and x = c(mod d)
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="d"></param>
    /// <returns></returns>
    public static int CRT(int a, int b, int c, int d)
    {
        LinearCombination(b, d, out int bInverse, out _, out _);
        int z = (((c-a) * bInverse) % d + d) % d; // do extra modulus work to stay positive
        int x = a + (b * z);
        return (x % (b * d) + (b * d)) % (b * d);
    }

}