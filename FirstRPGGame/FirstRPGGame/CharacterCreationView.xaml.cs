using FirstRPGGame.CharacterFiles;
using FirstRPGGame.CharacterFiles.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace FirstRPGGame
{
    /// <summary>
    /// Interaction logic for CharacterCreationView.xaml
    /// </summary>
    public partial class CharacterCreationView : Window
    {
        private GameViewModel ViewModel { get; set; }

        public CharacterCreationView(GameViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            DataContext = ViewModel;
        }


        private void TextBoxName_OnGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox) sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBoxName_OnGotFocus;
        }

        private void Archer_OnChecked(object sender, RoutedEventArgs e)
        {
            Archer archer = new Archer();
            Image.Source = archer.Image;
            TextBlockDescription.Text = archer.ClassDescription;
        }

        private void Monk_OnChecked(object sender, RoutedEventArgs e)
        {
            Monk monk = new Monk();
            Image.Source = monk.Image;
            TextBlockDescription.Text = monk.ClassDescription;
        }

        private void Warrior_OnChecked(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            Image.Source = warrior.Image;
            TextBlockDescription.Text = warrior.ClassDescription;
        }

        private void Wizard_OnChecked(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard();
            Image.Source = wizard.Image;
            TextBlockDescription.Text = wizard.ClassDescription;
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text.Length > 2)
            {
                Character newCharacter = new Character(TextBoxName.Text);

                if (Archer.IsChecked == true)
                {
                    newCharacter.AssignClass(new Archer());
                }
                else if (Monk.IsChecked == true)
                {
                    newCharacter.AssignClass(new Monk());
                }
                else if (Warrior.IsChecked == true)
                {
                    newCharacter.AssignClass(new Warrior());
                }
                else if (Wizard.IsChecked == true)
                {
                    newCharacter.AssignClass(new Wizard());
                }
                else
                {
                    
                }
            }
            
        }
    }
}
