using System.Collections.Generic;

namespace FirstRPGGame.Character.Classes
{
    public class Monk : Class
    {
        public Monk()
        {
            ClassName = "Monk";
            ClassDescription =
                "The Monk has patients and rarely gets angry, \n" +
                "but when he does his combat skills are strong";

            Strength = 8;
            Dexterity = 7;
            Intelligence = 5;
            Vitality = 10;

            MakeSkill();
        }

        private void MakeSkill()
        {
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
