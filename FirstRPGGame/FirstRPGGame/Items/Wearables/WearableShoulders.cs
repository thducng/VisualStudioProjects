namespace FirstRPGGame.Items.Wearables
{
    public class WearableShoulders : WearableItem
    {
        public void MakeItem(string @name, int @rarity, string @material)
        {
            Name = @name;
            Rarity = @rarity;
            WearableMaterial = @material;
        }
    }
}
