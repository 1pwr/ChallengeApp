/// dzien 6
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

class Employee
{
    private string FirstName;
    private string LastName;
    private int Age;
    private List<int> Grades= new List<int>();
    public Employee(string FrstNm, string LstNm, int Ag)
    {
        this.FirstName = FrstNm;
        this.LastName = LstNm;
        this.Age = Ag;
    }
    public void AddGrades(int number)
    {
        this.Grades.Add(number);
    }
    public int Rating
    { 
        get
        {
            return this.Grades.Sum();
        }
    }
    public string FName 
    {
        get 
        {
            return this.FirstName;
        }
    }
    public string LName 
    {
        get 
        {
            return this.LastName;
        }
    }
    public int AgeE 
    {
        get 
        {
            return this.Age;
        }
    }
}