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

namespace Moneycal
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double revenue = double.Parse(txtRevenue.Text);
            double expense = double.Parse(txtExpense.Text);
            double item    = double.Parse(txtItem.Text);
            
            double sum = revenue - expense;
            double period = item / sum;
            txtPeriod.Text = period.ToString();
            



        }
    }
}
