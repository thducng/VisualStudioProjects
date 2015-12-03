﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame.Items.Wearables
{
    public class WearableRightHandWeapon : WearableItem
    {
        public WearableRightHandWeapon(string @name, int @rarity, string @weaponType, bool @weaponTwoHanded = false)
        {
            Name = @name;
            Rarity = @rarity;
            WeaponType = @weaponType;
            WeaponTwoHanded = @weaponTwoHanded;
        }
    }
}
