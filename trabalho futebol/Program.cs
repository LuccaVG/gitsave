Console.WriteLine($"Inserir gols do time 1");
float time1 = float.Parse( Console.ReadLine() );


Console.WriteLine($"Inserir gols do time 2");
float time2 = float.Parse( Console.ReadLine() );

if (time1 > time2)
{
   Console.WriteLine($"O time 1 ganhou a partida");
    
}
else
{
   Console.WriteLine($" O time 2 ganhou a partida");
   
}

if (time1 == time2)
{
    Console.WriteLine($"Empate, não há vencedores.");
}