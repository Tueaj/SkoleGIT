using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ECS_refarctored;

namespace ECS_Test
{
    internal class FakeTempSensor : ITempSensor
    {


        public int temp { get; set; }
        public int GetTemp()
        {
          
            return temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
