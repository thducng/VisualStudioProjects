using System.Collections.Generic;

namespace FirstRPGGame.Character.Classes
{
    public class Archer : Class
    {
        public Archer()
        {
            ClassName = "Archer";
            ClassDescription =
                "The archer is fast and stealthy, \n" +
                "they use the bow and arrow to deal physical damage at long range";

            Strength = 6;
            Dexterity = 12;
            Intelligence = 5;
            Vitality = 7;

            MakeSkill();
        }

        private void MakeSkill()
        {
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
