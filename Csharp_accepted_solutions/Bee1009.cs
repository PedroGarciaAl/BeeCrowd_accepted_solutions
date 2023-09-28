double salarioFixo, vendasTotal, salarioTotal, comissao;
string nomeVendedor;

comissao = 15/100;

nomeVendedor = Console.ReadLine();
salarioFixo = double.Parse(Console.ReadLine());
vendasTotal = double.Parse(Console.ReadLine());

vendasTotal *=  comissao;
salarioTotal = salarioFixo + vendasTotal;

Console.WriteLine($"TOTAL = R$ {Convert.ToDecimal(salarioTotal).ToString("0.00")}");