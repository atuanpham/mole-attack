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

namespace MenuGame
{
    /// <summary>
    /// Interaction logic for MenuOption.xaml
    /// </summary>
    public partial class MenuOption : UserControl
    {
        //khai bao delegate va event
        public delegate void Return_Click();
        public event Return_Click ReturnClick;

        int soundState;//trang thai am thanh (mute hay co tieng)
        int timeType; //cac tinh thoi gian
        GamePlay gP = new GamePlay(); //khoi tao doi tuong gP

        //cac property
        public int SoundState { get { return soundState; } }
        public int TimeType { get { return timeType; } }
        public GamePlay GP { set { gP = value; } }

        public MenuOption()
        {
            InitializeComponent();
            //khoi tao soundState = 1 va timeType = 0 (mac dinh)
            soundState = 1;
            timeType = 0;
        }

        //xu ly khi nhan vo button Return
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnClick != null) ReturnClick();
        }

        //xu ly khi click vo loa
        private void sound_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (soundState == 1)
            {
                BitmapImage bINoSound = new BitmapImage();
                bINoSound.BeginInit();
                bINoSound.UriSource = new Uri("Images\\no_sound.png", UriKind.Relative);
                bINoSound.EndInit();
                sound.Source = bINoSound;
                soundState = 0;
                gP.player.Volume = 0.0f;
            }
            else if (soundState == 0)
            {
                BitmapImage bISound = new BitmapImage();
                bISound.BeginInit();
                bISound.UriSource = new Uri("Images\\sound.png", UriKind.Relative);
                bISound.EndInit();
                sound.Source = bISound;
                soundState = 1;
            }
        }

        //xu ly khi chon cac kieu thoi gian choi
        private void time1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (timeType != 0)
            {
                checkTime1.Visibility = Visibility.Visible;
                checkTime2.Visibility = Visibility.Collapsed;
                timeType = 0;

            }
        }

        private void time2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (timeType != 1)
            {
                checkTime2.Visibility = Visibility.Visible;
                checkTime1.Visibility = Visibility.Collapsed;
                timeType = 1;
            }
        }
    }
}
