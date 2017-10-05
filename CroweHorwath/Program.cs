using CroweHorwath.Models;
using System;

namespace CroweHorwath
{
    class Program
    {
        static void Main(string[] args)
        {
            var howdyWorld = new HelloWorld();
            Console.WriteLine(howdyWorld.Value);
            Console.ReadKey();
        }
    }
}
