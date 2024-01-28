namespace CallengeApp;

public class Employee
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
