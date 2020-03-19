using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;

namespace RestAPIUnitTest
{
    [TestClass]
    public class RestAPI_TestControllerTest
    {
        [TestMethod]
        public void CheckHelloWorldsOne()
        {
            List<RestAPI.Models.Test_Models> helloList = new List<RestAPI.Models.Test_Models>();
            RestAPI.Controllers.TestController helloController = new RestAPI.Controllers.TestController();
            helloList = helloController.getHello();
            Assert.AreEqual(helloList[0].testone, "hello world!");
        }
        [TestMethod]
        public void CheckHelloWorldsTwo()
        {
            List<RestAPI.Models.Test_Models> helloList = new List<RestAPI.Models.Test_Models>();
            RestAPI.Controllers.TestController helloController = new RestAPI.Controllers.TestController();
            helloList = helloController.getHello();
            Assert.AreEqual(helloList[0].testtwo, "Hello World!");
        }
        [TestMethod]
        public void CheckHelloWorldsThree()
        {
            List<RestAPI.Models.Test_Models> helloList = new List<RestAPI.Models.Test_Models>();
            RestAPI.Controllers.TestController helloController = new RestAPI.Controllers.TestController();
            helloList = helloController.getHello();
            Assert.AreEqual(helloList[0].testthree, "Hello Moto!");
        }
        [TestMethod]
        public void CheckHelloWorldsFour()
        {
            List<RestAPI.Models.Test_Models> helloList = new List<RestAPI.Models.Test_Models>();
            RestAPI.Controllers.TestController helloController = new RestAPI.Controllers.TestController();
            helloList = helloController.getHello();
            Assert.AreEqual(helloList[0].testfour, "This Should Fail");
        }
    }
}
