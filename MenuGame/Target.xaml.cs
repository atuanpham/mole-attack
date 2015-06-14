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
    /// Interaction logic for Target.xaml
    /// </summary>
    public partial class Target : UserControl
    {
        public Target()
        {
            InitializeComponent();
        }

        //animatin khi bua dua len
        public void HitUp()
        {
            Storyboard hammerHitUp = this.FindResource("HammerHitUp") as Storyboard;
            hammerHitUp.Begin();
        }


        //animation khi bua dap
        public void HitDown()
        {
            Storyboard hammerHitDown = this.FindResource("HammerHitDown") as Storyboard;
            hammerHitDown.Begin();
        }
    }
}
