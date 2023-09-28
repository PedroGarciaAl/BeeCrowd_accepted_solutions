double a,b,media,peso1,peso2;
peso1 = 3.5;
peso2 = 7.5;

a = double.Parse(Console.ReadLine()) * peso1;
b = double.Parse(Console.ReadLine()) * peso2;

media = (a + b) / (peso1+peso2);

Console.WriteLine($"MEDIA = {Convert.ToDecimal(media).ToString("0.00000")}");