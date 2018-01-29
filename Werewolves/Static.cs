using System;

namespace Werewolwes.Examples
{
    class Static
    {
        public static class DateStamp1
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

        public class DateStamp2
        {
            private readonly DateTime _date;

            DateStamp2(DateTime date)
            {
                _date = date;
            }

            public string GetShortDateStamp()
            {
                var result = _date.ToString("dd-MM-yyyy");
             
                return result;
            }

            public string GetLongDateStamp()
            {
                var dateString = _date.ToString("dd-MM-yyyy HH:mm");
                var result = $"MY_SILVER_BULLET_STAMP: {dateString}";

                return result;
            }
        }
    }
}
