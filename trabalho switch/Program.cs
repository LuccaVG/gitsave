Console.WriteLine($"escolha a sua bebida");
Console.WriteLine($"digite 1 para Coca Cola com gelo");
Console.WriteLine($"digite 2 para Coca Cola sem gelo");
Console.WriteLine($"digite 3 para Guaraná Antartica com gelo");
Console.WriteLine($"digite 4 para Guaraná Antartica sem gelo");
Console.WriteLine($"digite 5 para Sprite com gelo");
Console.WriteLine($"digite 6 para Sprite sem gelo");
Console.WriteLine($"digite 7 para Suco de Laranja com gelo");
Console.WriteLine($"digite 8 para Suco de Laranja sem gelo");



int opçoes = int.Parse(Console.ReadLine());

switch (opçoes)
{
    
case 1:
Console.WriteLine($"Coca Cola com gelo");
break;

case 2: 
Console.WriteLine($"Coca Cola sem gelo");
break;

case 3: 
Console.WriteLine($"Guaraná Antartica com gelo");
break;

case 4: 
Console.WriteLine($"Guaraná Antartica sem gelo");
break;

case 5:
Console.WriteLine($"Sprite com gelo");
break;

case 6:
Console.WriteLine($"Sprite sem gelo");
break;

case 7:
Console.WriteLine($"Suco de Laraja com gelo");
break;

case 8:
Console.WriteLine($"Suco de Laraja sem gelo");
break;

default:
Console.WriteLine($"Escolha uma opçao valida");
break;
}


