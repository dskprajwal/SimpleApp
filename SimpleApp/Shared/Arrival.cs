using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp.Shared
{
    public class Arrival
    {
        public int RouteNumber { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int StopNumber { get; set; }
        public TimeSpan RemainingTime { get; set; }
    }
}
