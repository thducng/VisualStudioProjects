using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
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
        }
    }
}
