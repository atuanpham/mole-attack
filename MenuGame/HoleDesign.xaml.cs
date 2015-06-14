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
using System.Windows.Media.Animation;

namespace MenuGame
{
    /// <summary>
    /// Interaction logic for hole.xaml
    /// </summary>
    public partial class HoleDesign : UserControl
    {
        //khai bao cac delegate va event
        public delegate void MoleMouseDown();
        public event MoleMouseDown MoleClick;
        public delegate void MoleTrapMouseDown();
        public event MoleTrapMouseDown MoleTrapClick;

        //khoi tao cac bien am thanh khi chuot nhoi len
        MediaElement SoundMole = new MediaElement();
        MediaElement SoundMoleTrap = new MediaElement();

        private Hole thisHole;//doi tuong hole
        public Hole ThisHole { set { thisHole = value; } }

        public HoleDesign()
        {
            InitializeComponent();
            //su kien khi chuot dap
            mole.MouseLeftButtonDown += mole_MouseLeftButtonDown;
            moleTrap.MouseLeftButtonDown += moleTrap_MouseLeftButtonDown;
            holeFront.MouseLeftButtonDown += holeFront_MouseLeftButtonDown;

            //thiet lap SoundMole va SoundMoleTrap
            SoundMole.LoadedBehavior = MediaState.Manual;
            SoundMole.UnloadedBehavior = MediaState.Manual;
            SoundMole.Volume = 1f;

            SoundMoleTrap.LoadedBehavior = MediaState.Manual;
            SoundMoleTrap.UnloadedBehavior = MediaState.Manual;
            SoundMoleTrap.Volume = 1f;
        }

        //Set mute hay co tieng
        public void SetMute(int soundState)
        {
            if (soundState == 0)
            {
                SoundMole.Volume = 0.0f;
                SoundMoleTrap.Volume = 0.0f;
            }
            else
            {
                SoundMole.Volume = 1f;
                SoundMoleTrap.Volume = 1f;
            }
        }

        //xu ly khi chuot dap
        void holeFront_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (thisHole.Type == 0)
            {
                thisHole.Type = -1;
                thisHole.HoleTimer = null;
                if (MoleClick != null) MoleClick();
                Storyboard HitMole = this.FindResource("MoleHit") as Storyboard;
                HitMole.Begin();
            }
            else if (thisHole.Type == 1)
            {
                thisHole.Type = -1;
                thisHole.HoleTimer = null;
                if (MoleTrapClick != null) MoleTrapClick();
                Storyboard HitMoleTrap = this.FindResource("MoleTrapHit") as Storyboard;
                HitMoleTrap.Begin();
            }
        }

        //xu ly khi chuot dap
        void moleTrap_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            thisHole.Type = -1;
            thisHole.HoleTimer = null;
            if (MoleTrapClick != null) MoleTrapClick();          
            Storyboard HitMoleTrap = this.FindResource("MoleTrapHit") as Storyboard;
            HitMoleTrap.Begin();
        }

        //xu ly khi chuot dap
        void mole_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            thisHole.Type = -1;
            thisHole.HoleTimer = null;
            if (MoleClick != null) MoleClick();
            Storyboard HitMole = this.FindResource("MoleHit") as Storyboard;
            HitMole.Begin();
        }

        //am thanh va chay animation khi mole nhoi len
        public void MoleUp()
        {
            SoundMole.Source = new Uri("Sounds\\mole.wma", UriKind.Relative);
            SoundMole.Play();
            Storyboard upMole = this.FindResource("UpMole") as Storyboard;
            upMole.Begin();
        }

        //animation khi mole chui xuong
        public void MoleDown() 
        {
            Storyboard downMole = this.FindResource("DownMole") as Storyboard;
            downMole.Begin();
        }

        //am thanh va animaiton khi mole trap nhoi len
        public void MoleTrapUp() 
        {
            SoundMoleTrap.Source = new Uri("Sounds\\mole_trap.wma", UriKind.Relative);
            SoundMoleTrap.Play();
            Storyboard upMoleTrap = this.FindResource("UpMoleTrap") as Storyboard;
            upMoleTrap.Begin();
        }

        //animation khi mole trap chui xuong
        public void MoleTrapDown()
        {
            Storyboard downMoleTrap = this.FindResource("DownMoleTrap") as Storyboard;
            downMoleTrap.Begin();
        }
    }
}
