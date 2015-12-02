using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstRPGGame.DataHandling;
using FirstRPGGame.CharacterFiles;

namespace FirstRPGGame
{
    public class GameViewModel : IViewModel
    {
        private DataHandler dataHandler { get; }
        public Character character1 { get; set; }
        public Character character2 { get; set; }
        public bool CharacterFull { get; set; }

        public GameViewModel()
        {
            dataHandler = new DataHandler();
            character1 = new Character("character1");
            character2 = new Character("character2");
            CharacterFull = false;

            LoadCharacters();
        }

        public void StartCharacterSelection()
        {
            CharacterSelectionView charSelecView = new CharacterSelectionView(this);

            charSelecView.ShowDialog();
        }

        public void StartGame(Character character)
        {
            
        }

        public void CreateCharacter()
        {
            CharacterCreationView charCreateView = new CharacterCreationView(this);

            charCreateView.ShowDialog();
        }

        private void LoadCharacters()
        {
            List<Character> characters = dataHandler.GetCharacters();

            if (characters.Count == 2)
            {
                CharacterFull = true;
                character1 = characters[0];
                character2 = characters[1];
            }
            else if (characters.Count == 1)
            {
                character1 = characters[0];
            }
        }   
    }
}
