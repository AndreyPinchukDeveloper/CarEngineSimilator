using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Tests
{
    [TestClass()]
    public class WorkingEngineTest
    {
        #region StartEngineTest(1-5)
        [TestMethod]
        public void StartEngineTest1()
        {
            WorkingEngine workingEngine = new WorkingEngine();
            int testTemperature = -40;
            int testRightTemperature = 101;

            int test1 = workingEngine.StartEngine(testTemperature, testTemperature);
            Assert.AreEqual<int>(testRightTemperature, test1);
        }

        [TestMethod]
        public void StartEngineTest2()
        {
            WorkingEngine workingEngine = new WorkingEngine();
            int testTemperature = 0;
            int testRightTemperature = 101;

            int test1 = workingEngine.StartEngine(testTemperature, testTemperature);
            Assert.AreEqual<int>(testRightTemperature, test1);
        }

        [TestMethod]
        public void StartEngineTest3()
        {
            WorkingEngine workingEngine = new WorkingEngine();
            int testTemperature = 20;
            int testRightTemperature = 101;

            int test1 = workingEngine.StartEngine(testTemperature, testTemperature);
            Assert.AreEqual<int>(testRightTemperature, test1);
        }

        [TestMethod]
        public void StartEngineTest4()
        {
            WorkingEngine workingEngine = new WorkingEngine();
            int testTemperature = 50;
            int testRightTemperature = 17;

            int test1 = workingEngine.StartEngine(testTemperature, testTemperature);
            Assert.AreEqual<int>(testRightTemperature, test1);
        }

        [TestMethod]
        public void StartEngineTest5()
        {
            WorkingEngine workingEngine = new WorkingEngine();
            int testTemperature = 100;
            int testRightTemperature = 5;

            int test1 = workingEngine.StartEngine(testTemperature, testTemperature);
            Assert.AreEqual<int>(testRightTemperature, test1);
        }
        #endregion
    }
}