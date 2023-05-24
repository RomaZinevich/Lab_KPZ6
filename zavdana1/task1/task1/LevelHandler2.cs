using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class LevelHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("Рiвень пiдтримки 2");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
