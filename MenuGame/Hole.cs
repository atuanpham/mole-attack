using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MenuGame
{
    public class Hole
    {
        //khoi tao cac hang so
        public const int isMole = 0;
        public const int isMoleTrap = 1;
        public const int MoleDur = 800;
        public const int MoleTrapDur = 1300;

        int type;//loai chuot
        int typeTemp;//bien tam
        int duration;//thoi gian nhoi len
        HoleDesign hole;//doi tuong hang
        DispatcherTimer holeTimer;//dispatcher

        //cac property
        public HoleDesign SetHole { set { hole = value; } }
        public DispatcherTimer HoleTimer { set { holeTimer = value; } }
        public int Type { get { return type; } set { type = value; } }

        public Hole()
        {
            //khoi tao ban dau
            type = -1;
            typeTemp = -1;
        }

        public void Attack()
        {
            Reset();//Reset cac gia tri
            //khoi tao dispatcherTimer
            holeTimer = new DispatcherTimer();
            SetTimer();//goi ham SetTimer
            StartMole();//chuot nhoi len
            holeTimer.Start();//hole timer start
        }

        //dung holeTimer
        public void StopAttack()
        {
            holeTimer.Stop();
        }

        //chuot nhoi len
        private void StartMole()
        {
            if (type == isMole)
            {
                hole.MoleUp();
            }
            else
            {
                hole.MoleTrapUp();
            }
        }

        //chuot chui xuong
        private void EndMole()
        {
            if (type == isMole)
            {
                hole.MoleDown();
            }
            else
            {
                hole.MoleTrapDown();
            }
        }

        //chon ngau nhien loai chuot
        private int RandomMole()
        {
            Random rand = new Random();
            while (true)
            {
                int r = rand.Next(2);
                if (typeTemp == 1)
                {
                    if (r == typeTemp)
                        continue;
                    else
                        return r;
                }
                return r;
            }
        }

        //Set Timer
        private void SetTimer()
        {
            holeTimer.Interval = new TimeSpan(0, 0, 0, 0, duration);
            holeTimer.Tick += timer_Tick;
        }

        //ham thuc hien cua dispatcherTimer
        void timer_Tick(object sender, EventArgs e)
        {
            if (holeTimer != null)
            {
                EndMole();//chuot chui xuong
                type = -1;//gan type = -1;
                holeTimer.Stop();//dung dispatcher Timer
                holeTimer = null;
            }
        }

        //Reset
        public void Reset()
        {
            type = RandomMole();
            typeTemp = type;
            if (type == isMole)
            {
                duration = MoleDur;
            }
            else
            {
                duration = MoleTrapDur;
            }
        }
    }
}
