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

namespace WpfApp1_Гуляева_Кристина_пр3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            A.Text = "4,6";
            P.Text = "2,9";
            C.Text = "9,5";
            B.Text = "1,6";
            Itog.Text = "Ст. гр. ИСП Гуляева, Житкова";

            
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            //  Считывание значения a
            double a = double.Parse(A.Text);
            // Вывод значения a в окно
            Itog.Text += Environment.NewLine + "a = " + A.ToString();
            //Считываем значение p
            double p = double.Parse(P.Text);
            //Вывод значения p в окно
            Itog.Text += Environment.NewLine + "P = " + C.ToString();
            //считывание значение c
            double c = double.Parse(C.Text);
            //Вывод значения C в окно
            Itog.Text += Environment.NewLine + "C = " + C.ToString();
            double b = double.Parse(B.Text);
            //Вывод значения p в окно
            Itog.Text += Environment.NewLine + "B = " + C.ToString();
            //Вычисляем арифметическое выражение
            double s = Math.Tan(p - a) * Math.Tan(p - a);
            double h = Math.Exp(p - a);
            double l = Math.Sqrt(Math.Cos(p - b) * Math.Sin(p - c)); 

            // Выводим результа в окно
            Itog.Text += Environment.NewLine + "Результат = h " + h.ToString();
        }

        private void Itog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
