using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void CommandLand(Aircraft aircraft)
        {
            foreach (var runway in this._runways)
            {
                if (runway.IsBusyWithAircraft == false)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusyWithAircraft = true;
                    runway.HighLightRed();
                    aircraft.CurrentRunway = runway.Id;
                    break;
                }
                else if (runway.IsBusyWithAircraft == true)
                {
                    Console.WriteLine($"Could not land, the runway is busy.");
                }
            }
        }

        public void CommandTakeOff(Aircraft aircraft)
        {
            foreach (var runway in this._runways)
            {
                if (runway.Id == aircraft.CurrentRunway)
                {
                    runway.IsBusyWithAircraft = false;
                    aircraft.CurrentRunway = 0;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                }
            }
        }

        public bool CheckIsActive(Runway runway)
        {
            bool result = false;
            foreach (var aircraft in _aircrafts)
            {
                if (aircraft.CurrentRunway == runway.Id && runway.IsBusyWithAircraft != false)
                {
                    result = aircraft.IsTakingOff;
                }

            }
            return result;

        }
    }
}
