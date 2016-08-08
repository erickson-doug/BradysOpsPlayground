using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotFactory.Models;

namespace RobotFactory.Services
{
    public class MockPersonRepository : IPersonRepository
    {
        public bool CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public bool DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }
    }
}
