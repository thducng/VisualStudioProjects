using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstRPGGame.DataHandling;

namespace FirstRPGGame
{
    public class GameViewModel : IViewModel
    {
        private DataHandler dataHandler { get; }

        public Character character1 { get; set; }

        public Character character2 { get; set; }

        public GameViewModel()
        {
            dataHandler = new DataHandler();
            LoadCharacters();
        }

        public void StartGame()
        {
            CharacterSelectionView CharSelecView = new CharacterSelectionView(this);

            CharSelecView.ShowDialog();
        }


        private void LoadCharacters()
        {
            List<Character> Characters = dataHandler.GetCharacters();
        }
    }
}
