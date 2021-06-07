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
        protected string SelectedFigure;
        protected List<Button> BoardRectangles;
        private FigLib.Figure figure;
        public MainWindow()
        {
            InitializeComponent();
            BoardRectangles = new List<Button>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = fig.Text;
            Button button = (Button)sender;
            string btnName = button.Name;
            var btnNames = btnName.Split('_');

            if (button.Content == null && SelectedFigure != "")
            {
                Clear_Click(null, null);

                button.Content = new Rectangle { Width = 75, Height = 75, Name = SelectedFigure };
                BoardRectangles.Add(button);

                figure = ClassLib.Make(SelectedFigure, Convert.ToInt32(btnNames[2]), Convert.ToInt32(btnNames[1]));

                SelectedFigure = "";
            }
            else if (figure.PreMove(Convert.ToInt32(btnNames[2]), Convert.ToInt32(btnNames[1])))
            {
                Clear_Click(null, null);

                button.Content = new Rectangle { Width = 75, Height = 75, Name = SelectedFigure };
                BoardRectangles.Add(button);
            }
        }

        private void Pawn_Click_1(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "P";
        }

        private void Knight__Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "N";
        }

        private void Bishop_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "B";
        }

        private void Rook_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "R";
        }

        private void Queen_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "Q";
        }

        private void King_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
            SelectedFigure = "K";

            Button button = (Button)sender;

            string btnName = button.Name;
            var btnNames = btnName.Split('_');

            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button boardBtn in BoardRectangles)
                boardBtn.Content = null;
        }
    }
}
