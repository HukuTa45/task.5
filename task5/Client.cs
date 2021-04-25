using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    public class Client
    {
        public string Name { get; }
        public string Surname { get; }
        public DateTime BirthDay { get; }
        public bool License { get; }
        public bool Military { get; }
        public Gun RequestedWeapon { get; }


        public Client(string name, string surname, DateTime birthDay, bool license, bool military, Gun requestedWeapon)
        {
            Name = name;
            Surname = surname;
            License = license;
            Military = military;
            RequestedWeapon = requestedWeapon;
            BirthDay = birthDay;
        }

        public void Shoot(AutomaticRifle automaticRifle)
        {
            Console.WriteLine($"{Name} {Surname} делает выстрел");
            automaticRifle.Shoot();
        }
    }

}

