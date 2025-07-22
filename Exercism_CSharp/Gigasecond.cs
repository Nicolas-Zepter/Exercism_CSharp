namespace Exercism_CSharp
{
    #region Task Description
    /*
        Your task is to determine the date and time one gigasecond after a certain date.
        A gigasecond is one thousand million seconds. That is a one with nine zeros after it.
        If you were born on January 24th, 2015 at 22:00 (10:00:00pm), then you would be a gigasecond old on October 2nd, 2046 at 23:46:40 (11:46:40pm).
    */
    #endregion

    public static class Gigasecond
    {
        /// <summary>
        /// Determines the DateTime one gigasecond after a given moment.
        /// </summary>
        /// <param name="moment">The initial moment.</param>
        /// <returns>A DateTime one gigasecond after moment.</returns>
        public static DateTime Add(DateTime moment) => moment.AddSeconds(1000000000);
    }
}
