using SimpleApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Client.Services
{
    public class ArrivalTimeService : IArrivalTimeService
    {
        public List<Arrival> GetAllArrivalTimes()
        {
            return Arrivals;
        }

        public List<Arrival> GetArrivalTimeByStopNumberAndCurrentTime(int stopNumber, TimeSpan currentTime)
        {
            List<Arrival> result = new List<Arrival>();
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (var arrival in Arrivals)
            {
                if (!counts.ContainsKey(arrival.RouteNumber))
                {
                    counts.Add(arrival.RouteNumber, 0);
                }

                if (arrival.ArrivalTime > currentTime && arrival.StopNumber == stopNumber)
                {
                    if (counts[arrival.RouteNumber] < 2)
                    {
                        arrival.RemainingTime = arrival.ArrivalTime - currentTime;
                        result.Add(arrival);
                        counts[arrival.RouteNumber]++;
                    }
                }
            }

            return result;
        }

        public List<Arrival> Arrivals { get; set; } = new List<Arrival>()
        {
            //Route 1 data
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 00, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 15, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 30, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 45, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(1, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(2, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(3, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(4, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(5, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(6, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(7, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(8, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(9, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(10, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(11, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(12, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(13, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(14, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(15, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(16, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(17, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(18, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(19, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(20, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(21, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(22, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(23, 47, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 02, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 17, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 32, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 1, ArrivalTime = new TimeSpan(00, 47, 00), StopNumber = 2 },

            //Route 2
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 02, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 17, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 32, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 47, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(1, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(2, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(3, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(4, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(5, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(6, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(7, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(8, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(9, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(10, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(11, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(12, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(13, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(14, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(15, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(16, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(17, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(18, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(19, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(20, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(21, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(22, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(23, 49, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 04, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 19, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 34, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 2, ArrivalTime = new TimeSpan(00, 49, 00), StopNumber = 2 },


            //Route 3 Data
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 04, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 19, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 34, 00), StopNumber = 1 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 49, 00), StopNumber = 1 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(1, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(2, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(3, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(4, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(5, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(6, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(7, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(8, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(9, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(10, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(11, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(12, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(13, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(14, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(15, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(16, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(17, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(18, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(19, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(20, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(21, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(22, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(23, 51, 00), StopNumber = 2 },

            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 06, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 21, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 36, 00), StopNumber = 2 },
            new Arrival { RouteNumber = 3, ArrivalTime = new TimeSpan(00, 51, 00), StopNumber = 2 },

        };
    }
}
