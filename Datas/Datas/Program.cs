using System;
using System.Globalization;

namespace Datas
{
    internal class Program
    {
        static void DateFormats()
        {
            //var formated = String.Format("{0:dd-MM-yyyy hh:mm:ss ff z}", date); //z = timezone

            //var formated = String.Format("{0:t}", date); //demonstra a hora
            //var formated = String.Format("{0:d}", date); //demonstra a data

            //var formated = String.Format("{0:T}", date); //demonstra a hora
            //var formated = String.Format("{0:D}", date); //demonstra a data por extenso

            //var formated = String.Format("{0:g}", date); //data e hora

            //var formated = String.Format("{0:R}", date); //data, hora, dia da semana, mes

            //var formated = String.Format("{0:s}", date); //sortable datetime

            var formated = String.Format("{0:u}", DateTime.Now); //padrão universal

            Console.WriteLine(formated);
        }

        static void AddDate()
        {
            var date = DateTime.Now;

            Console.WriteLine(date.AddMonths(1));
        }

        static void DateWithCultureInfo()
        {
            /*var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var actual = CultureInfo.CurrentCulture;*/



            //Console.WriteLine(DateTime.Now.ToString("D", de));            
        }

        static void TimeSpan()
        {
            var timespan = new TimeSpan();

            var timespanNanoSeconds = new TimeSpan(1);

            var timespanHourMinuteSecond = new TimeSpan(5,12,8);

            var timespanDayHourMinuteSecond = new TimeSpan(3, 5, 12, 8);

            var timespanDayHourMinuteSecondMili = new TimeSpan(15, 12, 55, 8, 100);

            Console.WriteLine(timespan);
            Console.WriteLine(timespanNanoSeconds);
            Console.WriteLine(timespanHourMinuteSecond);
            Console.WriteLine(timespanDayHourMinuteSecond);
            Console.WriteLine(timespanDayHourMinuteSecondMili);

            Console.WriteLine(timespanHourMinuteSecond - timespanDayHourMinuteSecond);
            Console.WriteLine(timespanDayHourMinuteSecond.Days);
        }

        static void UtcDate()
        {
            var utc = DateTime.UtcNow;
            //Console.WriteLine(utc); //Utilize o utcnow para apps globalizados. hora universal            

            //Console.WriteLine(utc.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");

            //Console.WriteLine(timezoneAustralia);

            var hour = TimeZoneInfo.ConvertTimeFromUtc(utc, timezoneAustralia);

            //Console.WriteLine(hour);

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone.StandardName);
                Console.WriteLine(timezone.SupportsDaylightSavingTime);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utc, timezone));
                Console.WriteLine("---------------------------------------");
            }
        }

        static void Main(string[] args)
        {
            /* DateTime date = DateTime.Now;

             if(date == DateTime.Now)
             {
                 Console.WriteLine("é igual");
             }

             DateWithCultureInfo();*/

            //UtcDate();

            TimeSpan();

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); //Horário de verão

            Console.ReadKey();
        }
    }
}
