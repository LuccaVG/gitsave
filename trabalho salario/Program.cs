Console.WriteLine($"Qual o seu salário ?");
float salario = float.Parse( Console.ReadLine() );

Console.WriteLine($"Quanto você gastou neste mês ?");
float gasto = float.Parse( Console.ReadLine() );

if ( salario > gasto )
{
 Console.WriteLine($"Você está dentro do orçamento.");
}
else
{
Console.WriteLine($"Você estorou o orçamento.");

}