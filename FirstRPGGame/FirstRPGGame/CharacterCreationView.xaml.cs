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
            archer.MakeClass();
            Image.Source = new BitmapImage(new Uri(archer.ImagePath));
            TextBlockDescription.Text = archer.ClassDescription;
        }

        private void Monk_OnChecked(object sender, RoutedEventArgs e)
        {
            Monk monk = new Monk();
            monk.MakeClass();
            Image.Source = new BitmapImage(new Uri(monk.ImagePath));
            TextBlockDescription.Text = monk.ClassDescription;
        }

        private void Warrior_OnChecked(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            warrior.MakeClass();
            Image.Source = new BitmapImage(new Uri(warrior.ImagePath));
            TextBlockDescription.Text = warrior.ClassDescription;
        }

        private void Wizard_OnChecked(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard();
            wizard.MakeClass();
            Image.Source = new BitmapImage(new Uri(wizard.ImagePath));
            TextBlockDescription.Text = wizard.ClassDescription;
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text.Length > 2)
            {
                Character newCharacter = new Character();
                newCharacter.MakeCharacter();
                newCharacter.CharacterName = TextBoxName.Text;

                if (Archer.IsChecked == true)
                {
                    Archer newClass = new Archer();
                    newClass.MakeClass();
                    newCharacter.AssignClass(newClass);
                    ViewModel.NewCharacter = newCharacter;
                    Close();
                }
                else if (Monk.IsChecked == true)
                {
                    Monk newClass = new Monk();
                    newClass.MakeClass();
                    newCharacter.AssignClass(newClass);
                    ViewModel.NewCharacter = newCharacter;
                    Close();
                }
                else if (Warrior.IsChecked == true)
                {
                    Warrior newClass = new Warrior();
                    newClass.MakeClass();
                    newCharacter.AssignClass(newClass);
                    
                    ViewModel.NewCharacter = newCharacter;
                    Close();
                }
                else if (Wizard.IsChecked == true)
                {
                    Wizard newClass = new Wizard();
                    newClass.MakeClass();
                    newCharacter.AssignClass(newClass);
                    ViewModel.NewCharacter = newCharacter;
                    Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
