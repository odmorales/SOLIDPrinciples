using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependecyInjection
{
    internal class BadExampleLight
    {
        private BadExampleSwitch sw = new BadExampleSwitch();
        public void TurnOn()
        {
            sw.Activate();
        }
    }
}
