namespace PrimeTools;

public static class Calculations
{
    /// <summary>
    /// Calculates the greatest common divisor between two numbers using the Euclidean Algorithm.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int GCD(int a, int b)
    {
        while (a != b)
        {
            //make a the larger one
            if (a < b)
            {
                (a, b) = (b, a);
            }

            int newA = b;
            int newB = a - b;
            a = newA;
            b = newB;
        }

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
    public static int LinearCombination(int a, int b, out int x, out int y)
    {
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        int x1, y1;
        int gcd = LinearCombination(b, a%b, out x1, out y1);
        x = y1;
        y = x1 - (a / b) * y1;

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

}