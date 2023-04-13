string name = "Maria";
string gender;
int age = 17;
string result1 = name + " jest niepełnoletnim mężczyzną";
string result2 = name + " jest pełnoletnim mężczyzną";
string result3 = name + " jest pełnoletnią kobietą";
string result4 = name + " jest niepełnoletnią kobietą";

if (name.EndsWith('a') && name != "Kuba")
{
    gender = "kobieta";
}
else
{
    gender = "mężczyzna";
}

if (gender == "mężczyzna" && age < 18)
{
    Console.WriteLine(result1);
}
else if (gender == "mężczyzna" && age >= 18)
{
    Console.WriteLine(result2);
}
else if (gender == "kobieta" && age >= 18)
{
    Console.WriteLine(result3);
}
else
{
    Console.WriteLine(result4);
}