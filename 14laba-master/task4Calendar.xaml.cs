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
    /// Логика взаимодействия для task4Calendar.xaml
    /// </summary>
    public partial class task4Calendar : Window
    {
        public task4Calendar()
        {
            InitializeComponent();
        }

        private void Output(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar.SelectedDate;
            tb.Text = $"Вы выбрали - {selectedDate.Value.Date.ToShortDateString()}";
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            tb.Text = "Выберите дату в календаре";
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task3(object sender, RoutedEventArgs e)
        {
            task3Slider t3 = new();
            t3.Show();
            Close();
        }
    }
}
