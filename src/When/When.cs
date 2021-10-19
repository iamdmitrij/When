using System;

namespace When
{
    /// <summary>
    /// A set of convenient utils for <see cref="DateTime"/>.
    /// </summary>
    public static class When
    {
        /// <summary>
        /// Returns tomorrow's date.
        /// </summary>
        /// <param name="dateTime">Original timestamp</param>
        /// <returns>Transformed timestamp</returns>
        public static DateTime Tomorrow(this DateTime dateTime)
        {
            return dateTime.AddDays(1);
        }

        /// <summary>
        /// Returns yesterday's date.
        /// </summary>
        /// <param name="dateTime">Original timestamp</param>
        /// <returns>Transformed timestamp</returns>
        public static DateTime Yesterday(this DateTime dateTime)
        {
            return dateTime.AddDays(-1);
        }
    }
}
