using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StringsDates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "         This string contains a lot of spaces.";
            Console.WriteLine($"The length of the string: {s1.Length}");
            Console.WriteLine($"Does the mentioned string starts with 'This'? {s1.StartsWith("This")}");
            Console.WriteLine($"Does the string ends with 'a lot'? {s1.EndsWith("a lot")}");

            string s2 = s1.Insert(s1.Length, " And a lot of characters.");
            Console.WriteLine(s2);

            string[] array = new string[100];
            string s3 = s1.Trim();
            Console.WriteLine(s3);
            array = s3.Split();
            foreach(string i in array)
            {
                Console.WriteLine(i);
            }
            string s4 = string.Join(", ", array);
            Console.WriteLine(s4);

            StringBuilder builder = new StringBuilder();
            builder.Append("This ");
            builder.Append("is a string built with string builder");
            builder.Append('.');
            Console.WriteLine(builder);
            Console.WriteLine();

            TimeSpan t1 = new TimeSpan(4, 23, 55, 0);
            Console.WriteLine(t1);
            Console.WriteLine(TimeSpan.FromHours(15) - TimeSpan.FromMinutes(15));

            DateTime d1, d2, d3;
            TimeSpan duration = new TimeSpan(25, 0, 0, 55);
            string date = "12/05/2020 12:45:26 PM";
            d1 = new DateTime(2020, 3, 15, 12, 0, 0);
            d2 = DateTime.Now;
            d3 = DateTime.Parse(date);

            Console.WriteLine(d1.Add(duration));
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();
            Console.WriteLine();
            TimeSpan duration1 = new TimeSpan(5, 15, 0);
            DateTimeOffset dt1 = new DateTimeOffset(d3, duration1);
            Console.WriteLine(dt1);

            DateTimeOffset offset = new DateTimeOffset(DateTime.Now);
            DateTime dt2 = offset.LocalDateTime;
            Console.WriteLine($"{dt2} {dt2.Kind}");

            TimeZone zone = TimeZone.CurrentTimeZone;

            Console.WriteLine(zone.GetUtcOffset(d1));
            Console.WriteLine(zone.GetUtcOffset(d2));
            Console.WriteLine(zone.IsDaylightSavingTime(d2));
            Console.WriteLine();

            CultureInfo local = CultureInfo.CurrentCulture;
            Console.WriteLine(5.ToString("C", local));

            NumberFormatInfo a = new NumberFormatInfo();
            a.NumberGroupSeparator = " ";
            Console.WriteLine(15624.325.ToString("N3", a));

        }
    }
}
