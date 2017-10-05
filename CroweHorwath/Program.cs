using CroweHorwath.Controllers;
using System;

namespace CroweHorwath
{
    class Program
    {
        static void Main(string[] args)
        {
            var howdyWorld = new HelloWorldAPIController();
            Console.WriteLine(howdyWorld.GetHelloWorld("Crowe Horwath").Value);
            Console.ReadKey();
        }
    }
}
