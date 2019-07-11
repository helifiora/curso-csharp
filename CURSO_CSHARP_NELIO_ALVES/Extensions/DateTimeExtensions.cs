using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObjeto)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObjeto);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}