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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn1.Click += btn1_Click;
            btn2.Click += btn2_Click;
            btn3.Click += btn3_Click;
            btn4.Click += btn4_Click;
            btn5.Click += btn5_Click;
            btn6.Click += btn6_Click;
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn1.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 1 em.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
         
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn2.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 2 em.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn3.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 3 em.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn4.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 4 em.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn5.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 5 em.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            btn6.Background = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show("men 6 am.", "Melumat", MessageBoxButton.OK, MessageBoxImage.Information);
        }




        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    string buttonName = button.Name;
                    this.Title = buttonName;
                    Grid grid = button.Parent as Grid;
                    if (grid != null)
                    {
                        grid.Children.Remove(button);
                    }
                }
            }
        }

    }
}
