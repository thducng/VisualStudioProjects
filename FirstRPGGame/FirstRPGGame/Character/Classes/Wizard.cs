using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
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
        }
    }
}
