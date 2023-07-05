int number = 4594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int conunter0 = 0;
int conunter1 = 0;
int conunter2 = 0;
int conunter3 = 0;
int conunter4 = 0;
int conunter5 = 0;
int conunter6 = 0;
int conunter7 = 0;
int conunter8 = 0;
int conunter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        conunter0++;
    }
    else if (letter == '1')
    {
        conunter1++;
    }
    else if (letter == '2')
    {
        conunter2++;
    }
    else if (letter == '3')
    {
        conunter3++;
    }
    else if (letter == '4')
    {
        conunter4++;
    }
    else if (letter == '5')
    {
        conunter5++;
    }
    else if (letter == '6')
    {
        conunter6++;
    }
    else if (letter == '7')
    {
        conunter7++;
    }
    else if (letter == '8')
    {
        conunter8++;
    }
    else if (letter == '9')
    {
        conunter9++;
    }
}
Console.WriteLine("O=" + conunter0);
Console.WriteLine("1=" + conunter1);
Console.WriteLine("2=" + conunter2);
Console.WriteLine("3=" + conunter3);
Console.WriteLine("4=" + conunter4);
Console.WriteLine("5=" + conunter5);
Console.WriteLine("6=" + conunter6);
Console.WriteLine("7=" + conunter7);
Console.WriteLine("8=" + conunter8);
Console.WriteLine("9=" + conunter9);
