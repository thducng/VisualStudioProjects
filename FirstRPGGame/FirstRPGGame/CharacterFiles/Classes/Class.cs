using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;
using System.Xml.Serialization;
using System;

namespace FirstRPGGame.CharacterFiles.Classes
{
    [Serializable]
    [XmlInclude(typeof(Archer)), XmlInclude(typeof(Monk)), XmlInclude(typeof(Warrior)), XmlInclude(typeof(Wizard))]
    public abstract class Class
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public string ImagePath { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
