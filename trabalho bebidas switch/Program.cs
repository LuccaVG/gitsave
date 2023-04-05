Console.WriteLine($"Escolha sua Bebida");
Console.WriteLine($"digite 1 para Coca Cola");
Console.WriteLine($"digite 2 Para Guaraná Antartica");
Console.WriteLine($"digite 3 para Sprite");
Console.WriteLine($"digite 4 para Fanta Laranja");
Console.WriteLine($"digite 5 para Fanta Uva");
Console.WriteLine($"digite 6 para Pepsi");


int opçoes = int.Parse(Console.ReadLine());

switch (opçoes)
{

    case 1:
        Console.WriteLine($"Coca Cola");
        break;

    case 2:
        Console.WriteLine($"Guaraná Antartica");
        break;

    case 3:
        Console.WriteLine($"Sprite");
        break;

    case 4:
        Console.WriteLine($"Fanta Laranja");
        break;

    case 5:
        Console.WriteLine($"Fanta Uva");
        break;

    case 6:
        Console.WriteLine($"Pepsi");
        break;

    default:
        Console.WriteLine($"escolha uma opçao válida");
        break;
}

Console.WriteLine($"Escolha o Tamanho da Bebida");
Console.WriteLine($"Digite 1 para 300ml");
Console.WriteLine($"Digite 2 para 500ml");
Console.WriteLine($"Digite 3 para 700ml");

int Tamanho = int.Parse(Console.ReadLine());

switch (Tamanho)
{
    case 1:
        Console.WriteLine($"300ml");
        break;

    case 2:
        Console.WriteLine($"500ml");
        break;

    case 3:
        Console.WriteLine($"700ml");
        break;

    default:
        Console.WriteLine($"escolha uma opçao válida");
        break;
}


Console.WriteLine($"Escolha com ou sem gelo");
Console.WriteLine($"digite 1 para Com Gelo");
Console.WriteLine($"digite 2 para Sem Gelo");

int Gelo = int.Parse(Console.ReadLine());

switch (Gelo)
{
    case 1:
        Console.WriteLine($"Com Gelo");
        break;

    case 2:
        Console.WriteLine($"Sem Gelo");
        break;

    default:
        Console.WriteLine($"escolha uma opçao válida");
        break;
}

// coca



if ((opçoes == 1) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Coca Cola de 300ml com Gelo escolhida");
}

else if ((opçoes == 1) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Coca Cola de 300ml sem Gelo escolhida");
}

else if ((opçoes == 1) && (Tamanho == 2) && (Gelo == 1)) 
{
    Console.WriteLine($"Coca Cola de 500ml com Gelo escolhida");
}

else if ((opçoes == 1) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Coca Cola de 500ml sem Gelo escolhida");
}

else if ((opçoes == 1) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Coca Cola de 700ml com Gelo escolhida");
}

else if ((opçoes == 1) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Coca Cola de 700ml sem Gelo escolhida");
}


// guarana


else if ((opçoes == 2) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Guaraná de 300ml com Gelo escolhida");
}

else if ((opçoes == 2) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Guaraná de 300ml sem Gelo escolhida");
}

else if ((opçoes == 2) && (Tamanho == 2) && (Gelo == 1)) 
{
    Console.WriteLine($"Guaraná de 500ml com Gelo escolhida");
}

else if ((opçoes == 2) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Guaraná de 500ml sem Gelo escolhida");
}

else if ((opçoes == 2) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Guaraná de 700ml com Gelo escolhida");
}

else if ((opçoes == 2) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Guaraná de 700ml sem Gelo escolhida");
}

// sprite

else if ((opçoes == 3) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Sprite de 300ml com Gelo escolhida");
}

else if ((opçoes == 3) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Sprite de 300ml sem Gelo escolhida");
}

else if ((opçoes == 3) && (Tamanho == 2) && (Gelo == 1)) 
{
    Console.WriteLine($"Sprite de 500ml com Gelo escolhida");
}

else if ((opçoes == 3) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Sprite de 500ml sem Gelo escolhida");
}

else if ((opçoes == 3) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Sprite de 700ml com Gelo escolhida");
}

else if ((opçoes == 3) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Sprite de 700ml sem Gelo escolhida");
}

// fanta laranja

else if ((opçoes == 4) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Laranja de 300ml com Gelo escolhida");
}

else if ((opçoes == 4) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Laranja de 300ml sem Gelo escolhida");
}

else if ((opçoes == 4) && (Tamanho == 2) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Laranja de 500ml com Gelo escolhida");
}

else if ((opçoes == 4) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Laranja de 500ml sem Gelo escolhida");
}

else if ((opçoes == 4) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Laranja de 700ml com Gelo escolhida");
}

else if ((opçoes == 4) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Laranja de 700ml sem Gelo escolhida");
}

// fanta uva

else if ((opçoes == 5) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Uva de 300ml com Gelo escolhida");
}

else if ((opçoes == 5) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Uva de 300ml sem Gelo escolhida");
}

else if ((opçoes == 5) && (Tamanho == 2) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Uva de 500ml com Gelo escolhida");
}

else if ((opçoes == 5) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Uva de 500ml sem Gelo escolhida");
}

else if ((opçoes == 5) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Fanta Uva de 700ml com Gelo escolhida");
}

else if ((opçoes == 5) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Fanta Uva de 700ml sem Gelo escolhida");
}

// pepsi

else if ((opçoes == 6) && (Tamanho == 1) && (Gelo == 1)) 
{
    Console.WriteLine($"Pepsi de 300ml com Gelo escolhida");
}

else if ((opçoes == 6) && (Tamanho == 1) && (Gelo == 2)) 
{
    Console.WriteLine($"Pepsi de 300ml sem Gelo escolhida");
}

else if ((opçoes == 6) == (Tamanho == 2) == (Gelo == 1)) 
{
    Console.WriteLine($"Pepsi de 500ml com Gelo escolhida");
}

else if ((opçoes == 6) && (Tamanho == 2) && (Gelo == 2)) 
{
    Console.WriteLine($"Pepsi de 500ml sem Gelo escolhida");
}

else if ((opçoes == 6) && (Tamanho == 3) && (Gelo == 1)) 
{
    Console.WriteLine($"Pepsi de 700ml com Gelo escolhida");
}

else if ((opçoes == 6) && (Tamanho == 3) && (Gelo == 2)) 
{
    Console.WriteLine($"Pepsi de 700ml sem Gelo escolhida");
}