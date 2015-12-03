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
        private DataHandler DataHandler { get; }
        public Character Character1 { get; set; }
        public Character Character2 { get; set; }
        public Character NewCharacter { get; set; }
        public bool CharacterFull { get; set; }

        public GameViewModel()
        {
            DataHandler = new DataHandler();
            Character1 = new Character();
            Character2 = new Character();
            NewCharacter = null;
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

            if (CharacterFull)
            {
                return;
            }
            charCreateView.ShowDialog();
            if (NewCharacter != null)
            {
                DataHandler.CreateCharacter(NewCharacter);
                LoadCharacters();
            }
        }

        private void LoadCharacters()
        {
            List<Character> characters = DataHandler.GetCharacters();

            if (characters.Count == 2)
            {
                CharacterFull = true;
                Character1 = characters[0];
                Character2 = characters[1];
            }
            else if (characters.Count == 1)
            {
                Character1 = characters[0];
            }
        }   
    }
}
