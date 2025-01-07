using System;
namespace Fecha_y_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Myvalue = DateTime.Now;
            //Console.WriteLine(Myvalue.ToString());
            //Console.WriteLine(Myvalue.ToShortDateString());
            //Console.WriteLine(Myvalue.ToShortTimeString());
            //Console.WriteLine(Myvalue.ToLongDateString());
            //Console.WriteLine(Myvalue.ToLongTimeString());

            //Console.WriteLine(Myvalue.AddDays(3).ToLongDateString());
            //Console.WriteLine(Myvalue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(Myvalue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(Myvalue.Month);

            //DateTime myBirthday = new DateTime(2005, 6, 15);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBrithday = DateTime.Parse("6/15/2005");
            TimeSpan myAge = DateTime.Now.Subtract(myBrithday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
