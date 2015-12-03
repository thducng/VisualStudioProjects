using FirstRPGGame.CharacterFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstRPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CharacterSelectionView : Window
    {
        private GameViewModel ViewModel { get ; set; }

        public CharacterSelectionView(GameViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            UpdateView();
        }

        private void Character1_OnClick(object sender, MouseButtonEventArgs e)
        {
            ImageSelectedCharacter.Source = new BitmapImage(new Uri(ViewModel.Character1.ImagePath));
            TextBlockCharacterName.Text = ViewModel.Character1.CharacterName;
            UpdateView();
        }

        private void Character2_OnClick(object sender, MouseButtonEventArgs e)
        {
            ImageSelectedCharacter.Source = new BitmapImage(new Uri(ViewModel.Character2.ImagePath));
            TextBlockCharacterName.Text = ViewModel.Character1.CharacterName;
            UpdateView();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            ViewModel.CreateCharacter();
            UpdateView();
            Visibility = Visibility.Visible;
        }

        private void UpdateView()
        {
            DataContext = ViewModel;
        }

        public void MakeCharacter1(Character character)
        {
            ImageCharacter1.Source = new BitmapImage(new Uri(character.ImagePath));
            TextBlockNameCharacter1.Text = character.CharacterName;
            TextBlockLevelCharacter1.Text = character.CharacterLevel.ToString();
            TextBlockClassCharacter1.Text = character.CharacterClass.ClassName;
            TextBlockDamageCharacter1.Text = character.Damage.ToString();
            TextBlockToughnessCharacter1.Text = character.Toughness.ToString();
            UpdateView();
        }

        public void MakeCharacter2(Character character)
        {
            ImageCharacter2.Source = new BitmapImage(new Uri(character.ImagePath));
            TextBlockNameCharacter2.Text = character.CharacterName;
            TextBlockLevelCharacter2.Text = character.CharacterLevel.ToString();
            TextBlockClassCharacter2.Text = character.CharacterClass.ClassName;
            TextBlockDamageCharacter2.Text = character.Damage.ToString();
            TextBlockToughnessCharacter2.Text = character.Toughness.ToString();
            UpdateView();
        }

    }
}
