Random r = new Random();
int kod = r.Next(0, 10);
double a;
Console.WriteLine("zgadnij liczbe");
a = double.Parse(Console.ReadLine());
if (a < kod)
{
    Console.WriteLine("Podana liczba jest mniejsza od tej ktora wylosowales");
}
else if (a > kod)
{
    Console.WriteLine("Podana liczba jest wieksza od tej ktora wylosowales");

}
else
    Console.WriteLine("Gratulacje zgadles");
while (a != kod)
{
    Console.WriteLine("zgadnij liczbe");
    a = double.Parse(Console.ReadLine());
    if (a < kod)
    {
        Console.WriteLine("Podana liczba jest mniejsza od tej ktora wylosowales");
    }
    else if (a > kod)
    {
        Console.WriteLine("Podana liczba jest wieksza od tej ktora wylosowales");

    }
    else
        Console.WriteLine("Gratulacje zgadles");
}
