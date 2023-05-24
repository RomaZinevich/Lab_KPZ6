﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   public abstract class Handler
   {
       protected Handler successor;

       public void SetSuccessor(Handler successor)
       {
           this.successor = successor;
       }

       public abstract void HandleRequest(int request);
   }
}
