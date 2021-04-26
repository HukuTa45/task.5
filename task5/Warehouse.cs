using System;

namespace task5
{
    internal class Warehouse
    {
        public AutomaticRifle[] automaticRifles;

        public Warehouse(AutomaticRifle[] automaticRifles)
        {
            this.automaticRifles = automaticRifles;
        }

        public AutomaticRifle GetAutomaticRifle(Client client)
        {
            if (DateTime.Now.Year - client.BirthDay.Year < 18)
                throw new Exception("Клиенту нет 18!");

            if (client is CivilianClient)
            {
                var civilianclient = (CivilianClient)client;
                if (!civilianclient.License)
                {
                    throw new Exception("У клиента отсутсвует лицензия!");
                }
                return GetAutomaticRifle(client.RequestedWeapon);
            }

            if (client is MilitaryClient)
            {
                return GetAutomaticRifle(client.RequestedWeapon);
            }
            return GetAutomaticRifle(client.RequestedWeapon);
        }

        public AutomaticRifle GetAutomaticRifle(Gun gun)
        {
            foreach (var automaticRifle in automaticRifles)
                if (automaticRifle.isGun(gun))
                    return automaticRifle;
            throw new Exception("Нет запрашиваемого оружия!");
        }
    }
}