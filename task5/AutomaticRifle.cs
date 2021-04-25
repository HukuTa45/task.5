using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace task5
{
    public class AutomaticRifle
    {
        public Gun Gun;

        public AutomaticRifle(Gun gun)
        {
            Gun = gun;
        }

        public bool isGun(Gun gun)
        {
            return Gun == gun;
        }

        public void Shoot()
        {
            Console.WriteLine($"{Gun} делает выстрел");
        }
    }
}
