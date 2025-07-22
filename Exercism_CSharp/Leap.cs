namespace Exercism_CSharp
{
    #region Task Description
    /*
     Your task is to determine whether a given year is a leap year.
    The DateTime class in C# provides a built-in IsLeapYear which you should pretend doesn't exist for the purposes of implementing this exercise.
    */
    #endregion

    public static class Leap
    {
        /// <summary>
        /// Determines if the provided year is a leap year.
        /// </summary>
        /// <param name="year">The year to examine.</param>
        /// <returns>True if year is a leap year, otherwise false.</returns>
        public static bool IsLeapYear(int year)
        {
            switch (year)
            {
                case int y:
                    if (y % 100 == 0)
                    {
                        if (y % 400 == 0) return true;
                        return false;
                    }

                    else
                    {
                        if (y % 4 == 0) return true;
                        return false;
                    }
            }
        }
    }
}
