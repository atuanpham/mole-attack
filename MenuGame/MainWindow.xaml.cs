using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPageTransitions;

namespace MenuGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //khai bao can thiet de thuc hien viec di chuyen cua so bang chuot
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //khai bao cac doi tuong MainMenu, MenuOption, MenuAbout, GamePlay
        MainMenu mainMenu;
        MenuAbout menuAbout;
        MenuOption menuOption;
        GamePlay gamePlay;

        public MainWindow()
        {
            InitializeComponent();
            //khoi tao va gan su kien mainMenu
            mainMenu = new MainMenu();
            mainMenu.PlayClick += menu_PlayClick;
            mainMenu.AboutClick += menu_AboutClick;
            mainMenu.OptionClick += menu_OptionClick;
            mainMenu.QuitClick += menu_QuitClick;

            //khoi tao va gan su kien menuAbout
            menuAbout = new MenuAbout();
            menuAbout.ReturnClick += menuAbout_ReturnClick;

            //khoi tao va gan su kien menuOption
            menuOption = new MenuOption();
            menuOption.ReturnClick += menuOption_ReturnClick;

            //khoi tao va gan su kien gamePlay
            gamePlay = new GamePlay();
            gamePlay.ReturnClick += gamePlay_ReturnClick;

            //gan doi tuong gamePlay cho property GP cua menuOption
            menuOption.GP = gamePlay;
        }

        //xu ly khi nhan vao button Return menu cua cac UserControl
        void gamePlay_ReturnClick()
        {
            pageTransitionControl.ShowPage(mainMenu);
        }

        void menuOption_ReturnClick()
        {
            pageTransitionControl.ShowPage(mainMenu);
        }

        void menuAbout_ReturnClick()
        {
            pageTransitionControl.ShowPage(mainMenu);
        }


        //xu ly khi nhan vao cac button trong mainMenu
        void menu_QuitClick()
        {
            this.Close();
        }

        void menu_OptionClick()
        {
            pageTransitionControl.ShowPage(menuOption);
        }

        void menu_AboutClick()
        {
            pageTransitionControl.ShowPage(menuAbout);
        }

        void menu_PlayClick()
        {
            pageTransitionControl.ShowPage(gamePlay);

            //Set nhung thiet lap trong Option cho gamePlay
            gamePlay.SetMode(menuOption.TimeType, menuOption.SoundState);
            gamePlay.SetHideScore();

            //Set cac hang trong gamePlay
            gamePlay.SetHoles();

            //Start DispatcherTimer
            gamePlay.timer.Start();
            gamePlay.RoundTimer.Start();
        }

        //xu ly khi nhan vo button exit va min
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
		
        //khi nhan vo day thi co the di chuyen man hinh choi :)
        private void Title_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
			ReleaseCapture();
            SendMessage(new WindowInteropHelper(this).Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        	// TODO: Add event handler implementation here.
        }

        //xu ly khi Windows vua load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pageTransitionControl.ShowPage(mainMenu);
        }
    }
}
