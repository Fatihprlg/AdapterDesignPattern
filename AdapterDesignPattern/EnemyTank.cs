using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class EnemyTank : IEnemy
    {
        public void EnemyName()
        {
            Console.WriteLine("Tank");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Tank accelerated");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Fire!!");
        }
    }
}
