using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Numerics;


namespace Thread
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread Fthread = new Thread();
            
            (new ThreadStart(fact(int.Parse(N.Text))));
            //Factorial.Text = fact(int.Parse(N.Text)).ToString();
            Summa.Text= summ(int.Parse(N.Text)).ToString();
        }

        public BigInteger fact(BigInteger num)
        {
            return (num == 0) ? 1 : num * fact(num - 1);

        }

        static int summ(int num)
        {
            return (num == 0) ? 0 : num + summ(num - 1);
        }
    }
}
