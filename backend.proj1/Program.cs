Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Programa para Calcular IMC ");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome}");
Console.WriteLine($"Informe o peso do paciente:");
float peso = float.Parse(Console.ReadLine());

// só exemplo
// Console.WriteLine($"Informe a altura do paciente:");
// double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"O paciente {nome} tem imc igual á: {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por ultilizar nosso sistema !");
Console.ResetColor();
