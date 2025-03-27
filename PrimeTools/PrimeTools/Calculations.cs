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
}