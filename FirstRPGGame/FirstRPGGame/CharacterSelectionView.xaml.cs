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
        private IViewModel ViewModel { get ; set; }

        public CharacterSelectionView(IViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            UpdateView();
        }

        private void Character1_OnClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Character2_OnClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateView()
        {
            DataContext = ViewModel;
        }

        public void MakeCharacter1(Character character)
        {
            ImageCharacter1.Source = character.Image;
            TextBlockNameCharacter1.Text = character.CharacterName;
            TextBlockLevelCharacter1.Text = character.CharacterLevel.ToString();
            TextBlockClassCharacter1.Text = character.Class.ClassName;
            TextBlockDamageCharacter1.Text = character.Damage.ToString();
            TextBlockToughnessCharacter1.Text = character.Toughness.ToString();
        }

        public void MakeCharacter2(Character character)
        {
            ImageCharacter2.Source = character.Image;
            TextBlockNameCharacter2.Text = character.CharacterName;
            TextBlockLevelCharacter2.Text = character.CharacterLevel.ToString();
            TextBlockClassCharacter2.Text = character.Class.ClassName;
            TextBlockDamageCharacter2.Text = character.Damage.ToString();
            TextBlockToughnessCharacter2.Text = character.Toughness.ToString();
        }

    }
}
