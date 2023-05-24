using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Aircraft
    {
        public string Name;
        protected CommandCentre commandCentre;
        public int CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }
        public Aircraft(string name, CommandCentre commandCentre)
        {
            this.Name = name;
            CurrentRunway = 0;
            this.commandCentre = commandCentre;

        }
        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            Console.WriteLine($"Checking runway.");
            commandCentre.CommandLand(this);
        }
        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            commandCentre.CommandTakeOff(this);
        }
    }
}
