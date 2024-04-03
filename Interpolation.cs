namespace Lab5;

public static class Interpolation
{
    public static List<List<double>> Difference(List<double> x, List<double> f)
    {
        var diff = new List<List<double>> { x, f };

        for (int i = 2; i < x.Count + 1; i++)
        {
            var d = new List<double>();

            for (int j = 0; j < diff[i - 1].Count - 1; j++)
            {
                Console.WriteLine(x[j + 1] - x[j]);
                d.Add((diff[i - 1][j + 1] - diff[i - 1][j]) / (x[j + 1] - x[j]));
            }

            diff.Add(d);
        }

        return diff;
    }
}