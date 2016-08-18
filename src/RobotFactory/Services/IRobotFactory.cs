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
        /// <summary>
        /// Attach the robot to the assembly line.
        /// </summary>
        /// <param name="robot">The <paramref name="robot"/> parameter is the robot you want to install.</param>
        /// <returns></returns>
        bool AttachRobot(Robot robot);
        bool DetachRobot(int robotId);
        bool RechargeRobot(int robotId);
        bool UseRobot(int robotId);

        /// <summary>
        /// Method used to simply test out the <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type to be handled.</typeparam>
        /// <param name="input">The instance to pass in.</param>
        void SomeGenericMethod<T>(T input);

        event EventHandler<Robot> RobotUsed;
    }
}
