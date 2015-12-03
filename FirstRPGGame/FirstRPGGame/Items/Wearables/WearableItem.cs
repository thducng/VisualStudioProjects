namespace FirstRPGGame.Items.Wearables
{
    public class WearableItem : Item
    {
        public int Rarity { get; set; } // White 1, Blue 2, Purple 3, Orange 4. higher better

        public string WearableMaterial { get; set; } // Plate, Leather etc.

        public string WeaponType { get; set; }

        public bool WeaponTwoHanded { get; set; }
    }
}
