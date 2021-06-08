using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class EnemyRobot
    {

        public void RobotName()
        {
            Console.WriteLine("Robot");
        }

        public void Walk()
        {
            Console.WriteLine("Robot walking");
        }

        public void Punch()
        {
            Console.WriteLine("Robot punched!");
        }
    }
}
