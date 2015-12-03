using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Classes;
using FirstRPGGame.CharacterFiles.Skills;
using FirstRPGGame.Items;
using FirstRPGGame.Items.Wearables;
using System;

namespace FirstRPGGame.CharacterFiles
{
    [Serializable]
    public class Character
    {
        public Character()
        {
            
        }

        #region Character Stats Properties

        public string CharacterName { get; set; }
        public string ImagePath { get; set; }
        public int CharacterLevel { get; set; }
        public Class CharacterClass { get; set; }

        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int Experience { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public int PhysicalDamage { get; set; }
        public int MagicalDamage { get; set; }

        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }
        
        public int Toughness { get; set; }
        public int Damage { get; set; }

        public Guid Id { get; set; }

        /* 
        -----------------------------------------------------------------------------------------

            CharacterName: Name of the character.

            Class: Character Class.

        -----------------------------------------------------------------------------------------

            HealthPoints: When health points reaches 0 the character dies.

            ManaPoints: Used when casting spells.

            Experience: When this reaches a 100 percentage the character levels up.

        -----------------------------------------------------------------------------------------

            Strength: The primary attribute for Barbarians and Crusaders. 
                      Strength increases Barbarian and Crusader damage, 
                      and increases Armor for all classes.

            Dexterity: The primary attribute for Demon Hunters and Monks. 
                       Dexterity increases Demon Hunter and Monk damage, 
                       and increases Armor for all classes.

            Intelligence: The primary attribute for Witch Doctors and Wizards. 
                          Intelligence increases Witch Doctor and Wizard damage, 
                          and increases resistances for all classes.

            Vitality: Increases Life, the total amount of damage you can suffer before dying.

        -----------------------------------------------------------------------------------------

            Physical Damage: The amount of physical damage you can do when attacking enemies,
                             derived from strength or dexterity and weapons.

            Magical Damage: The amount of magical damage you can do when attacking enemies with spells,
                            derived from intelligence and weapons.

            Physical Defense: The amount of physical attacks you can take from enemy attacks,
                              derived from armour.

            Magical Defense: The amount of magical attacks you can take from enemy spells,
                             derived from armour.

            Toughness: The amount of damage you can take from enemy attacks, 
                       derived from your Life, Armor, Resistances and Dodge score.

            Damage: Indicates the average amount of damage you deal with your attacks. 
                    Damage is derived from your equipped weapons, primary attribute, 
                    attack speed, and critical hit chance.

        -----------------------------------------------------------------------------------------
        */

        #endregion

        #region Character Stats Methods

            #region Public Methods

        public void AssignClass(Class @class)
        {
            CharacterClass = @class;

            Strength += CharacterClass.Strength;
            Dexterity += CharacterClass.Dexterity;
            Intelligence += CharacterClass.Intelligence;
            Vitality += CharacterClass.Vitality;

            ImagePath = CharacterClass.ImagePath;
        }

        public void MakeCharacter()
        {
            CharacterClass = null;
            Inventory = new List<Item>();
            Equipment = new Equipment();
            Skills = new List<Skill>();
            Id = Guid.NewGuid();
        }

        public void UpdateStats()
        {
            PhysicalDamage = DeterminePhysicalDamage();
            MagicalDamage = DetermineMagicalDamage();

            PhysicalDefense = DeterminePhysicalDefense();
            MagicalDefense = DetermineMagicalDefense();

            Toughness = DetermineToughness();
            Damage = DetermineDamage();
        }

            #endregion

            #region Private Methods

        private int DeterminePhysicalDamage()
        {
            return 0;
        }

        private int DetermineMagicalDamage()
        {
            return 0;
        }

        private int DeterminePhysicalDefense()
        {
            return 0;
        }

        private int DetermineMagicalDefense()
        {
            return 0;
        }

        private int DetermineToughness()
        {
            return 0;
        }

        private int DetermineDamage()
        {
            return 0;
        }

        #endregion

        #endregion

        #region Character Item Properties

        public List<Item> Inventory { get ; set; }

        public Equipment Equipment { get; set; }

        #endregion

        #region Character Item Methods

        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public void AddItemToInventory(List<Item> listOfItems)
        {
            Inventory.AddRange(listOfItems);
        }

        public void RemoveItemFromInventory(Item item)
        {
            Inventory.Remove(item);
        }

        public void AddItemToEquipment(WearableItem item)
        {
            Inventory = Equipment.Wear(item, Inventory);
        }

        public void RemoveItemFromEquipment(WearableItem item)
        {
            Inventory = Equipment.TakeOff(item, Inventory);
        }

        #endregion

        #region Character Skill Properties

        public List<Skill> Skills { get; private set; }

        #endregion

        #region Character Skill Methods

        public void AddSkillToCharacter(Skill skill)
        {
            Skills.Add(skill);
        }

        #endregion


    }
}
