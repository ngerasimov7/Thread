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
            Thread Fthread = new Thread(new ParameterizedThreadStart(fact))
            {
                Name = "Поток расчета факторила",
                Priority = ThreadPriority.Lowest
            };
            Fthread.Start(N.Text);

            Thread Sthread = new Thread(new ParameterizedThreadStart(summ))
            {
                Name = "Поток расчета суммы чисел",
                Priority = ThreadPriority.Highest
            };
            Sthread.Start(N.Text);
        }

        void fact(object n)
        {
            Factorial.Text = ffact((BigInteger)n).ToString();
        }

        void summ(object n)
        {
            Summa.Text= fsumm((BigInteger)n).ToString();
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
