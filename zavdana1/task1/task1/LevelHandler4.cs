using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class LevelHandler4 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 4)
            {
                Console.WriteLine("Рiвень пiдтримки 4");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
