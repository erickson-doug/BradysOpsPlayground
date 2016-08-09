using RobotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory.Services
{
    public interface IPersonRepository
    {
        IEnumerable<Robot> GetPeople();
        bool CreatePerson(Robot person);
        bool DeletePerson(int personId);
    }
}
