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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static List<Button> buttons = new List<Button>();
        public static int num_of_queue;
        public static int n;
        public static object button;
        public MainWindow()
        {
            InitializeComponent();
            but1.IsEnabled = false;
            but2.IsEnabled = false;
            but3.IsEnabled = false;
            but4.IsEnabled = false;
            but5.IsEnabled = false;
            but6.IsEnabled = false;
            but7.IsEnabled = false;
            but8.IsEnabled = false;
            but9.IsEnabled = false;
        }

        /*private void Clicks(object button, RoutedEventArgs e)
        {
            if (button == but1)
            {
                but1.Content = "╳";
                but1.IsEnabled = false;
                buttons.Remove(but1);
            }
            if (button == but2)
            {
                but2.Content = "╳";
                but2.IsEnabled = false;
                buttons.Remove(but2);
            }
            if (button == but3)
            {
                but3.Content = "╳";
                but3.IsEnabled = false;
                buttons.Remove(but3);
            }
            if (button == but4)
            {
                but4.Content = "╳";
                but4.IsEnabled = false;
                buttons.Remove(but4);
            }
            if (button == but5)
            {
                but5.Content = "╳";
                but5.IsEnabled = false;
                buttons.Remove(but5);
            }
            if (button == but6)
            {
                but6.Content = "╳";
                but6.IsEnabled = false;
                buttons.Remove(but6);
            }
            if (button == but7)
            {
                but7.Content = "╳";
                but7.IsEnabled = false;
                buttons.Remove(but7);
            }
            if (button == but8)
            {
                but8.Content = "╳";
                but8.IsEnabled = false;
                buttons.Remove(but8);
            }
            if (button == but9)
            {
                but9.Content = "╳";
                but9.IsEnabled = false;
                buttons.Remove(but9);
            }
            WinX();
        }*/

        private void Clicks(object button, RoutedEventArgs e)
        {
            switch (num_of_queue)
            {
                case 0:
                    num_of_queue = 1;
                    if (button == but1)
                    {
                        but1.Content = "╳";
                        but1.IsEnabled = false;
                        buttons.Remove(but1);
                    }
                    if (button == but2)
                    {
                        but2.Content = "╳";
                        but2.IsEnabled = false;
                        buttons.Remove(but2);
                    }
                    if (button == but3)
                    {
                        but3.Content = "╳";
                        but3.IsEnabled = false;
                        buttons.Remove(but3);
                    }
                    if (button == but4)
                    {
                        but4.Content = "╳";
                        but4.IsEnabled = false;
                        buttons.Remove(but4);
                    }
                    if (button == but5)
                    {
                        but5.Content = "╳";
                        but5.IsEnabled = false;
                        buttons.Remove(but5);
                    }
                    if (button == but6)
                    {
                        but6.Content = "╳";
                        but6.IsEnabled = false;
                        buttons.Remove(but6);
                    }
                    if (button == but7)
                    {
                        but7.Content = "╳";
                        but7.IsEnabled = false;
                        buttons.Remove(but7);
                    }
                    if (button == but8)
                    {
                        but8.Content = "╳";
                        but8.IsEnabled = false;
                        buttons.Remove(but8);
                    }
                    if (button == but9)
                    {
                        but9.Content = "╳";
                        but9.IsEnabled = false;
                        buttons.Remove(but9);
                    }
                    WinX();
                    break;
                case 1:
                    num_of_queue = 0;
                    if (button == but1)
                    {
                        but1.Content = "◯";
                        but1.IsEnabled = false;
                        buttons.Remove(but1);
                    }
                    if (button == but2)
                    {
                        but2.Content = "◯";
                        but2.IsEnabled = false;
                        buttons.Remove(but2);
                    }
                    if (button == but3)
                    {
                        but3.Content = "◯";
                        but3.IsEnabled = false;
                        buttons.Remove(but3);
                    }
                    if (button == but4)
                    {
                        but4.Content = "◯";
                        but4.IsEnabled = false;
                        buttons.Remove(but4);
                    }
                    if (button == but5)
                    {
                        but5.Content = "◯";
                        but5.IsEnabled = false;
                        buttons.Remove(but5);
                    }
                    if (button == but6)
                    {
                        but6.Content = "◯";
                        but6.IsEnabled = false;
                        buttons.Remove(but6);
                    }
                    if (button == but7)
                    {
                        but7.Content = "◯";
                        but7.IsEnabled = false;
                        buttons.Remove(but7);
                    }
                    if (button == but8)
                    {
                        but8.Content = "◯";
                        but8.IsEnabled = false;
                        buttons.Remove(but8);
                    }
                    if (button == but9)
                    {
                        but9.Content = "◯";
                        but9.IsEnabled = false;
                        buttons.Remove(but9);
                    }
                    WinO();
                    break;
            }
        }

        private void but_start_Click(object sender, RoutedEventArgs e)
        {
            but1.IsEnabled = true;
            but2.IsEnabled = true;
            but3.IsEnabled = true;
            but4.IsEnabled = true;
            but5.IsEnabled = true;
            but6.IsEnabled = true;
            but7.IsEnabled = true;
            but8.IsEnabled = true;
            but9.IsEnabled = true;
            but1.Content= string.Empty;
            but2.Content = string.Empty;
            but3.Content = string.Empty;
            but4.Content = string.Empty;
            but5.Content = string.Empty;
            but6.Content = string.Empty;
            but7.Content = string.Empty;
            but8.Content = string.Empty;
            but9.Content = string.Empty;
            textbk.Text = "КРЕСТИКИ-НОЛИКИ";
            buttons = new List<Button> { but1, but2, but3, but4, but4, but6, but7, but8, but9 };
            if (n % 2 == 0)
                num_of_queue= 0;
            else
                num_of_queue= 1;
            n++;
        }
        private void WinX()
        {
            if (but1.Content == "╳" && but2.Content == "╳" && but3.Content == "╳"){
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but4.Content == "╳" && but5.Content == "╳" && but6.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but7.Content == "╳" && but8.Content == "╳" && but9.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but1.Content == "╳" && but4.Content == "╳" && but7.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but2.Content == "╳" && but5.Content == "╳" && but8.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but3.Content == "╳" && but6.Content == "╳" && but9.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but1.Content == "╳" && but5.Content == "╳" && but9.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (but3.Content == "╳" && but5.Content == "╳" && but7.Content == "╳")
            {
                textbk.Text = "ПОБЕДА КРЕСТИКОВ!";
            }
            if (textbk.Text == "ПОБЕДА КРЕСТИКОВ!")
            {
                but1.IsEnabled = false;
                but2.IsEnabled = false;
                but3.IsEnabled = false;
                but4.IsEnabled = false;
                but5.IsEnabled = false;
                but6.IsEnabled = false;
                but7.IsEnabled = false;
                but8.IsEnabled = false;
                but9.IsEnabled = false;
            }
            if (buttons.Count == 0 && textbk.Text == "КРЕСТИКИ-НОЛИКИ")
            {
                textbk.Text = "НИЧЬЯ!";
            }
        }
        private void WinO()
        {
            if (but1.Content == "◯" && but2.Content == "◯" && but3.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but4.Content == "◯" && but5.Content == "◯" && but6.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but7.Content == "◯" && but8.Content == "◯" && but9.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but1.Content == "◯" && but4.Content == "◯" && but7.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but2.Content == "◯" && but5.Content == "◯" && but8.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but3.Content == "◯" && but6.Content == "╳" && but9.Content == "╳")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but1.Content == "◯" && but5.Content == "◯" && but9.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (but3.Content == "◯" && but5.Content == "◯" && but7.Content == "◯")
            {
                textbk.Text = "ПОБЕДА НОЛИКОВ!";
            }
            if (textbk.Text == "ПОБЕДА НОЛИКОВ!")
            {
                but1.IsEnabled = false;
                but2.IsEnabled = false;
                but3.IsEnabled = false;
                but4.IsEnabled = false;
                but5.IsEnabled = false;
                but6.IsEnabled = false;
                but7.IsEnabled = false;
                but8.IsEnabled = false;
                but9.IsEnabled = false;
            }
            if (buttons.Count == 0 && textbk.Text == "КРЕСТИКИ-НОЛИКИ")
            {
                textbk.Text = "НИЧЬЯ!";
            }
        }
    }
}


// ◯