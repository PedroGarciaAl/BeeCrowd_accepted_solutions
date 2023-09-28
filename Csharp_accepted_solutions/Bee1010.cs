int codigoPeca1,codigoPeca2, numeroPecas1, numeroPecas2;
double valorPeca1, valorPeca2, valorTotal;

string [] valores = Console.ReadLine().Split(' ');
codigoPeca1 = int.Parse(valores[0]);
numeroPecas1 = int.Parse(valores[1]);
valorPeca1 = double.Parse(valores[2]);

valores = Console.ReadLine().Split(' ');
codigoPeca2 = int.Parse(valores[0]);
numeroPecas2 = int.Parse(valores[1]);
valorPeca2 = double.Parse(valores[2]);

valorTotal = (numeroPecas1 * valorPeca1)+(numeroPecas2 * valorPeca2);
Console.WriteLine($"VALOR A PAGAR: R$ {Convert.ToDecimal(valorTotal).ToString("0.00")}");