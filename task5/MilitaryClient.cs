using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
	class MilitaryClient : Client
	{
        public MilitaryClient(string name, string surname, DateTime birthDay, Gun requestedWeapon) : base(name, surname, birthDay, requestedWeapon)
        {

        }
    }
}
