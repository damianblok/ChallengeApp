string name = "Damian";
string sex = "Mężczyzna";
var age = 37;
string Text1 = " - jesteś mężczyzną w wieku 37 lat.";
string Text2 = " - jesteś mężczyzną poniżej 30 lat.";
string result1 = name + Text1;
string result2 = name + Text2;

if (sex == "mężczyzna" && age == 37)
{
	Console.WriteLine(result1);
}
else if (sex == "mężczyzna" && age < 30)
{
	Console.WriteLine(result2);
}
else if (!(sex == "mężczyzna") && age < 18)
{
	Console.WriteLine("Jesteś niepełnoletnią osobą.");
}
else if (age > 30)
{
	Console.WriteLine("Jesteś już po trzydziestce");
}