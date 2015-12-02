using FirstRPGGame.CharacterFiles.Classes;

namespace FirstRPGGame.CharacterFiles.Skills
{
    public class Skill
    {
        public Skill(Class @class, int @skillLevelReq, int @skillLevel, string @skillName, string @skillDescription,
            int @baseDamageValue, int @baseDamageScale, bool @passive = false)
        {
            Class = @class;
            SkillLevelReq = @skillLevelReq;
            SkillLevel = @skillLevel;
            SkillName = @skillName;
            SkillDescription = @skillDescription;
            BaseDamageValue = @baseDamageValue;
            BaseDamageScale = @baseDamageScale;
            Passive = @passive;
        }

        public Class Class { get; set; }

        public int SkillLevelReq { get; set; }

        public int SkillLevel { get; set; }

        public string SkillName { get; set; }

        public string SkillDescription { get; set; }

        public bool Passive { get; set; }

        public int BaseDamageValue { get; set; }

        public int BaseDamageScale { get; set; }

        public void SkillLevelUp(int levelup)
        {
            SkillLevel += levelup;

            BaseDamageValue = (SkillLevel*100) + 200;
        }

        public int UseSkill(int mainStat)
        {
            return BaseDamageValue + (BaseDamageScale*mainStat)/100;
        }

    }
}
