using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FirstRPGGame.CharacterFiles.Skills;

namespace FirstRPGGame.CharacterFiles.Classes
{
    public class Class
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public BitmapImage Image { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
