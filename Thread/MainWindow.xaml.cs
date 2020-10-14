using System;
using System.Text;
using System.Threading;
using System.Windows;
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
            var n = BigInteger.Parse(N.Text);
            new System.Threading.Thread(() =>
            {
                var result = ffact(n);
                App.Current.Dispatcher.Invoke(() => Factorial.Text = result.ToString());  
            }).Start();

            new System.Threading.Thread(() =>
            {
                var result = fsumm(n);
                App.Current.Dispatcher.Invoke(() => Summa.Text = result.ToString());
            }).Start();
        }

        static BigInteger ffact(BigInteger num)
        {
            return (num == 0) ? 1 : num * ffact(num - 1);
        }

        static BigInteger fsumm(BigInteger num)
        {
            return (num == 0) ? 0 : num + fsumm(num - 1);
        }
    }
}
