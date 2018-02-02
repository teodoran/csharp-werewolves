using System;

namespace Werewolves.Dilemmas
{
    public class DateStamp
    {
        private readonly DateTime _date;

        public DateStamp(DateTime date)
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
