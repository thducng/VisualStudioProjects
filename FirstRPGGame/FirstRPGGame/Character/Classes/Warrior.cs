using System.Collections.Generic;

namespace FirstRPGGame.Character.Classes
{
    public class Warrior : Class
    {
        public Warrior()
        {
            ClassName = "Warrior";
            ClassDescription =
                "Warrior is the born strong and powerful, \n" +
                "they are melee and can deal alot of damage og take alot of damage";

            Strength = 11;
            Dexterity = 6;
            Intelligence = 5;
            Vitality = 8;

            MakeSkill();
        }

        private void MakeSkill()
        {
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
