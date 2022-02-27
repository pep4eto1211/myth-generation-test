using System;
using MythGenTest.World.Factories;
using MythGenTest.Utils;

namespace MythGenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = WorldFactory.CreateRandomWorldDescription(PlanetNameGenerator.GetPlanetName());
            ConsoleUtils.PrintWorld(p);
        }
    }
}
