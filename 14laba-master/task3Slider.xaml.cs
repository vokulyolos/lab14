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
using System.Windows.Shapes;

namespace WPF_laba14
{
    /// <summary>
    /// Логика взаимодействия для task3Slider.xaml
    /// </summary>
    public partial class task3Slider : Window
    {
        public task3Slider()
        {
            InitializeComponent();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = slider.Value;

            Title = $"Value: {Math.Round(value, 1)}/10";
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task4(object sender, RoutedEventArgs e)
        {
            task4Calendar t4 = new();
            t4.Show();
            Close();
        }

        private void Task12(object sender, RoutedEventArgs e)
        {
            MainWindow t12 = new();
            t12.Show();
            Close();
        }
    }
}
