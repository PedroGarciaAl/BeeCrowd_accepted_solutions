double area, raio, pi;
pi = 3.14159;

raio = double.Parse(Console.ReadLine());

area = Math.Round(pi * (Math.Pow(raio,2)),4);

Console.WriteLine($"A={Convert.ToDecimal(area).ToString("0.0000")}");