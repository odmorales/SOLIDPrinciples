using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class BadExampleDeveloper : IBadExampleWorker
    {
        public void Work() { /* ... */ }
        public void TakeBreak() { /* ... */ }
        public void AttendMeeting() { /* ... */ }
    }
}
