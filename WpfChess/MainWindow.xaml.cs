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

namespace WpfChess
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = fig.Text;

        }

        private void Pawn_Click_1(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }

        private void Knight__Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }

        private void Bishop_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }

        private void Rook_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }

        private void Queen_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }

        private void King_Click(object sender, RoutedEventArgs e)
        {
            fig.Text = (sender as Button).Content.ToString();
        }
    }
}
