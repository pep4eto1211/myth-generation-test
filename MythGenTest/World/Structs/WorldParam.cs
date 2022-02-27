namespace MythGenTest.World.Structs
{
    public struct WorldParam
    {
        public WorldParam(string name, float weight)
        {
            ParamName = name;
            Weight = weight;
        }

        public string ParamName;
        public float Weight;
    }
}