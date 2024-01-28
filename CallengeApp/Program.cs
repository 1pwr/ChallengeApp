// praca dzień 4
// płeć "m" - mężczyzna "f" - Kobieta lub nie zdefiniowana
const int age18 = 18, age30 = 30;
const string nameEwa = "Ewa";

var sex = "f";
var age = 27;
var name = "Ewa";

if (name == nameEwa && age == age30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "f" && age < age30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "m" && age < age18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
