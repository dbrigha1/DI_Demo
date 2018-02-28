using System;
using ControllerDI.Interfaces;

namespace ControllerDI.Services

{
public class SystemDay : IDay
{
    public String Now
    {
        get { return "Using Day Service: " + DateTime.Now.DayOfWeek.ToString(); }
    }
}

}