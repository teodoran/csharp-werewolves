using System;

namespace Werewolves.Dilemmas
{
    public static class DateStamp
    {

        public static string GetShortDateStamp(DateTime date)
        {
            var result = date.ToString("dd-MM-yyyy");
            
            return result;
        }

        public static string GetLongDateStamp(DateTime date)
        {
            var dateString = date.ToString("dd-MM-yyyy HH:mm");
            var result = $"MY_SILVER_BULLET_STAMP: {dateString}";

            return result;
        }
    }
}
