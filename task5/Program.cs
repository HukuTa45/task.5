using System;

namespace task5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var warehouse = new Warehouse(
                new[]
                {
                    new AutomaticRifle(Gun.AK47),
                    new AutomaticRifle(Gun.M4A1)
                });

            var clients = new[]
            {
                new Client("Никита", "Кузьмин", DateTime.Parse("23.03.2001"), true, false, Gun.AK47),
                new Client("Елизавета", "Елькина", DateTime.Parse("23.03.2010"), false, false, Gun.AK47),
                new Client("Алена", "Кузьмина", DateTime.Parse("14.11.1999"), true, true, Gun.M4A1),
                new Client("Максим", "Петров", DateTime.Parse("06.10.1995"), false, true, Gun.M4A1)
            };

            foreach (var client in clients)
                try
                {
                    client.Shoot(warehouse.GetAutomaticRifle(client));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
        }
    }
}