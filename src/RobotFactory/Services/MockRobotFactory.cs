using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotFactory.Models;

namespace RobotFactory.Services
{
    public class MockRobotFactory : IRobotFactory
    {
        public List<Robot> _robots { get; private set; }

        public event EventHandler<Robot> RobotUsed;

        public bool AttachRobot(Robot robot)
        {
            _robots.Add(robot);
            return true;
        }

        public bool DetachRobot(int robotId)
        {
            _robots.Remove(_robots.First(x => x.Id == robotId));
            return true;
        }

        public bool RechargeRobot(int robotId)
        {
            _robots.First(x => x.Id == robotId).BatteryLeft = 100;
            return true;
        }

        public void SomeGenericMethod<T>(T input)
        {
            throw new NotImplementedException();
        }

        public bool UseRobot(int robotId)
        {
            if (_robots.First(x => x.Id == robotId).BatteryLeft > 10)
            {
                _robots.First(x => x.Id == robotId).BatteryLeft -= 10;
                return true;
            }
            else
                return false;
        }
    }
}
