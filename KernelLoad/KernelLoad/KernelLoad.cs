using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KernelLoad
{
    class KernelLoad
    {
        static void Main(string[] args)
        {
            run();
            Process p;
            void run()
            {
                p = Process.Start("gose.exe");
                check();
            }
            void check()
            {
                while (true)
                {
                    if (p.HasExited)
                    {
                        run();
                    }
                    System.Threading.Thread.Sleep(1);
                }
            }
        }
    }
}
