Console.WriteLine($"Insira a senha");

int senha = int.Parse(Console.ReadLine());

if ( senha == 1234 )
{
    Console.WriteLine($"acesso permitido");
    
}
else
{
    Console.WriteLine($"acesso negado");
    
}
