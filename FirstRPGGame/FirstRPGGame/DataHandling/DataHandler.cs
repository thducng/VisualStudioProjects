using System.Collections.Generic;
using FirstRPGGame.CharacterFiles;

namespace FirstRPGGame.DataHandling
{
    public class DataHandler
    {
        private XmlTranslator<Character> xmlCharacterTranslator = new XmlTranslator<Character>(); 

        public List<Character> GetCharacters()
        {
            return xmlCharacterTranslator.Deserialize();
        }

        public void CreateCharacter(Character character)
        {
            List<Character> newCharacter = new List<Character>();

            newCharacter.Add(character);
            xmlCharacterTranslator.Serialize(newCharacter);
        }
    }
}
