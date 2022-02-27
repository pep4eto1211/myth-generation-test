namespace MythGenTest.World.Structs
{
    public struct WorldDensity
    {
        public WorldDensity(string name, WorldParam[] parameters)
        {
            DensityName = name;
            DensityParameters = parameters;
        }
        public string DensityName;
        public WorldParam[] DensityParameters;
    }
}