using System;
using ECS_refarctored;

namespace ECS.Legacy
{
    internal class TempSensor : ITempSensor
    {
        public int GetTemp()
        {
            //Mangler implementering af hardware
            return 0;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}