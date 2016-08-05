using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /* * Complete the function below. */
        
        static string[] Reformat(string[] dates)
        {
            int size = dates.Length;
            string[] formatedDates = new string[size];
            string formatedDate = null;

            Console.WriteLine(size);

            for (int i = 0; i < size; i++)
            {
                formatedDates[i] = formatDate(dates[i]);
                Console.WriteLine(formatedDates[i]);

                //Console.WriteLine(formatDate2(dates[i]));
            }

            return formatedDates;
        }

        static String formatDate(string date)
        {
            try
            {
                date = date.Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", "");
                date = DateTime.ParseExact(date, "d MMM yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")).ToString("yyyy-MM-dd");
            }
            catch (Exception) { }
            return date;
        }
        
        static void Main(string[] args)
        {
            String[] dates = Reformat(new String[] { "20th Oct 2052", "6th Jun 1933", "26th May 1960", "20th Sep 1958", "16th Mar 2068", "25th May 1912", "16th Dec 2018", "26th Dec 2061", "4th Nov 2030", "28th Jul 1963" });

            Console.WriteLine(dates.Length);

            dates = Reformat(new String[] { "1st Dec 2000", "6th Jul 1933", "3rd May 1999", "20th Sep 1958", "16th Mar 2068", "25th May 1912", "16th Dec 2018", "26th Dec 2061", "4th Nov 2030", "28th Jul 1963", "4th Nov 2030", "28th Jul 1963" });
            Console.WriteLine(dates.Length);

            //Console.ReadLine();
        }
    }
}
