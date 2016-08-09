using RobotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory.Services
{
    public interface IRobotFactory
    {
        bool AttachRobot(Robot robot);
        bool DetachRobot(int robotId);
        bool RechargeRobot(int robotId);
        bool UseRobot(int robotId);
        event EventHandler<Robot> RobotUsed;
    }
}
