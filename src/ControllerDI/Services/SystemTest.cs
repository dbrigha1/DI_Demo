using ControllerDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerDI.Services
{
    public class SystemTest : IDay
    {
        string IDay.Now => throw new NotImplementedException();

        public String Now()
        {
            return "Test";
        }
    }
}
