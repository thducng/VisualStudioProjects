using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.IO;

namespace FirstRPGGame.CharacterFiles.Classes
{
    public class Monk : Class
    {
        public Monk()
        {
            Image = new BitmapImage(new Uri(Path.GetFullPath("../../Resources/Images/Monk.jpg")));

            Strength = 8;
            Dexterity = 7;
            Intelligence = 5;
            Vitality = 10;

            ClassName = "Monk";
            ClassDescription = "Melee Physical DPS/Tank\n\n" +
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
            Skills.AddRange
                (new List<Skill>()
                {
                    new Skill(this, 2, 1, "Holy Fist", "Charges the enemy with a holy fist knuckle", 250, 150),
                    new Skill(this, 2, 1, "Smite", "Calls forth a beam of lite to smite the enemy", 200, 250),
                    new Skill(this, 5, 1, "Buddha Palm", "Holy high hand from above strike the enemy", 200, 300),
                    new Skill(this, 10, 1, "Ninety-Ninth Hand", "Summons Bodhisattva to hit with multiple palm at once", 500, 250),

                });
        }
    }
}
