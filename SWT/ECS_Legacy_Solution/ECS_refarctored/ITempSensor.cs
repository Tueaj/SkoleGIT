using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_refarctored
{
    interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
