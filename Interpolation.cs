namespace Lab5;

public static class Interpolation
{
    public static List<List<decimal>> Difference(List<decimal> x, List<decimal> f)
    {
        var diff = new List<List<decimal>> { x, f };

        for (int i = 2; i < x.Count + 1; i++)
        {
            var d = new List<decimal>();

            for (int j = 0; j < diff[i - 1].Count - 1; j++)
            {
                d.Add((diff[i - 1][j + 1] - diff[i - 1][j]));
            }

            diff.Add(d);
        }

        return diff;
    }

    public static decimal InterpolationForward(List<List<decimal>> diff, decimal x0, decimal x, decimal h)
    {
        decimal q = (x0 - x) / h;
        decimal a = 1;
        decimal L = diff[1][0];
        for (int i = 2; i < diff.Count; i++)
        {
            a *= (q - i + 2) * h;
            L += a * diff[i][0];
        }

        return L;
    }

    public static decimal InterpolationBackward(List<List<decimal>> diff, decimal x0, decimal xn, decimal h)
    {
        decimal q = (x0 - xn) / h;
        decimal a = 1;
        int n = diff[1].Count;
        decimal L = diff[1][n-1];
        for (int i = 2; i < diff.Count; i++)
        {
            a *= (q + i - 2) * h;
            n = diff[i].Count;
            L += a * diff[i][n-1];
        }

        return L;
    }
}