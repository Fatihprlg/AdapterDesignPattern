using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class Enemy
    {
        public IEnemy enemy;
        public Enemy(int choice)
        {

            if(choice == 1)
            {
                enemy = new EnemyTank();
            }
            else if(choice == 2)
            {
                enemy = new EnemyAdapter();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
