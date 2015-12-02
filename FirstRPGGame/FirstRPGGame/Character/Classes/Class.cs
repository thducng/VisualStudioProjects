using System.Collections.Generic;

namespace FirstRPGGame.Character.Classes
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
