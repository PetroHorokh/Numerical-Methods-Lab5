using Lab5;

var x = new List<double>();

var h = .1;

for (int i = 0; i < 10; i++) x.Add(i * h);

var f = new List<double>{ .00000, .09983, .19866, .29552, .38941, .47942, .56464, .64421, .71735, .78332 };

var p = new List<double>{ .226, .431, .669 };

var diff = Interpolation.Difference(x, f);

Console.WriteLine("\n");