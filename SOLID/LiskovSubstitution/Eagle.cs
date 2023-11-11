using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    public class Eagle : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
