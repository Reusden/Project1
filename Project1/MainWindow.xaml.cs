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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
     
        }

     
        private void exitClick(object sender, RoutedEventArgs e) //Выхода из программы
        {
            Close();
        }
        private void startClick(object sender, RoutedEventArgs e) //Начала игры
        {
            MainGrid.Visibility = Visibility.Collapsed;
            FloorGrid.Visibility = Visibility.Visible;
        }
        private void backFloor(object sender, RoutedEventArgs e) //Переход из сцены Этажей к Главной сцене
        {
            MainGrid.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
        }
        private void floor1Click(object sender, RoutedEventArgs e) //Выбор первого этажа
        {
            Floor1q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
        }
        private void backQ1(object sender, RoutedEventArgs e) //Выход из первого этажа
        {
            Floor1q.Visibility = Visibility.Collapsed;
            FloorGrid.Visibility = Visibility.Visible;
        }
        private void nextQ1NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            F1q1.Visibility = Visibility.Collapsed;
            F1q2.Visibility = Visibility.Visible;
        }
        private void nextQ1True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            q1.Visibility = Visibility.Collapsed;
            q2.Visibility = Visibility.Visible;
           

        }

    }
}