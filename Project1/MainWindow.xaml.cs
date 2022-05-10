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
        int Score;
        string TextInUsers;
        bool[] Question1 = new bool[24]; // Если вопрос уже пройден, то его снова не показываем 
        string[] Ansfer = {"Галактика"," Галактика", "Галактика ", 
            "Эллиптические, спиральные, неправильные", "Эллиптические,спиральные,неправильные",
            "Млечный путь"," Млечный путь","Млечный путь ",
            "Чёрная дыра"," Чёрная дыра","Чёрная дыра ",
            "Нептун", " Нетун", "Нептун ",
        };
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
        public void floor1Click(object sender, RoutedEventArgs e) //Выбор первого этажа
        {

            Floor1q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
            q1.Visibility = Visibility.Visible;
        }
        private void floor2Click(object sender, RoutedEventArgs e) //Выбор второго этажа
        {
            Floor2q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
            q12.Visibility = Visibility.Visible;
        }
        private void floor3Click(object sender, RoutedEventArgs e) //Выбор третьего этажа
        {
            Floor3q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
            q13.Visibility = Visibility.Visible;
        }
        private void floor4Click(object sender, RoutedEventArgs e) //Выбор четвёртого этажа
        {
            Floor4q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
            q14.Visibility = Visibility.Visible;
        }
        private void floor5Click(object sender, RoutedEventArgs e) //Выбор пятого этажа
        {
            Floor5q.Visibility = Visibility.Visible;
            FloorGrid.Visibility = Visibility.Collapsed;
            q15.Visibility = Visibility.Visible;
        }
        private void backQ1(object sender, RoutedEventArgs e) //Выход из этажа
        {
            Floor1q.Visibility = Visibility.Collapsed;
            q1.Visibility = Visibility.Collapsed;
            q2.Visibility = Visibility.Collapsed;
            q3.Visibility = Visibility.Collapsed;
            q4.Visibility = Visibility.Collapsed;
            q5.Visibility = Visibility.Collapsed;
            Floor2q.Visibility = Visibility.Collapsed;
            q12.Visibility = Visibility.Collapsed;
            q22.Visibility = Visibility.Collapsed;
            q32.Visibility = Visibility.Collapsed;
            q42.Visibility = Visibility.Collapsed;
            q52.Visibility = Visibility.Collapsed;
            Floor3q.Visibility = Visibility.Collapsed;
            q13.Visibility = Visibility.Collapsed;
            q23.Visibility = Visibility.Collapsed;
            q33.Visibility = Visibility.Collapsed;
            q43.Visibility = Visibility.Collapsed;
            q53.Visibility = Visibility.Collapsed;
            Floor4q.Visibility = Visibility.Collapsed;
            q14.Visibility = Visibility.Collapsed;
            q24.Visibility = Visibility.Collapsed;
            q34.Visibility = Visibility.Collapsed;
            q44.Visibility = Visibility.Collapsed;
            q54.Visibility = Visibility.Collapsed;
            Floor5q.Visibility = Visibility.Collapsed;
            q15.Visibility = Visibility.Collapsed;
            q25.Visibility = Visibility.Collapsed;
            q35.Visibility = Visibility.Collapsed;
            q45.Visibility = Visibility.Collapsed;
            q55.Visibility = Visibility.Collapsed;
            FloorGrid.Visibility = Visibility.Visible;
        }
        private void nextQ1NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q1.Visibility = Visibility.Collapsed;
                q2.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q12.Visibility = Visibility.Collapsed;
                q22.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q13.Visibility = Visibility.Collapsed;
                q23.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q14.Visibility = Visibility.Collapsed;
                q24.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q15.Visibility = Visibility.Collapsed;
                q25.Visibility = Visibility.Visible;
            }
        }
        private void nextQ1True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q1.Visibility = Visibility.Collapsed;
                q2.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q12.Visibility = Visibility.Collapsed;
                q22.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q13.Visibility = Visibility.Collapsed;
                q23.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q14.Visibility = Visibility.Collapsed;
                q24.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q15.Visibility = Visibility.Collapsed;
                q25.Visibility = Visibility.Visible;
            }
            Score++;
        }
        private void nextQ2NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q2.Visibility = Visibility.Collapsed;
                q3.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q22.Visibility = Visibility.Collapsed;
                q32.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q23.Visibility = Visibility.Collapsed;
                q33.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q24.Visibility = Visibility.Collapsed;
                q34.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q25.Visibility = Visibility.Collapsed;
                q35.Visibility = Visibility.Visible;
            }
        }
        private void nextQ2True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q2.Visibility = Visibility.Collapsed;
                q3.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q22.Visibility = Visibility.Collapsed;
                q32.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q23.Visibility = Visibility.Collapsed;
                q33.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q24.Visibility = Visibility.Collapsed;
                q34.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q25.Visibility = Visibility.Collapsed;
                q35.Visibility = Visibility.Visible;
            }
            Score++;
        }
        private void nextQ3NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q3.Visibility = Visibility.Collapsed;
                q4.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q32.Visibility = Visibility.Collapsed;
                q42.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q33.Visibility = Visibility.Collapsed;
                q43.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q34.Visibility = Visibility.Collapsed;
                q44.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q35.Visibility = Visibility.Collapsed;
                q45.Visibility = Visibility.Visible;
            }
        }
        private void nextQ3True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q3.Visibility = Visibility.Collapsed;
                q4.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q32.Visibility = Visibility.Collapsed;
                q42.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q33.Visibility = Visibility.Collapsed;
                q43.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q34.Visibility = Visibility.Collapsed;
                q44.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q35.Visibility = Visibility.Collapsed;
                q45.Visibility = Visibility.Visible;
            }
            Score++;
        }
        private void nextQ4NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q4.Visibility = Visibility.Collapsed;
                q5.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q42.Visibility = Visibility.Collapsed;
                q52.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q43.Visibility = Visibility.Collapsed;
                q53.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q44.Visibility = Visibility.Collapsed;
                q54.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q45.Visibility = Visibility.Collapsed;
                q55.Visibility = Visibility.Visible;
            }
        }
        private void nextQ4True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q4.Visibility = Visibility.Collapsed;
                q5.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q42.Visibility = Visibility.Collapsed;
                q52.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q43.Visibility = Visibility.Collapsed;
                q53.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q44.Visibility = Visibility.Collapsed;
                q54.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q45.Visibility = Visibility.Collapsed;
                q55.Visibility = Visibility.Visible;
            }
            Score++;
        }
        private void nextQ5NotTrue(object sender, RoutedEventArgs e) //Следующий вопрос
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q1.Visibility = Visibility.Collapsed;
                q2.Visibility = Visibility.Collapsed;
                q3.Visibility = Visibility.Collapsed;
                q4.Visibility = Visibility.Collapsed;
                q5.Visibility = Visibility.Collapsed;
                Floor1q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q12.Visibility = Visibility.Collapsed;
                q22.Visibility = Visibility.Collapsed;
                q32.Visibility = Visibility.Collapsed;
                q42.Visibility = Visibility.Collapsed;
                q52.Visibility = Visibility.Collapsed;
                Floor2q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q13.Visibility = Visibility.Collapsed;
                q23.Visibility = Visibility.Collapsed;
                q33.Visibility = Visibility.Collapsed;
                q43.Visibility = Visibility.Collapsed;
                q53.Visibility = Visibility.Collapsed;
                Floor3q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q14.Visibility = Visibility.Collapsed;
                q24.Visibility = Visibility.Collapsed;
                q34.Visibility = Visibility.Collapsed;
                q44.Visibility = Visibility.Collapsed;
                q54.Visibility = Visibility.Collapsed;
                Floor4q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q15.Visibility = Visibility.Collapsed;
                q25.Visibility = Visibility.Collapsed;
                q35.Visibility = Visibility.Collapsed;
                q45.Visibility = Visibility.Collapsed;
                q55.Visibility = Visibility.Collapsed;
                Floor5q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
        }
        private void nextQ5True(object sender, RoutedEventArgs e) //Следующий вопрос, правильный ответ
        {
            if (Floor1q.Visibility == Visibility.Visible)
            {
                q1.Visibility = Visibility.Collapsed;
                q2.Visibility = Visibility.Collapsed;
                q3.Visibility = Visibility.Collapsed;
                q4.Visibility = Visibility.Collapsed;
                q5.Visibility = Visibility.Collapsed;
                Floor1q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor2q.Visibility == Visibility.Visible)
            {
                q12.Visibility = Visibility.Collapsed;
                q22.Visibility = Visibility.Collapsed;
                q32.Visibility = Visibility.Collapsed;
                q42.Visibility = Visibility.Collapsed;
                q52.Visibility = Visibility.Collapsed;
                Floor2q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor3q.Visibility == Visibility.Visible)
            {
                q13.Visibility = Visibility.Collapsed;
                q23.Visibility = Visibility.Collapsed;
                q33.Visibility = Visibility.Collapsed;
                q43.Visibility = Visibility.Collapsed;
                q53.Visibility = Visibility.Collapsed;
                Floor3q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor4q.Visibility == Visibility.Visible)
            {
                q14.Visibility = Visibility.Collapsed;
                q24.Visibility = Visibility.Collapsed;
                q34.Visibility = Visibility.Collapsed;
                q44.Visibility = Visibility.Collapsed;
                q54.Visibility = Visibility.Collapsed;
                Floor4q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            else if (Floor5q.Visibility == Visibility.Visible)
            {
                q15.Visibility = Visibility.Collapsed;
                q25.Visibility = Visibility.Collapsed;
                q35.Visibility = Visibility.Collapsed;
                q45.Visibility = Visibility.Collapsed;
                q55.Visibility = Visibility.Collapsed;
                Floor5q.Visibility = Visibility.Collapsed;
                FloorGrid.Visibility = Visibility.Visible;
            }
            Score++;
        }
        
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextInUsers = TextBox1.Text;
                if (Floor1q.Visibility == Visibility.Visible)
                {
                    q1.Visibility = Visibility.Collapsed;
                    q2.Visibility = Visibility.Collapsed;
                    q3.Visibility = Visibility.Collapsed;
                    q4.Visibility = Visibility.Collapsed;
                    q5.Visibility = Visibility.Collapsed;
                    Floor1q.Visibility = Visibility.Collapsed;
                    FloorGrid.Visibility = Visibility.Visible;
                }
                else if (Floor2q.Visibility == Visibility.Visible)
                {
                    q12.Visibility = Visibility.Collapsed;
                    q22.Visibility = Visibility.Collapsed;
                    q32.Visibility = Visibility.Collapsed;
                    q42.Visibility = Visibility.Collapsed;
                    q52.Visibility = Visibility.Collapsed;
                    Floor2q.Visibility = Visibility.Collapsed;
                    FloorGrid.Visibility = Visibility.Visible;
                }
                else if (Floor3q.Visibility == Visibility.Visible)
                {
                    q13.Visibility = Visibility.Collapsed;
                    q23.Visibility = Visibility.Collapsed;
                    q33.Visibility = Visibility.Collapsed;
                    q43.Visibility = Visibility.Collapsed;
                    q53.Visibility = Visibility.Collapsed;
                    Floor3q.Visibility = Visibility.Collapsed;
                    FloorGrid.Visibility = Visibility.Visible;
                }
                else if (Floor4q.Visibility == Visibility.Visible)
                {
                    q14.Visibility = Visibility.Collapsed;
                    q24.Visibility = Visibility.Collapsed;
                    q34.Visibility = Visibility.Collapsed;
                    q44.Visibility = Visibility.Collapsed;
                    q54.Visibility = Visibility.Collapsed;
                    Floor4q.Visibility = Visibility.Collapsed;
                    FloorGrid.Visibility = Visibility.Visible;
                }
                else if (Floor5q.Visibility == Visibility.Visible)
                {
                    q15.Visibility = Visibility.Collapsed;
                    q25.Visibility = Visibility.Collapsed;
                    q35.Visibility = Visibility.Collapsed;
                    q45.Visibility = Visibility.Collapsed;
                    q55.Visibility = Visibility.Collapsed;
                    Floor5q.Visibility = Visibility.Collapsed;
                    FloorGrid.Visibility = Visibility.Visible;
                }
            }
            for (int i=0; i==Ansfer.Length; i++) { 
                if (TextInUsers == Ansfer[i]) {
                    Score++;
                }
            }
        }

    }
}