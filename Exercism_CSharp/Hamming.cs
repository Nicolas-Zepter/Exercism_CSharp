namespace Exercism_CSharp
{
    public static class Hamming
    {
        #region Task Description
        /*
        Calculate the Hamming distance between two DNA strands.
        We read DNA using the letters C, A, G and T. Two strands might look like this:
        GAGCCTACTAACGGGAT
        CATCGTAATGACGGCCT
        ^ ^ ^  ^ ^    ^^
        They have 7 differences, and therefore the Hamming distance is 7.
        Implementation notes
        The Hamming distance is only defined for sequences of equal length, so an attempt to calculate it between sequences of different lengths should not work.
        */
        #endregion

        /// <summary>
        /// Calculates the Hamming distance between two given DNA strands.
        /// </summary>
        /// <param name="firstStrand">The first DNA strand to compare.</param>
        /// <param name="secondStrand">The second DNA strand to compare.</param>
        /// <returns>An integer indicating the Hamming distance between both DNA strands.</returns>
        /// <exception cref="ArgumentException">Thrown when the argument strings are not of equal length.</exception>
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand.Length == secondStrand.Length)
            {
                int counter = 0;
                char[] firstChars = firstStrand.ToCharArray();
                char[] secondChars = secondStrand.ToCharArray();

                for (int i = 0; i < firstChars.Length; i++)
                {
                    if (!firstChars[i].Equals(secondChars[i])) counter++;
                }

                return counter;
            }

            throw new ArgumentException("The provided strings must be equal in length.");
        }
    }
}
