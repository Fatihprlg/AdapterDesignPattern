using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class EnemyAdapter : IEnemy
    {
        EnemyRobot enemyRobot = new EnemyRobot();
        public void EnemyName()
        {
            enemyRobot.RobotName();
        }

        public void SpeedUp()
        {
            enemyRobot.Walk();
        }

        public void UseWeapon()
        {
            enemyRobot.Punch();
        }
    }
}
