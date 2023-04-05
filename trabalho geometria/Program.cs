Console.WriteLine($"qual o tamanho do lado 1 ?");
float lado1 = float.Parse( Console.ReadLine() );

Console.WriteLine($"qual o tamanho do lado 2 ?");
float lado2 = float.Parse( Console.ReadLine() );

Console.WriteLine($"qual o tamanho do lado 3 ?");
float lado3 = float.Parse( Console.ReadLine() );

if ((lado1 == lado2)||(lado2 == lado3) || (lado1 == lado3))
{
    Console.WriteLine($"Triângulo    Equilátero");
}

else if ((lado1 == lado2) || (lado2 == lado3) )
{
    Console.WriteLine($"Triângulo    Isóscele");
    
}
else
{
    Console.WriteLine($"Triângulo    Escaleno");
    
}
    