using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }             
        public Gun RequestedWeapon { get; set; }
     

		public Client(string name, string surname, DateTime birthDay, Gun requestedWeapon)
		{
			Name = name;
			Surname = surname;
			BirthDay = birthDay;
			RequestedWeapon = requestedWeapon;
		}

		public void Shoot(bool shootPermission,Gun gun)
        {
            if (shootPermission)
            {
                Console.WriteLine($"Клиент {Name} {Surname} делает выстрел из {gun}");
            }
            
        }
    }

}

