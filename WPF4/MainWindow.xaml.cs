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

namespace WPF4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dolRub_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();

        }

        private void euRub_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void grivnRub_Click(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate2.Text);
            double sumGrivn = Convert.ToDouble(sum2.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSum2.Text = resGrivn.ToString();
        }

        private void dramRub_Click(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * sumDram;
            resSum3.Text = resDram.ToString();
        }

        private void inchMetr_Click(object sender, RoutedEventArgs e)
        {
            double numberInch = Convert.ToDouble(number.Text);
            double resultInch = 0.025 * numberInch;
            result.Text = resultInch.ToString();
        }

        private void furMetr_Click(object sender, RoutedEventArgs e)
        {
            double numberFur = Convert.ToDouble(number1.Text);
            double resultFur = 0.3 * numberFur;
            result1.Text = resultFur.ToString();
        }

        private void miliMetr_Click(object sender, RoutedEventArgs e)
        {
            double numberMili = Convert.ToDouble(number2.Text);
            double resultMili = 1609.34 * numberMili;
            result2.Text = resultMili.ToString();
        }

        private void verstMetr_Click(object sender, RoutedEventArgs e)
        {
            double numberVerst = Convert.ToDouble(number3.Text);
            double resultVerst = 1066.8 * numberVerst;
            result3.Text = resultVerst.ToString();
        }
    }
}
