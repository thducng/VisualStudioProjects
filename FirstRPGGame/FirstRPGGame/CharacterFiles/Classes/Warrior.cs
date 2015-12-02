using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.IO;

namespace FirstRPGGame.CharacterFiles.Classes
{
    public class Warrior : Class
    {
        public Warrior()
        {
            Image = new BitmapImage(new Uri(Path.GetFullPath("../../Resources/Images/Warrior.jpg")));

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
            Skills.AddRange
                (new List<Skill>()
                {
                    new Skill(this, 2, 1, "Power Blow", "Thrusting your weapon straight at the enemy", 250, 150),
                    new Skill(this, 2, 1, "Great Swing", "Swings your weapon into the enemy", 200, 250),
                    new Skill(this, 5, 1, "Seismic Slam", "Jumps and swings the your weapon down", 200, 300),
                    new Skill(this, 10, 1, "Conquers Roar", "A mighty roar that even the big dragons of time fear", 500, 250),

                });
        }
    }
}
