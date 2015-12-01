using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame.Items.Wearables
{
    public class WearableHands : WearableItem
    {
        public WearableHands(string @name, int @rarity, string @material)
        {
            Name = @name;
            Rarity = @rarity;
            WearableMaterial = @material;
        }
    }
}
