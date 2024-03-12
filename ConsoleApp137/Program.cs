double derece = 0;
Console.Write("Sıcaklık değerini giriniz:");
derece = Convert.ToDouble(Console.ReadLine());

if (derece <= 0)
{
    Console.Write("KATI");
}
else if (derece > 0 && derece < 100)
{
    Console.Write("SIVI");
}
else
{
    Console.Write("GAZ");
}

Console.ReadKey();