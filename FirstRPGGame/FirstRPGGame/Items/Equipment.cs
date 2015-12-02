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
        }

        public WearableHead Head { get; private set; }

        public WearableShoulders Shoulders { get; private set; }

        public WearableChest Chest { get; private set; }

        public WearableLegs Legs { get; private set; }

        public WearableHands Hands { get; private set; }

        public WearableFeet Feet { get; private set; }

        public WearableRing Ring { get; private set; }

        public WearableNecklace Necklace { get; private set; }


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
            }

            inventory.Add(switchedItem);

            return inventory;
        } 

    }

}