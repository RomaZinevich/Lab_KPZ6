using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class LevelHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 3)
            {
                Console.WriteLine("Рiвень пiдтримки 3");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
