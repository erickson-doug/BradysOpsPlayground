using RobotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory.Services
{    
    /// <summary>
    /// This is the developer-supplied summary. No one will ever see it as long as there's a remarks override. 
    /// </summary>
    public interface IRobotFactory
    {
        bool AttachRobot(Robot robot);
        bool DetachRobot(int robotId);
        bool RechargeRobot(int robotId);
        bool UseRobot(int robotId);
        event EventHandler<Robot> RobotUsed;
    }
}
