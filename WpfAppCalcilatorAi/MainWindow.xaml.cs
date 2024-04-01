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

namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string input = button.Content.ToString();

            switch (input)
            {
                case "C":
                    txtDisplay.Clear();
                    break;
                case "=":
                    try
                    {
                        var result = new System.Data.DataTable().Compute(txtDisplay.Text, null);
                        txtDisplay.Text = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        txtDisplay.Text = "Что-то не так";
                    }
                    break;
                default:
                    txtDisplay.Text += input;
                    break;
            }
        }
    }
} 
