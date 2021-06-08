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
using FigLib;

namespace WpfChess
{
    public partial class MainWindow : Window
    {
        private string ActivFig;
        private List<Button> ButList;
        private FigClass figclass;

        public MainWindow()
        {
            InitializeComponent();
            ButList = new List<Button>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string btnName = (sender as Button).Name;
            var btnNames = btnName.Split('_');

            if ((sender as Button).Content == null && ActivFig != "")
            {
                FillButFig(sender);

                figclass = FigMaker.Make(ActivFig, Convert.ToInt32(btnNames[2]), Convert.ToInt32(btnNames[1]));
                ActivFig = "";
            }

            else if (figclass.PreMove(Convert.ToInt32(btnNames[2]), Convert.ToInt32(btnNames[1])))
                FillButFig(sender);
        }

        public void FillButFig(object sender)
        {
            Clear_Click(null, null);

            (sender as Button).Content = fig.Text;
            ButList.Add(sender as Button);
        }

        private void Pawn_Click_1(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "Pawn";
        }

        private void Knight__Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "Knight";
        }

        private void Bishop_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "Bishop";
        }

        private void Rook_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "Rook";
        }

        private void Queen_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "Queen";
        }

        private void King_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            ActivFig = "King";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button boardBtn in ButList)
                boardBtn.Content = null;
        }
    }
}
