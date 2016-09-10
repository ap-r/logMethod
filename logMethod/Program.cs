using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace logMethod
{
    class Program
    {
        
        static void Main(string[] args)
        {
            new Program().GiveNothing();
            Console.ReadLine();
        }
        public int GiveNothing()
        {
            LogMethodIn(MethodBase.GetCurrentMethod());
            
            int nothing = 0;

            LogMethodOut(MethodBase.GetCurrentMethod());
            if (nothing == 0)
                return nothing;
            else
                return 0;

        }
        public void LogMethodIn(MethodBase mb)
        {
            Console.WriteLine("Method " + mb.Name.ToString() + "() have just started.");
        }
        public void LogMethodOut(MethodBase mb)
        {
            Console.WriteLine("Method " + mb.Name.ToString() + "() is going to end.");
        }
 
 
    }
}
