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
            a.Text = "4,6";
            p.Text = "2,9";
            c.Text = "9,5";
            Itog.Text = "Ст. гр. ИСП Гуляева, Житкова";

            
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            //  Считывание значения a
            double a = double.Parse(a.Text);
            // Вывод значения a в окно
            Itog.Text += Environment.NewLine + "a = " + a.ToString();

        }

        private void Itog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
