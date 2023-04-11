string TwojeImię = "Damian";
string TwojaPłeć = "Mężczyzna";
var TwójWiek = 37;
string Tekst1 = " - jesteś mężczyzną w wieku 37 lat.";
string Tekst2 = " - jesteś mężczyzną poniżej 30 lat.";
string result1 = TwojeImię + Tekst1;
string result2 = TwojeImię + Tekst2;

if (TwojaPłeć == "mężczyzna" && TwójWiek == 37)
{
	Console.WriteLine(result1);
}
else if (TwojaPłeć == "mężczyzna" && TwójWiek < 30)
{
	Console.WriteLine(result2);
}
else if (!(TwojaPłeć == "mężczyzna") && TwójWiek < 18)
{
	Console.WriteLine("Jesteś niepełnoletnią osobą.");
}
else if (TwójWiek > 30)
{
	Console.WriteLine("Jesteś już po trzydziestce");
}