using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECS_refarctored;
using NUnit.Framework;
using ECS.refarctored;

namespace ECS_Test
{
   
    public class UnitTest1
    {

        private ECS.refarctored.EECS UUT1;

        [SetUp]
        public void Setup()
        {
            UUT1 = new ECS.refarctored.EECS(20, new FakeTempSensor(), new FakeHeater());
        }

            [TestCase(2,3)]

            public void Test1(int a, int b)
            {
            
            UUT1.Regulate();
        
            }
    }
}
