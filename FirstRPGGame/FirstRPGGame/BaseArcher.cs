using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class BaseArcher : BaseClass
    {
        public BaseArcher()
        {
            ClassName = "Archer";
            ClassDescription =
                "The archer is fast and stealthy, they use the bow and arrow to deal physical damage at long range";

            Strength = 5;
            Dexterity = 10;
            Intelligence = 5;
            Vitality = 6;
        }
    }
}
