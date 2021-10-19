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

namespace if_and_else
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

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(textbox1.Text);
            int ageMonths = age * 12;
            if(ageMonths == 1)
            {
                MessageBox.Show("You are " + ageMonths + " month old");
            }
            else
            {
                MessageBox.Show("You are " + ageMonths + " months old");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(textbox1.Text);
            int ageDays = age * 365;
            if (ageDays == 1)
            {
                MessageBox.Show("You are " + ageDays + " day old");
            }
            else
            {
                MessageBox.Show("You are " + ageDays + " days old");
            }
        }
    }
}
