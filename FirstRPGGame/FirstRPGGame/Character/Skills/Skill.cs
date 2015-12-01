using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class Skill
    {
        public Skill(Type @class, string @skillName, string @skillDescription, int @baseDamageValue)
        {
            Class = @class;
            SkillName = @skillName;
            SkillDescription = @skillDescription;
            BaseDamageValue = @baseDamageValue;
        }

        public Type Class { get; set; }

        public string SkillName { get; set; }

        public string SkillDescription { get; set; }

        public int BaseDamageValue { get; set; }

        // Mere damage logik
    }
}
