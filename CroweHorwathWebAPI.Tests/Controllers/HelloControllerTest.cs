using CroweHorwath.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweHorwathWebAPI.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void GetHelloWorld()
        {
            var helloWorldController = new HelloWorldController();

            var HelloWorld = helloWorldController.GetHelloWorld();

            Assert.IsNotNull(HelloWorld);

            StringAssert.Equals("Hello World", HelloWorld.Value);
        }
    }
}
