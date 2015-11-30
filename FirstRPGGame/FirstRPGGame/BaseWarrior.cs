using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class BaseWarrior : BaseClass
    {
        public BaseWarrior()
        {
            ClassName = "Warrior";
            ClassDescription =
                "Warrior is the born strong and powerful, \n" +
                "they are melee and can deal alot of damage og take alot of damage";

            Strength = 10;
            Dexterity = 6;
            Intelligence = 4;
            Vitality = 9;
        }
    }
}
