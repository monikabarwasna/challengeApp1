using System.ComponentModel.Design;

var name = "Ewa";
var age = 18;
bool female = false;

if (female)
{
    if (age < 30)
    {
        Console.WriteLine("kobieta poniżej 30 lat");

    }
    else
    {
        Console.WriteLine($"{name} lat {age}");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("niepełnoletni mężczyzna");
    }
    else if (age >= 18)
    {
        Console.WriteLine("pełnoletni mężczyzna");
    }

}