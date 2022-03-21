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

namespace WpfApp5.WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            if (double.TryParse(this.a.Text, out a) && double.TryParse(this.b.Text, out b) && double.TryParse(this.c.Text, out c))
            {
                double d, x1, x2;
                string message;
                KU.KvUr(a, b, c, out d, out x1, out x2, out message);
                string result = "";
                if (!double.IsNaN(d)) result += $"D={d}\n";
                if (!double.IsNaN(x1)) result += $"X1={x1}\n";
                if (!double.IsNaN(x2)) result += $"X2={x2}\n";
                if (!string.IsNullOrEmpty(message)) result += message;
                this.result.Text = result;
            }
        }
    }
}
