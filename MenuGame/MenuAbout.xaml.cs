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
    /// Interaction logic for MenuAbout.xaml
    /// </summary>
    public partial class MenuAbout : UserControl
    {
        public delegate void Return_Click();
        public event Return_Click ReturnClick;
        

        public MenuAbout()
        {
            InitializeComponent();
        }

        //xu ly khi bam vo nut Return
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnClick != null) ReturnClick();
        }
    }
}
