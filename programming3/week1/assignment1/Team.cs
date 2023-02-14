using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Team
    {
        List<Programmer> programmers;
        public Team()
        {
            programmers = new List<Programmer>();
        }
        public void PrintAllTeamMembers()
        {
            foreach(Programmer programmer in programmers)
            {
                programmer.Print();
            }
        }
        public void AddProgrammger(Programmer p1)
        {
            programmers.Add(p1);
        }
    }
}
