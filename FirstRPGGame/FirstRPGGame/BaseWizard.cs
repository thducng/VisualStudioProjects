using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class BaseWizard : BaseClass
    {
        public BaseWizard()
        {
            ClassName = "Wizard";
            ClassDescription = "Loves to cast and learn powerful spells, born with great intelligence\n" +
                               "Wise and think before they fight";

            Strength = 5;
            Dexterity = 5;
            Intelligence = 10;
            Vitality = 5;
        }
    }
}
