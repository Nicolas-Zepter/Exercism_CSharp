using Exercism_CSharp;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

#region Testing Allergies
/*
Allergies allergies = new(257);
Console.WriteLine(allergies.IsAllergicTo(Allergen.Peanuts));
Console.WriteLine(allergies.IsAllergicTo(Allergen.Eggs));
Console.WriteLine(string.Join(",", allergies.List()));
*/
#endregion

#region Testing Gigasecond
/*
DateTime test = DateTime.Now;
Console.WriteLine(Gigasecond.Add(test));
*/
#endregion

#region Testing Hamming
//Console.WriteLine(Hamming.Distance("GGACGGATTCTG", "AGGACGGATTCT"));
#endregion

#region Testing Leap Years
/*
Console.WriteLine(Leap.IsLeapYear(1900)); // expected: false
Console.WriteLine(Leap.IsLeapYear(1999)); // expected: false
Console.WriteLine(Leap.IsLeapYear(2000)); // expected: true
*/
#endregion

#region Testing NucleotideCount
/*
Console.WriteLine(JsonSerializer.Serialize(NucleotideCount.Count("GGACGGATTCTG")));
Console.WriteLine(JsonSerializer.Serialize(NucleotideCount.Count("CCAGGACTGGTATTCT")));
//Console.WriteLine(JsonSerializer.Serialize(NucleotideCount.Count("GGADCGGATTCTG"))); //throws ArgumentException
*/
#endregion

#region Testing ResistorColor
/*
Console.WriteLine(ResistorColor.ColorCode("red")); //expected: 2
Console.WriteLine(ResistorColor.ColorCode("yellow")); //expected: 4
Console.WriteLine(ResistorColor.ColorCode("purple")?.ToString() ?? "null"); //expected: null
*/
#endregion

#region Testing Robot
/*
Robot rob = new();
Console.WriteLine(rob.TurnOn());
rob.Reset();
Console.WriteLine(rob.Name);
Robot rob2 = new();
Console.WriteLine(rob2.TurnOn());
rob2.Reset();
Console.WriteLine(rob2.Name);
*/
#endregion

#region Testing SpaceAge
/*
int seconds = 788918400; // roughly 25 years old on Earth
SpaceAge sa = new(seconds);

double earthAge = double.Round(sa.OnEarth(), 2);
double venusAge = double.Round(sa.OnVenus(), 2);
double jupiterAge = double.Round(sa.OnJupiter(), 2);
double marsAge = double.Round(sa.OnMars(), 2);

IDictionary<string, double> writeLine = new Dictionary<string, double>();
writeLine.Add("Age in Earth seconds", seconds);
writeLine.Add("Age in Earth years", earthAge);
writeLine.Add("Age in Venus years", venusAge);
writeLine.Add("Age in Jupiter years", jupiterAge);
writeLine.Add("Age in Mars years", marsAge);
Console.WriteLine(JsonSerializer.Serialize(writeLine, new JsonSerializerOptions { WriteIndented = true }));
*/
#endregion

#region Testing GradeSchool
/*
GradeSchool gs = new();
Console.WriteLine(gs.Add("Aimee", 2));
Console.WriteLine(gs.Add("Aimee", 4));
*/
#endregion

#region Testing Pangram
/*
Console.WriteLine(Pangram.IsPangram(""));
Console.WriteLine(Pangram.IsPangram("a2bcdefg3hijkl8mnopqrs5tuvwxyz9"));
Console.WriteLine(Pangram.IsPangram("abcdefghijklmnoPQRSTUVWXYZ"));
Console.WriteLine(Pangram.IsPangram("abcdefghijklmnoPQRSTUVWXYZABCDEFGHIJK55"));
Console.WriteLine(Pangram.IsPangram("bcdefghijklmnoPQRSTUVWXYZB"));
*/
#endregion

#region Testing Isogram
/*
Console.WriteLine(Isogram.IsIsogram("abcdefghijklmnopqrstuvwxyz"));
Console.WriteLine(Isogram.IsIsogram("sequence"));
Console.WriteLine(Isogram.IsIsogram("abcde-fghijk-lmn15opqrstu-vwxyz"));
Console.WriteLine(Isogram.IsIsogram("six-year-old"));
*/
#endregion

#region Testing Grains

void SafeWrite(Func<ulong> action)
{
    try
    {
        Console.WriteLine(action());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

SafeWrite(() => Grains.Total());
SafeWrite(() => Grains.Square(64));
SafeWrite(() => Grains.Square(0));
SafeWrite(() => Grains.Square(1));
SafeWrite(() => Grains.Square(65));
SafeWrite(() => Grains.Square(20));

#endregion

#region Testing



#endregion