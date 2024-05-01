using Lab5;

var x = new List<decimal>();

decimal h = new decimal(.1);

for (int i = 0; i < 10; i++) x.Add(new decimal((double)(i * h)));

var f = new List<decimal>{ new decimal(.00000), new decimal(.09983), new decimal(.19866), new decimal(.29552), new decimal(.38941), new decimal(.47942), new decimal(.56464), new decimal(.64421), new decimal(.71735), new decimal(.78332) };

var p = new List<decimal>{ new decimal(.226), new decimal(.431), new decimal(.669) };

var diff = Interpolation.Difference(x, f);
int n = diff.Count;

Console.WriteLine("Table of differences:");
foreach (var col in diff)
{
    foreach (var row in col)
    {
        Console.Write($"{row:00.00000} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nInterpolation forward:");

foreach (var value in p)
{
    var forward = Interpolation.InterpolationForward(diff, value, x[0], h);

    Console.WriteLine($"{value}: {forward:00.00000}");
}

Console.WriteLine("\nInterpolation backwards:");

foreach (var value in p)
{
    var backward = Interpolation.InterpolationBackward(diff, value, x[n - 2], h);

    Console.WriteLine($"{value}: {backward:00.00000}");
}

