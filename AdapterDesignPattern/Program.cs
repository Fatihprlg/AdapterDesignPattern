using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Select enemy type\n  1. Tank\n  2. Robot");
            int choice = Convert.ToInt32(Console.ReadLine());
            Enemy newEnemy = new Enemy(choice);
            if (newEnemy.enemy != null)
            {
                newEnemy.enemy.EnemyName();
                newEnemy.enemy.SpeedUp();
                newEnemy.enemy.UseWeapon();
            }

        }
    }
}
