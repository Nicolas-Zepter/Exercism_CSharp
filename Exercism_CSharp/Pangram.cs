using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp
{
    #region Task Description
    /*
    Your task is to figure out if a sentence is a pangram.
    A pangram is a sentence using every letter of the alphabet at least once. It is case insensitive, so it doesn't matter if a letter is lower-case (e.g. k) or upper-case (e.g. K).
    For this exercise, a sentence is a pangram if it contains each of the 26 letters in the English alphabet.
    */
    #endregion

    public static class Pangram
    {
        public static bool IsPangram(string input) =>
           input.Where(Char.IsLetter)
                .Select(Char.ToLowerInvariant)
                .Distinct()
                .Count() == 26;
    }
}
