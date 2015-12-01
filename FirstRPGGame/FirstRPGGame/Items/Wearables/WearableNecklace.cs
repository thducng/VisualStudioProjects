using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame.Items.Wearables
{
    public class WearableNecklace : WearableItem
    {
        public WearableNecklace(string @name, int @rarity)
        {
            Name = @name;
            Rarity = @rarity;
            WearableMaterial = null;
        }
    }
}
