using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class LevelHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("Рiвень пiдтримки 1");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
