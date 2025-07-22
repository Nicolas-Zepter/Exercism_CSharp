using Exercism_CSharp;

#region Testing Allergies

Allergies allergies = new(257);
Console.WriteLine(allergies.IsAllergicTo(Allergen.Peanuts));
Console.WriteLine(allergies.IsAllergicTo(Allergen.Eggs));
Console.WriteLine(string.Join(",", allergies.List()));

#endregion
