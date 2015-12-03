using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.IO;
using System.Xml.Serialization;

namespace FirstRPGGame.CharacterFiles.Classes
{
    [Serializable]
    public class Warrior : Class
    {
        public Warrior()
        {
            
        }

        public void MakeClass()
        {
            ImagePath = Path.GetFullPath("../../Resources/Images/Warrior.jpg");

            Strength = 11;
            Dexterity = 6;
            Intelligence = 5;
            Vitality = 8;

            ClassName = "Warrior";
            ClassDescription = "Melee Physical DPS\n\n" +
                               "Start Stats:\n\n" +
                               "Strength: " + Strength + "\n" +
                               "Dexterity: " + Dexterity + "\n" +
                               "Intelligence: " + Intelligence + "\n" +
                               "Vitality: " + Vitality + "\n";

            MakeSkill();
        }

        private void MakeSkill()
        {
            Skills = new List<Skill>();
            Skill newSkill = new Skill();

            newSkill.MakeSkill(this, 2, 1, "Power Blow", "Thrusting your weapon straight at the enemy", 250, 150);
            Skills.Add(newSkill);

            newSkill.MakeSkill(this, 2, 1, "Great Swing", "Swings your weapon into the enemy", 200, 250);
            Skills.Add(newSkill);

            newSkill.MakeSkill(this, 5, 1, "Seismic Slam", "Jumps and swings the your weapon down", 200, 300);
            Skills.Add(newSkill);

            newSkill.MakeSkill(this, 10, 1, "Conquers Roar", "A mighty roar that even the big dragons of time fear", 500, 250);
            Skills.Add(newSkill);
        }
    }
}
