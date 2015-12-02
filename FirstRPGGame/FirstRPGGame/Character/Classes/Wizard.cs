using System.Collections.Generic;

namespace FirstRPGGame.Character.Classes
{
    public class Wizard : Class
    {
        public Wizard()
        {
            ClassName = "Wizard";
            ClassDescription = "Loves to cast and learn powerful spells, born with great intelligence\n" +
                               "Wise and think before they fight";

            Strength = 5;
            Dexterity = 5;
            Intelligence = 14;
            Vitality = 6;

            MakeSkill();
        }

        private void MakeSkill()
        {
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
