namespace FirstRPGGame.Items.Wearables
{
    public class WearableHead : WearableItem
    {
        public WearableHead(string @name, int @rarity, string @material)
        {
            Name = @name;
            Rarity = @rarity;
            WearableMaterial = @material;
        }
    }
}
