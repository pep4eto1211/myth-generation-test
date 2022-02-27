using System;
using Figgle;
using MythGenTest.World.Structs;

namespace MythGenTest.Utils
{
    public static class ConsoleUtils
    {
        public static void PrintWorld(WorldDescription world)
        {
            PrintLine();
            Console.WriteLine(FiggleFonts.Standard.Render(world.Name));
            PrintLine();
            Console.WriteLine("World description:");
            foreach(var distribution in world.WorldDensities)
            {
                Console.WriteLine($"Distribution of {distribution.DensityName} is:");
                foreach(var parameter in distribution.DensityParameters)
                {
                    Console.Write($"|{parameter.ParamName} : {parameter.Weight}");
                }
                Console.WriteLine("|");
            }
            PrintLine();
        }

        public static void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}