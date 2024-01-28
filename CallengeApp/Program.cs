// praca dzień 5
var digits = new char[] {'0','1','2','3','4','5','6','7','8','9'};
int number = 17017;
string numToStr = number.ToString();
char[] numToChr = numToStr.ToCharArray();
int i = 0;

Console.WriteLine("Hello, Wynik dla liczby: " + number);
foreach (char ds in digits)
{
    i = 0;
    foreach(char dc in numToChr)
    {
        if(ds == dc)
        {
            i++;
        }
    }
    Console.WriteLine(ds + " => " + i);
}
