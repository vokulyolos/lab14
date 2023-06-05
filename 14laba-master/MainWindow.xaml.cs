using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_laba14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            timer.Tick += ForTask2ProgressBar;

            timer.Start();

        }

        private void ForTask1ProgressBarClick(object sender, RoutedEventArgs e)
        {
            Task1ProgressBar.Value += Task1ProgressBar.Maximum / 5;
            if (Task1ProgressBar.Value == Task1ProgressBar.Maximum)
            {
                Button button = sender as Button;
                button.Content = "DONE";
            }
        }

        private void ForTask2ProgressBar(object sender, EventArgs e)
        {
            Task2ProgressBar.Value += Task2ProgressBar.Maximum / 20;

            if(Task2ProgressBar.Value >= Task2ProgressBar.Maximum)
            {
                timer.Stop();
                MessageBox.Show("That's enough!");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task3(object sendr, RoutedEventArgs e)
        {
            task3Slider t3 = new();
            t3.Show();
            Close();
        }
    }
}
