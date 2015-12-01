namespace FirstRPGGame.Items.Wearables
{
    public class WearableShoulders : WearableItem
    {
        public WearableShoulders(string @name, int @rarity, string @material)
        {
            Name = @name;
            Rarity = @rarity;
            WearableMaterial = @material;
        }
    }
}
