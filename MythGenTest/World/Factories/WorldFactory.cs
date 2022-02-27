using System;
using System.Collections.Generic;
using MythGenTest.World.Structs;
using MythGenTest.World.Utils;
using MythGenTest.Math;

namespace MythGenTest.World.Factories
{
    public static class WorldFactory
    {
        private static Random _rand = new Random();
        
        public static WorldDescription CreateRandomWorldDescription(string name)
        {
            WorldDensity raceDensity = GenerateRandomDensity("race", WorldStaticData.Races);
            WorldDensity welthDensity = GenerateRandomDensity("welth", WorldStaticData.Welths);
            WorldDensity jobDensity = GenerateRandomDensity("job", WorldStaticData.Jobs);

            return new WorldDescription(name, new WorldDensity[] {raceDensity, welthDensity, jobDensity});
        }

        private static WorldDensity GenerateRandomDensity(string name, string[] possibleValues)
        {
            int count = _rand.Next(1, possibleValues.Length);
            float[] distribution = RandomGenerator.GenerateRandomDistribution(count);
            WorldParam[] worldParams = new WorldParam[count];
            string[] randomSubset =  GetRandomSubset(possibleValues, count);
            for(int i = 0; i < randomSubset.Length; i++)
            {
                worldParams[i] = new WorldParam(randomSubset[i], distribution[i]);
            }

            return new WorldDensity(name, worldParams);
        }

        private static string[] GetRandomSubset(string[] values, int length)
        {
            List<string> possibleValuesList = new List<string>(values);
            List<string> resultValues = new List<string>();
            for (int i = 0; i < length; i++)
            {
                string newValue = possibleValuesList[_rand.Next(0, possibleValuesList.Count)];
                resultValues.Add(newValue);
                possibleValuesList.Remove(newValue);
            }

            return resultValues.ToArray();
        }
    }
}