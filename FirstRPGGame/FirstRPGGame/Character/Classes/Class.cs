using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame
{
    public class Class
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
