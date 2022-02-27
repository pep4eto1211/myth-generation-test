using System;
using System.Collections.Generic;

namespace MythGenTest.Math
{
    public static class RandomGenerator
    {
        public static float[] GenerateRandomDistribution(int length)
        {
            Random rand = new Random();
            float[] result = new float[length];
            List<float> numbers = new List<float>();
            for(int i = 0; i < length - 1; i++)
            {
                numbers.Add((float)rand.NextDouble());
            }

            numbers.Add(1);
            numbers.Add(0);
            numbers.Sort();
            for(int i = 0; i < length; i++)
            {
                result[i] = numbers[i+1] - numbers[i];
            }

            return result;
        }
    }
}