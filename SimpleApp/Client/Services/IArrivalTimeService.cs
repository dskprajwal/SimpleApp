using SimpleApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Client.Services
{
    interface IArrivalTimeService
    {
        List<Arrival> GetAllArrivalTimes();
        List<Arrival> GetArrivalTimeByStopNumberAndCurrentTime(int stopNumber, TimeSpan currentTime);
    }
}
