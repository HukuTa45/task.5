using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace task5
{
	class MilitaryClient : Client
	{
         Rank currentRank { get; }

        public MilitaryClient(string name, string surname, DateTime birthDay, Gun requestedWeapon, Rank rank) : base(name, surname, birthDay, requestedWeapon)
        {
            currentRank = rank;
            Name = name;
            Surname = surname;
            RequestedWeapon = requestedWeapon;
            BirthDay = birthDay;
        }

    }
}
