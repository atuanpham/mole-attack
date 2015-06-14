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
using WpfPageTransitions;

namespace MenuGame
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        //khai bao cac delegate va event cho mainMenu
        public delegate void Play_Click();
        public event Play_Click PlayClick;

        public delegate void About_Click();
        public event About_Click AboutClick;

        public delegate void Option_Click();
        public event Option_Click OptionClick;

        public delegate void Quit_Click();
        public event Quit_Click QuitClick;

        public MainMenu()
        {
            InitializeComponent();
        }

        //xu ly khi cac nut duoc click vao
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (PlayClick != null) PlayClick();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            if (AboutClick != null) AboutClick();
        }

        private void btnOption_Click(object sender, RoutedEventArgs e)
        {
            if (OptionClick != null) OptionClick();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            if (QuitClick != null) QuitClick();
        }
    }
}
