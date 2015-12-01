using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
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
            Skills.Add
                (new Skill()
                );
        }
}
