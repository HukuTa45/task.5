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

            var clients = new Client[]
            {
                new MilitaryClient("Никита","Кузьмин",DateTime.Parse("23.03.2001"),Gun.AK47),
                new CivilianClient("Катя","Корюкина",DateTime.Parse("30.04.2001"),Gun.M4A1,false),
                new CivilianClient("Вася","Пупкин",DateTime.Parse("23.03.2010"),Gun.AK47, true),
                new MilitaryClient("Лола","Родькина",DateTime.Parse("10.07.1999"),Gun.AK47),

            };

            foreach (var client in clients)
                try
                {
                    
                    client.Shoot(warehouse.GetAutomaticRifle(client));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw ;
                }
        }
    }
}