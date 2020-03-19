using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace RestAPI.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        /// <summary>
        /// Returns a list of Hello Worlds!!!!
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public List<Models.Test_Models> getHello()
        {
            List<Models.Test_Models> testList = new List<Models.Test_Models>();
            Models.Test_Models testItem = new Models.Test_Models
            {
                testone = "hello world!",
                testtwo = "Hello World!",
                testthree = "Hello Moto!",
                testfour = "Hello You!"
            };
            testList.Add(testItem);
            return testList;
        }
    }
  
}
