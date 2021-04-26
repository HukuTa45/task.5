using System;

namespace task5
{
    internal class Warehouse
    {
        private AutomaticRifle[] _automaticRifles;

        public Warehouse(AutomaticRifle[] automaticRifles)
        {
           _automaticRifles = automaticRifles;
        }

        public bool GetShoot(Client client)
        {
            if (DateTime.Now.Year - client.BirthDay.Year < 18)
            {
                Console.WriteLine($"Клиенту {client.Name} {client.Surname} нет 18!");
                return false;
            }

            if (client is CivilianClient)
            {
                var civilianclient = (CivilianClient)client;
                if (!civilianclient.License)
                {
                    Console.WriteLine($"У клиента {client.Name} {client.Surname} отсутсвует лицензия!");
                }
                else 
                { 
                    return true; 
                }
            }

            if (client is MilitaryClient)
            {
                return true;
            } 
            return false;
        }

      
    }
}