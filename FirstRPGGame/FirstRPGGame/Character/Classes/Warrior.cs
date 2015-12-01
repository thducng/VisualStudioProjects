using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
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
        }
    }
}
