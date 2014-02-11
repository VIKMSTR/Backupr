using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backupr
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Equals("-g"))
                {
                    //launch gui
                    Console.WriteLine("launching gui");
                }
            }
            else
            {
                Console.WriteLine("No arguments specified, launched with latest settings in console mode");
            }
        }
    }
}
