﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    public class BadPenguin : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins cannot fly");
        }
    }
}
