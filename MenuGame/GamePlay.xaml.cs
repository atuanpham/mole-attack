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
using System.Windows.Threading;
using System.Windows.Media.Animation;

using System.Media;

namespace MenuGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GamePlay : UserControl
    {
        Hole[] holes; //mang cac hang
        int sTime; //thoi gian cho cua chuot giam di sau 10s
        int soundState; //trang thai am thanh (mute hay co tieng)
        int score; //diem
        int countMole; //dem so mole da dap
        int countMoleTrap; //dem so moleTrap da dap
        int durationPerUp; //thoi gian moi lan nhoi len cua chuot
        int durationPerRoundTemp; //bien tam
        int durationPerRound; //thoi gian moi van
        int tempHole; //luu hang vua moi co chuot nhoi len

        //khai bao cac dispatcherTimer
        public DispatcherTimer RoundTimer;
        public DispatcherTimer timer;

        //khai bao delegate va event
        public delegate void Return_Click();
        public event Return_Click ReturnClick;

        public MediaPlayer player = new MediaPlayer(); //nhac nen

        MediaElement hit = new MediaElement(); //am thanh khi bua dap
        MediaElement moleHit = new MediaElement(); //am thanh khi dap trung mole
        MediaElement trapHit = new MediaElement(); //am thanh khi dap trung moleTrap
            

        public GamePlay()
        {

            InitializeComponent();

            //khoi tao 12 hang
            holes = new Hole[12];
            durationPerUp = 1600; //thoi gian moi lan nhoi len la 1600, sau 10s se giam sTime
            score = 0;//khoi tao diem
            tempHole = -1;//bien tam cho hang vua moi co chuot nhoi len
            countMole = 0;//khoi tao bien dem chuot
            countMoleTrap = 0;//khoi tao bien dem chuot

            RoundTimer = new DispatcherTimer();//khoi tao dispatcherTimer
            RoundTimer.Tick += RoundTimer_Tick;//ham thuc hien
            RoundTimer.Interval = new TimeSpan(0, 0, 1);//thoi gian
            //RoundTimer.Start();

            timer = new DispatcherTimer();//khoi tao dispatcherTimer
            timer.Tick += timer_Tick;//ham thuc hien
            timer.Interval = new TimeSpan(0, 0, 0, 0, durationPerUp);//thoi gian
            //timer.Start();

            player.Open(new Uri("Sounds\\cover_game.wma", UriKind.Relative));//mo file nhac nen
            player.Volume = 0.2f;//set Volume
            //xu ly khi am thanh ket thuc (giup nhac nen duoc lap lai)
            player.MediaEnded += (object sender, EventArgs e) => 
                {
                    player.Position = TimeSpan.Zero;
                    player.Play();
                };
            player.Play();//choi nhac

            //set LoadedBehavior, UnLoadedBehavior, Volume cho hit, moleHit, trapHit
            hit.LoadedBehavior = MediaState.Manual;
            hit.UnloadedBehavior = MediaState.Manual;
            hit.Volume = 1f;

            moleHit.LoadedBehavior = MediaState.Manual;
            moleHit.UnloadedBehavior = MediaState.Manual;
            moleHit.Volume = 1f;

            trapHit.LoadedBehavior = MediaState.Manual;
            trapHit.UnloadedBehavior = MediaState.Manual;
            trapHit.Volume = 1f;
        }

        //ham thuc hien cua RoundTimer
        void RoundTimer_Tick(object sender, EventArgs e)
        {
            if (durationPerRound != 0)//neu thoi gian moi van khac 0
            {
                durationPerRound--; //giam di 1 sau khoang thoi gian interval
                time.Content = durationPerRound.ToString();//set content cho label time
                //cu sau 10s, thoi gian durationPerUp se giam di sTime
                if ((durationPerRound % 10 == 0) && (durationPerRound < 120))
                {
                    durationPerUp -= sTime; ;
                    timer.Interval = new TimeSpan(0, 0, 0, 0, durationPerUp);
                }
            }
            else //neu durationPerRound = 0
            {
                //dung lai
                RoundTimer.Stop();
                timer.Stop();
                //hien diem
                Storyboard showScore = this.FindResource("ShowScore") as Storyboard;
                showScore.Begin();
            }

        }

        //ham thuc thi cua timer
        void timer_Tick(object sender, EventArgs e)
        {
            holes[RandomHole()].Attack();
        }

        //set cac hang
        public void SetHoles()
        {
            int i = 0;
            foreach (FrameworkElement hole in this.WrapHole.Children)
            {
                holes[i] = new Hole();
                holes[i].SetHole = (HoleDesign)hole;
                ((HoleDesign)hole).ThisHole = holes[i];
                ((HoleDesign)hole).MoleClick += MainWindow_MoleClick;
                ((HoleDesign)hole).MoleTrapClick += MainWindow_MoleTrapClick;
                ((HoleDesign)hole).SetMute(soundState);
                ++i;
            }
        }

        //xu ly khi dap trung moleTrap
        void MainWindow_MoleTrapClick()
        {
            score -= 4;
            countMoleTrap++;
            scoreTxt.Content = score.ToString();
            highScore.Content = score.ToString();
            numMoleTrap.Content = countMoleTrap.ToString();
            trapHit.Source = new Uri("Sounds\\trap_hit.wma", UriKind.Relative);
            trapHit.Play();
        }

        //xu ly khi dap trung mole
        void MainWindow_MoleClick()
        {
            score += 2;
            countMole++;
            scoreTxt.Content = score.ToString();
            highScore.Content = score.ToString();
            numMole.Content = countMole.ToString();
            moleHit.Source = new Uri("Sounds\\mole_hit.wma", UriKind.Relative);
            moleHit.Play();
        }

        //random hang nao se co chuot chui len
        public int RandomHole()
        {
            Random rand = new Random();
            int randNext;
            while (true)
            {
                randNext = rand.Next(12);
                if (randNext == tempHole)
                    continue;
                else
                    break;
            }
            return randNext;
        }

        //xu ly MouseMove trong canvas
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(this);//lay toa do cua chuot
            //khoi tao cac RenderTransform
            TransformGroup TG = new TransformGroup();
            ScaleTransform scalePointer = new ScaleTransform();
            //luu toa do chuot
            double curX = point.X;
            double curY = point.Y;

            //phong to, thu nho hammer cho giong that :D
            if (point.Y > 500)
            {
                scalePointer.ScaleX = 1.0;
                scalePointer.ScaleY = 1.0;
            }
            else if (point.Y < 100)
            {
                scalePointer.ScaleX = 0.5;
                scalePointer.ScaleY = 0.5;
            }
            else
            {
                scalePointer.ScaleX = 0.5 + (0.5 * ((point.Y - 100) / 400));
                scalePointer.ScaleY = 0.5 + (0.5 * ((point.Y - 100) / 400));
            }

            //thay doi vi tri cua hammer dua tren toa do tro chuot
            TranslateTransform TT = new TranslateTransform(curX - 26 * scalePointer.ScaleX, curY - 106 * scalePointer.ScaleY);
            TG.Children.Add(scalePointer);
            TG.Children.Add(TT);

            pointer.RenderTransform = TG;
        }


        //xu ly khi MouseDown
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pointer.HitDown();

            hit.Source = new Uri("Sounds\\hit.wma", UriKind.Relative);
            hit.Play();
        }

        //xu ly khi MouseUp
        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pointer.HitUp();
        }

        //xu ly khi bam vao TryAgain
        private void tryAgain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetHideScore();
            durationPerRound = durationPerRoundTemp;
            Reset();
            RoundTimer.Start();
            timer.Start();
        }

        //xu ly khi bam vao button Return
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnClick != null) ReturnClick();
            timer.Stop();
            RoundTimer.Stop();
        }

        //Set cac thiet lap trong Option cho Game Play
        public void SetMode(int timeType, int s)
        {
            soundState = s;

            if (timeType == 0)
            {
                durationPerRound = 120;
                sTime = 110;
            }
            else if (timeType == 1)
            {
                durationPerRound = 60;
                sTime = 250;
            }

            durationPerRoundTemp = durationPerRound;


            if (s == 0)
            {
                player.Volume = 0.0f;
                hit.Volume = 0.0f;
                moleHit.Volume = 0.0f;
                trapHit.Volume = 0.0f;
            }
            else if (s == 1)
            {
                player.Volume = 0.3f;
                hit.Volume = 1f;
                moleHit.Volume = 1f;
                trapHit.Volume = 1f;
            }

            Reset();
        }

        //Reset ve ban dau
        void Reset()
        {
            score = 0;
            countMole = 0;
            countMoleTrap = 0;
            durationPerUp = 1600;
            scoreTxt.Content = score.ToString();
            numMoleTrap.Content = countMoleTrap.ToString();
            numMole.Content = countMole.ToString();
            timer.Interval = new TimeSpan(0, 0, 0, 0, durationPerUp);
        }

        //hide diem
        public void SetHideScore()
        {
            Storyboard hideScore = this.FindResource("HideScore") as Storyboard;
            hideScore.Begin();
        }
    }
}
