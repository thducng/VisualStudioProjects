using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame.Items.Wearables
{
    public class WearableLeftHandWeapon : WearableItem
    {
        public void MakeItem(string @name, int @rarity, string @weaponType)
        {
            Name = @name;
            Rarity = @rarity;
            WeaponType = @weaponType;
        }
    }
}
