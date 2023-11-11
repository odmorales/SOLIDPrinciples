using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    public class Penguin : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Swimming, not flying");
        }
    }
}
