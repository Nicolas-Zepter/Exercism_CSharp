using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp
{
    #region Task Description
    /*
    Determine if a word or phrase is an isogram.
    An isogram (also known as a "non-pattern word") is a word or phrase without a repeating letter, however spaces and hyphens are allowed to appear multiple times.
    Examples of isograms:
    lumberjacks
    background
    downstream
    six-year-old
    The word isograms, however, is not an isogram, because the s repeats.
    */
    #endregion

    public static class Isogram
    {
        public static bool IsIsogram(string word) =>
            !word.Where(Char.IsLetter)
                .Select(Char.ToLowerInvariant)
                .GroupBy(c => c)
                .Any(g => g.Count() > 1);
    }
}
