Console.WriteLine("Zadejte 1. cislo");
string cislo = Console.ReadLine();
int a = Convert.ToInt32(cislo);

Console.WriteLine("Zadejte 2. cislo");
string cislo2 = Console.ReadLine();
int b = Convert.ToInt32(cislo2);

if (a == b)
{
    Console.WriteLine("Cisla se rovnají");
}
if (a > b)
{
    Console.WriteLine(cislo);
    Console.WriteLine(cislo2);
}
if (a < b) 
{
    Console.WriteLine(cislo2);
    Console.WriteLine(cislo);
}
