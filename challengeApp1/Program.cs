var name = "Ewa";
var age = 33;
bool female = true;

if (female)
{
    if (age < 30)
    {
        Console.WriteLine("kobieta poniżej 30 lat");

    }
    else if (age > 30)
    {
        Console.WriteLine($"{name} lat {age}");

    }
}
else if (!female)
{
    if (age < 18)
    {
        Console.WriteLine("niepełnoletni mężczyzna");
    }
    else if (age > 18)
    {
        Console.WriteLine("pełnoletni mężczyzna");
    }
}