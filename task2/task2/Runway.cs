using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    public class Runway
    {
        public int Id;
        public bool IsBusyWithAircraft;
        protected CommandCentre commandCentre;

        public Runway(int id, CommandCentre commandCentre)
        {
            Id = id;
            IsBusyWithAircraft = false;
            this.commandCentre = commandCentre;
        }

        public bool CheckIsActive()
        {
            return commandCentre.CheckIsActive(this);
        }


        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }

}
