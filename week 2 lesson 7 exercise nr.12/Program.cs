Console.WriteLine("podaj dzien tygodnia:");
int dzien = int.Parse(Console.ReadLine());

if (dzien == 1)
{
    Console.WriteLine("poniedzialek");
}
else if (dzien == 2)
{
    Console.WriteLine("wtorek");
}
else if (dzien == 3) 
{
    Console.WriteLine("sroda");
}
else if (dzien == 4)
{
    Console.WriteLine("czwartek");
}
else if(dzien == 5)
{
    Console.WriteLine("piatek");
}
else if (dzien == 6)
{
    Console.WriteLine("sobota");
}
else if (dzien == 7)
{
    Console.WriteLine("niedziela");
}
else
{
    Console.WriteLine("podaj cyfre od 1 do 7");
}