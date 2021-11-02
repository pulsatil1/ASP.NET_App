using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IRun
    {
        float speed { get; set; }

        void RobotRun();
    }
}
