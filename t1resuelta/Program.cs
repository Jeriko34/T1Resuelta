string nombre;
double vent = 0, salar = 0, comis = 0, des = 0, totgan = 0;
int an = 0;
Console.WriteLine("Escriba su nombre: ");
nombre = Console.ReadLine();
Console.WriteLine("Escriba su sueldo: ");
salar = double.Parse(Console.ReadLine());
Console.WriteLine("Ventas que se realizaron: ");
vent = double.Parse(Console.ReadLine());
Console.Write("Escriba los años que tiene la empresa: ");
an = int.Parse(Console.ReadLine());
if (vent < 600)
{
    comis = vent + (vent * 0.5);
}
else if (600 > vent && vent <= 3000)
{
    comis = vent + (vent * 0.07);
}
else
    comis = 300 + (vent * 0.06);
totgan = salar + comis;
if (an >= 3)
{
    des = totgan * 0.065;
}
else
    des = totgan * 0.045;
Console.WriteLine($"Hola {nombre}");
Console.WriteLine($"Su salario es {totgan}: ");
Console.WriteLine($"Se te descuenta por impuestos: {des}: ");
Console.WriteLine($"Salario neto: {totgan - des}: ");
Console.ReadKey();


