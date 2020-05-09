namespace ZonaHorariaAzure
{
    using System;
    using System.Linq;

    public static class Program
    {
        private static void Main(string[] args)
        {
            var timeZones = System.TimeZoneInfo.GetSystemTimeZones().Select(x => new { x.BaseUtcOffset, x.Id }).ToList();

            foreach (var item in timeZones)
            {
                Console.WriteLine($"Hora: {item.BaseUtcOffset.Hours} Zona horaria: {item.Id}");
            }
            Console.ReadLine();
            //para colombia se escoge la zona horaria SA Pacific Standard Time
            //en azure se debe configurar la variable de ambiente WEBSITE_TIME_ZONE
            /*
             SA Pacific Standard Time

             Pacific SA Standard Time
             E. South America Standard Time
             Pacific Standard Time
             */
            Console.WriteLine("Hello World!");
        }
    }
}
