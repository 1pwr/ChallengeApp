/// dzien 6
using CallengeApp;
var rand = new Random(); 
int LastRating = 0;
string WinnerFN ="";
string WinnerLN ="";
int WinnerAge = -1;
int[] range= new int[] {0,1,2,3,4,5};
Employee[] empl =  new Employee[3];
empl[0] = new Employee("Mateusz","Tadeusz",29);
empl[1] = new Employee("Zosia","Gosia",24);
empl[2] = new Employee("Nika","Wnika",31);

foreach (Employee e in empl)
{
    foreach(int r in range)
    {
        e.AddGrades(rand.Next(11));
    }
    Console.WriteLine("wynik stary "+LastRating+" nowy "+e.Rating);
    if(e.Rating > LastRating)
    {
        LastRating = e.Rating;
        WinnerFN = e.FName;
        WinnerLN = e.LName;
        WinnerAge = e.AgeE;
    }
}
Console.WriteLine("Szczęśliwą osobą jest tym rezem "+WinnerFN+" "+WinnerLN+" lat "+WinnerAge+" z wynikiem "+LastRating);
