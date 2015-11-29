using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class Character
    {
        public Character(string @characterName, BaseRace @race)
        {
            CharacterName = @characterName;
            Race = @race;

            Inventory = new List<Item>();
        }

        #region Character Stats Properties

        public string CharacterName { get; }
        public BaseClass Class { get; private set; }
        public BaseRace Race { get; }

        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public double Experience { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public double PhysicalDamage { get; set; }
        public double MagicalDamage { get; set; }

        public double PhysicalDefense { get; set; }
        public double MagicalDefense { get; set; }
        
        public double Toughness { get; set; }
        public double Damage { get; set; }

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

        public void AssignClass(BaseClass @class)
        {
            Class = @class;

            Strength += Class.Strength;
            Dexterity += Class.Dexterity;
            Intelligence += Class.Intelligence;
            Vitality += Class.Vitality;
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

        private double DeterminePhysicalDamage()
        {
            return 0.0;
        }

        private double DetermineMagicalDamage()
        {
            return 0.0;
        }

        private double DeterminePhysicalDefense()
        {
            return 0.0;
        }

        private double DetermineMagicalDefense()
        {
            return 0.0;
        }

        private double DetermineToughness()
        {
            return 0.0;
        }

        private double DetermineDamage()
        {
            return 0.0;
        }

        #endregion

        #endregion

        #region Character Inventory Properties

        public List<Item> Inventory { get ; private set; }

        #endregion

    }
}
