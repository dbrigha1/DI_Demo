using System;
using ControllerDI.Interfaces;

namespace ControllerDI.Services
{
    public class SystemDateTime : IDateTime
    {
        public String Now
        {
            get {
                DateTime serverTime = DateTime.Now;
                String timeOfDay;
                if (serverTime.Hour < 12)
                {
                    timeOfDay = "Using DateTime Service: It's morning here - Good Morning!";
                }
                else if (serverTime.Hour < 17)
                {
                    timeOfDay = "Using DateTime Service: It's afternoon here - Good Afternoon!";
                }
                else
                {
                    timeOfDay = "Using DateTime Service: It's evening here - Good Evening!";
                }
                return timeOfDay;
            }
        }
    }
}

