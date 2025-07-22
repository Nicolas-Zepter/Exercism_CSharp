using Exercism_CSharp;

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

Console.WriteLine(Leap.IsLeapYear(1900)); // expected: false
Console.WriteLine(Leap.IsLeapYear(1999)); // expected: false
Console.WriteLine(Leap.IsLeapYear(2000)); // expected: true

#endregion