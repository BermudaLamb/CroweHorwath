using CroweHorwath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.Controllers
{
    public class HelloWorldController
    {
        public HelloWorld HelloWorld;
        public HelloWorldController()
        {
            HelloWorld = new HelloWorld();
        }

        public virtual HelloWorld GetHelloWorld()
        {
            return HelloWorld;
        }
    }
}
