namespace Exercism_CSharp
{
    #region Task Description
    /*
    Given a string representing a DNA sequence, count how many of each nucleotide is present. 
    If the string contains characters that aren't A, C, G, or T then it is invalid and you should signal an error.
    */
    #endregion

    public static class NucleotideCount
    {
        /// <summary>
        /// Counts the occurrences of the valid nucleotides A, C, G, and T in a given DNA sequence.
        /// </summary>
        /// <param name="sequence">The DNA sequence to be examined.</param>
        /// <returns>An IDictionary mapping the valid nucleotides to their respective counts.</returns>
        /// <exception cref="ArgumentException">Thrown if the given DNA sequence contains an invalid nucleotide.</exception>
        public static IDictionary<char, int> Count(string sequence)
        {
            IDictionary<char, int> validNucleotides = new Dictionary<char, int>
            {
                { 'A', 0 },
                { 'C', 0 },
                { 'G', 0 },
                { 'T', 0 }
            };
            char[] seqChars = sequence.ToCharArray();

            foreach (char c in seqChars)
            {
                if (!validNucleotides.ContainsKey(c)) throw new ArgumentException("The DNA sequence contains an invalid nucleotide.");

                validNucleotides[c] = validNucleotides[c] + 1;
            }

            return validNucleotides;
        }
    }
}
