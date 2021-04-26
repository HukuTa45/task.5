using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
	public class CivilianClient : Client
	{
		public bool License;

        public CivilianClient(string name, string surname, DateTime birthDay, Gun requestedWeapon, bool license) : base(name, surname, birthDay, requestedWeapon)
        {
            License = license;
            Name = name;
            Surname = surname;
            RequestedWeapon = requestedWeapon;
            BirthDay = birthDay;
        }
    }
}
