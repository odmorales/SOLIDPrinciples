using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependecyInjection
{
    public class GoodExampleLight
    {
        private ILight sw;

        public GoodExampleLight(ILight sw)
        {
            this.sw = sw;
        }

        public void TurnOn()
        {
            sw.TurnOn();
        }
    }
}
