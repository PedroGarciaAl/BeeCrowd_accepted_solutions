double a,b,c,media,peso1,peso2,peso3;
peso1 = 2;
peso2 = 3;
peso3 = 5;

a = double.Parse(Console.ReadLine()) * peso1;
b = double.Parse(Console.ReadLine()) * peso2;
c = double.Parse(Console.ReadLine()) * peso3;

media = (a + b + c) / (peso1 + peso2 + peso3);

Console.WriteLine($"MEDIA = {Convert.ToDecimal(media).ToString("0.0")}");