int numeroFuncionario, horasTrabalhadas;
double valorPorHora, salarioFuncionario;

numeroFuncionario = Convert.ToInt32(Console.ReadLine());
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
valorPorHora = double.Parse(Console.ReadLine());

salarioFuncionario = horasTrabalhadas * valorPorHora;


Console.WriteLine($"NUMBER = {numeroFuncionario}");
Console.WriteLine($"SALARY = U$ {Convert.ToDecimal(salarioFuncionario).ToString("0.00")}");