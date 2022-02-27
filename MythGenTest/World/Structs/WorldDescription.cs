namespace MythGenTest.World.Structs
{
    public struct WorldDescription
    {
        public WorldDescription(string name, WorldDensity[] densities)
        {
            Name = name;
            WorldDensities = densities;
        }
        public string Name;
        public WorldDensity[] WorldDensities;
    }
}