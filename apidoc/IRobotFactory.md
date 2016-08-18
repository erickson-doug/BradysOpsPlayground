---
uid: RobotFactory.Services.IRobotFactory
summary: This is the summary for the Robot Factory service interface.
remarks: *content
---

### Lorem Ipsum
The IRobotFactory provides a contract that any Robot Factory implementor must fulfill. Each factory must enable a coding workflow like the sample shown below. 

    public void Simulation(IRobotFactory factory)
    {
        var robot = new Robot {
            Id = 42,
            Name = "Sweeping Bot",
            BatteryLeft = 90
        };

        if(factory.AttachRobot(robot))
        {
            while(robot.BatteryLeft > 0)
            {
                if(robot.BatteryLeft > 10)
                {
                    factory.UseRobot(robot.Id);
                }
                else
                    factory.RechargeRobot(robot.Id);
            }

            factory.DetachRobot(robot.Id);
        }
    }

---
uid: RobotFactory.Services.IRobotFactory.DetachRobot(System.Int32)
summary: Use this method **only** when you seriously want to detach the robot and let it go home for the rest of the day. 
---

---
uid: RobotFactory.Services.IRobotFactory.RechargeRobot(System.Int32)
remarks: *content 
---

## How Recharging Works
In this way an author has been able to add more rich documentation with multiple sections. The author or contributor could even add images depicting how the particular object's member functions. 

![Robo Recharging](../images/recharge-robot.jpg)

