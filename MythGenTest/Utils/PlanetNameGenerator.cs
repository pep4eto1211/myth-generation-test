using System;
using System.Linq;
using Markov;

using MythGenTest.Utils;

namespace MythGenTest.Utils
{
    public static class PlanetNameGenerator
    {
        private static MarkovChain<char> _chain;
        private static Random _random;
        
        static PlanetNameGenerator()
        {
            _chain = new MarkovChain<char>(4);
            _random = new Random();

            foreach (var trainingName in PlanetNameMarkovStaticData.TrainingPlanetNames)
            {
                _chain.Add(trainingName);
            }
        }

        public static string GetPlanetName()
        {
            return new string(_chain.Chain(_random).ToArray());
        }

        public static string GetPlanetName(int seed)
        {
            return new string(_chain.Chain(seed).ToArray());
        }
    }
}