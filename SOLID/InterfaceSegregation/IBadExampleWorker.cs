﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public interface IBadExampleWorker
    {
        void Work();
        void TakeBreak();
        void AttendMeeting();
    }
}
