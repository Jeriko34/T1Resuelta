int placa = 0, conta = 1;
string color;

Console.WriteLine("Escriba los colores de la calcomania de los autos: ");
color = Console.ReadLine().ToUpper();

while (conta >= 1)
{
    if (color == "VERDE")
    {
        conta += 1;
        for (placa += 1; placa <= 3 && placa >= 0;) { placa += 1; }     
    }
    else if (color == "AZUL")
    {
        for (placa += 1; placa <= 6 && placa > 3;) { placa += 1; }
        conta = 1;
    }
   else if (color == "ROJO")
    {
        conta += 1;
        for (placa += 1; placa <= 9 && placa > 6;) { placa += 1; }
    }
    else if (color == "F") {
        conta -= 1;
        Console.WriteLine($"{placa}:");
    }
}
