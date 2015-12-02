using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.IO;

namespace FirstRPGGame.CharacterFiles.Classes
{
    public class Wizard : Class
    {
        public Wizard()
        {
            Image = new BitmapImage(new Uri(Path.GetFullPath("../../Resources/Images/Wizard.jpg")));

            Strength = 5;
            Dexterity = 5;
            Intelligence = 14;
            Vitality = 6;

            ClassName = "Wizard";
            ClassDescription = "Ranged Magical DPS\n\n" +
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
                    new Skill(this, 2, 1, "Fireball", "Element spell that deals fire damage", 250, 150),
                    new Skill(this, 2, 1, "Iceball", "Element spell that deals frost damage", 200, 250),
                    new Skill(this, 5, 1, "Tornado", "Creates tornadoes to throw the enemy around", 200, 300),
                    new Skill(this, 10, 1, "Black Hole", "Summons a black hole to suck in the enemy", 500, 250),

                });
        }
    }
}
