Console.WriteLine("podaj dzien tygodnia:");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("poniedzialek");
}
else if (day == 2)
{
    Console.WriteLine("wtorek");
}
else if (day == 3)
{
    Console.WriteLine("sroda");
}
else if (day == 4)
{
    Console.WriteLine("czwartek");
}
else if (day == 5)
{
    Console.WriteLine("piatek");
}
else if (day == 6)
{
    Console.WriteLine("sobota");
}
else if (day == 7)
{
    Console.WriteLine("niedziela");
}
else
{
    Console.WriteLine("podaj cyfre od 1 do 7");
}

switch (day)
{
    case 1:
        Console.WriteLine("poniedzialek");
        break;
    case 2:
        Console.WriteLine("wtorek");
        break;
    case 3:
        Console.WriteLine("sroda");
        break;
    case 4:
        Console.WriteLine("czwartek");
        break;
    case 5:
        Console.WriteLine("piatek");
        break;
    case 6:
        Console.WriteLine("sobota");
        break;
    case 7:
        Console.WriteLine("niedziela");
        break;
    default:
        Console.WriteLine("podaj cyfre od 1 do 7");
        break;
}
