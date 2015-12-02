using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.IO;

namespace FirstRPGGame.CharacterFiles.Classes
{
    public class Archer : Class
    {
        public Archer()
        {
            Image = new BitmapImage(new Uri(Path.GetFullPath("../../Resources/Images/Archer.jpg")));

            Strength = 6;
            Dexterity = 12;
            Intelligence = 5;
            Vitality = 7;

            ClassName = "Archer";
            ClassDescription = "Ranged Physical DPS\n\n" +
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
                    new Skill(this, 2, 1, "Fire Shot", "Coveres the arrowtip in oil and fire", 250, 150),
                    new Skill(this, 2, 1, "Ice Shot", "Coveres the arrowtip in ice", 200, 250),
                    new Skill(this, 5, 1, "Double Shot", "Shoots two powerful arrows", 200, 300),
                    new Skill(this, 10, 1, "Haki Arrow", "Coveres the whole arrow in Armament Haki", 500, 250),

                });
        }
    }
}
