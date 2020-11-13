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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gra = 0;
        readonly string player_x = "Gracz X";
        readonly string player_o = "Gracz O";
        readonly int x = 1;
        readonly int o = 2;
        int nrbuttona;
        int button1 = 0;
        int button2 = 0;
        int button3 = 0;
        int button4 = 0;
        int button5 = 0;
        int button6 = 0;
        int button7 = 0;
        int button8 = 0;
        int button9 = 0;
        public MainWindow()
        {
            InitializeComponent();
            TextBlock.Text = player_x;
            Player();
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            nrbuttona = (sender as Button).Name[(sender as Button).Name.Length - 1];
            if (TextBlock.Text == player_x)
            {
                if (nrbuttona == 49 && button1 == 0)
                {
                    button1 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 50 && button2 == 0)
                {
                    button2 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 51 && button3 == 0)
                {
                    button3 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 52 && button4 == 0)
                {
                    button4 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 53 && button5 == 0)
                {
                    button5 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 54 && button6 == 0)
                {
                    button6 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 55 && button7 == 0)
                {
                    button7 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 56 && button8 == 0)
                {
                    button8 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 57 && button9 == 0)
                {
                    button9 = x;
                    (sender as Button).Content = "x";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else
                {
                    TextBlock.Foreground = Brushes.Red;
                }
                //OTHER   
            }
            else if (TextBlock.Text == player_o)
            {
                if (nrbuttona == 49 && button1 == 0)
                {
                    button1 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 50 && button2 == 0)
                {
                    button2 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 51 && button3 == 0)
                {
                    button3 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 52 && button4 == 0)
                {
                    button4 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 53 && button5 == 0)
                {
                    button5 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 54 && button6 == 0)
                {
                    button6 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 55 && button7 == 0)
                {
                    button7 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 56 && button8 == 0)
                {
                    button8 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else if (nrbuttona == 57 && button9 == 0)
                {
                    button9 = o;
                    (sender as Button).Content = "o";
                    Player();
                    TextBlock.Foreground = Brushes.Black;
                    gra++;
                }
                else
                {
                    TextBlock.Foreground = Brushes.Red;
                }
            }
            Win();
        }
        //Void - Player change
        private void Player()
        {
            if (TextBlock.Text == player_x)
            {
                TextBlock.Text = player_o;
            }
            else if (TextBlock.Text == player_o)
            {
                TextBlock.Text = player_x;
            }
        }
        //Void - Who won
        private void Win()
        {
            if (button1 == 1 && button2 == 1 && button3 == 1 ||
                button3 == 1 && button6 == 1 && button9 == 1 ||
                button7 == 1 && button8 == 1 && button9 == 1 ||
                button1 == 1 && button4 == 1 && button7 == 1 ||
                button1 == 1 && button5 == 1 && button9 == 1 ||
                button3 == 1 && button5 == 1 && button7 == 1 ||
                button4 == 1 && button5 == 1 && button6 == 1 ||
                button2 == 1 && button5 == 1 && button8 == 1)
            {
                MessageBox.Show("Wygrał: X");
                Restart();
            }
            else if (button1 == 2 && button2 == 2 && button3 == 2 ||
                button3 == 2 && button6 == 2 && button9 == 2 ||
                button7 == 2 && button8 == 2 && button9 == 2 ||
                button1 == 2 && button4 == 2 && button7 == 2 ||
                button1 == 2 && button5 == 2 && button9 == 2 ||
                button3 == 2 && button5 == 2 && button7 == 2 ||
                button4 == 2 && button5 == 2 && button6 == 2 ||
                button2 == 2 && button5 == 2 && button8 == 2)
            {
                MessageBox.Show("Wygrał: O");
                Restart();
            }
            else
            {
                if (gra == 9)
                {
                    MessageBox.Show("Remis");
                    Restart();
                }
            }
        }
        //Void - Reset
        void Reset_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }
        void Restart()
        {
            TextBlock.Foreground = Brushes.Black;
            nrbuttona = 0;
            gra = 0;
            button1 = 0;
            button2 = 0; Button1.Content = "";
            button3 = 0; Button2.Content = "";
            button4 = 0; Button3.Content = "";
            button5 = 0; Button4.Content = "";
            button6 = 0; Button5.Content = "";
            button7 = 0; Button6.Content = "";
            button8 = 0; Button7.Content = "";
            button9 = 0; Button8.Content = "";
            Button9.Content = "";
            Player();
        }
    }
}
