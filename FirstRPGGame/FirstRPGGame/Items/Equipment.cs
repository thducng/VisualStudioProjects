using System.Collections.Generic;
using FirstRPGGame.Items.Wearables;

namespace FirstRPGGame.Items
{
    public class Equipment
    {

        public Equipment()
        {
            Head = null;
            Shoulders = null;
            Chest = null;
            Legs = null;
            Hands = null;
            Feet = null;
            Ring = null;
            Necklace = null;
            RightHandWeapon = null;
            LeftHandWeapon = null;
        }

        public WearableHead Head { get; set; }

        public WearableShoulders Shoulders { get; set; }

        public WearableChest Chest { get; set; }

        public WearableLegs Legs { get; set; }

        public WearableHands Hands { get; set; }

        public WearableFeet Feet { get; set; }

        public WearableRing Ring { get; set; }

        public WearableNecklace Necklace { get; set; }

        public WearableItem RightHandWeapon { get; set; }

        public WearableItem LeftHandWeapon { get; set; }


        public List<Item> Wear(WearableItem item, List<Item> inventory)
        {
            Item switchedItem = new Item();

            switch(item.GetType().ToString())
            {
                case "WearableHead":
                    switchedItem = Head;
                    Head = item as WearableHead;
                    break;
                case "WearableShoulders":
                    switchedItem = Shoulders;
                    Shoulders = item as WearableShoulders;
                    break;
                case "WearableChest":
                    switchedItem = Chest;
                    Chest = item as WearableChest;
                    break;
                case "WearableLegs":
                    switchedItem = Legs;
                    Legs = item as WearableLegs;
                    break;
                case "WearableHands":
                    switchedItem = Hands;
                    Hands = item as WearableHands;
                    break;
                case "WearableFeet":
                    switchedItem = Feet;
                    Feet = item as WearableFeet;
                    break;
                case "WearableRing":
                    switchedItem = Ring;
                    Ring = item as WearableRing;
                    break;
                case "WearableNecklace":
                    switchedItem = Necklace;
                    Necklace = item as WearableNecklace;
                    break;
                case "WearableRightHandWeapon":                
                    switchedItem = RightHandWeapon;
                    RightHandWeapon = item as WearableRightHandWeapon;
                    if (RightHandWeapon.WeaponTwoHanded)
                    {
                        inventory.Add(LeftHandWeapon);
                        LeftHandWeapon = null;
                    }
                    break;
                case "WearableLeftHandWeapon":
                    switchedItem = LeftHandWeapon;
                    LeftHandWeapon = item as WearableLeftHandWeapon;
                    break;
            }

            inventory.Add(switchedItem);

            return inventory;
        }

        public List<Item> TakeOff(WearableItem item, List<Item> inventory)
        {
            Item switchedItem = new Item();

            switch (item.GetType().ToString())
            {
                case "WearableHead":
                    switchedItem = Head;
                    Head = null;
                    break;
                case "WearableShoulders":
                    switchedItem = Shoulders;
                    Shoulders = null;
                    break;
                case "WearableChest":
                    switchedItem = Chest;
                    Chest = null;
                    break;
                case "WearableLegs":
                    switchedItem = Legs;
                    Legs = null;
                    break;
                case "WearableHands":
                    switchedItem = Hands;
                    Hands = null;
                    break;
                case "WearableFeet":
                    switchedItem = Feet;
                    Feet = null;
                    break;
                case "WearableRing":
                    switchedItem = Ring;
                    Ring = null;
                    break;
                case "WearableNecklace":
                    switchedItem = Necklace;
                    Necklace = null;
                    break;
                case "WearableRightHandWeapon":
                    switchedItem = RightHandWeapon;
                    RightHandWeapon = null;
                    break;
                case "WearableLeftHandWeapon":
                    switchedItem = LeftHandWeapon;
                    LeftHandWeapon = null;
                    break;
            }

            inventory.Add(switchedItem);

            return inventory;
        } 

    }

}