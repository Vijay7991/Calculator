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

namespace Calculator
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

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ".";

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text ="";

        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";

        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";

        }

        private void _for_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";

        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";

        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";

        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";

        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";

        }

        int f = 1;
        private void lpar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num = float.Parse(textBox.Text);
                double a = Math.Round(num);
                for (int i = 1; i <= a; i++)
                {
                    f = f * i;

                }
                textBox.Text = textBox.Text + "! =" + f;
                f = 1;
            }
            catch(SystemException)
            {
                textBox.Text = "syentax Error!";
            }
            

            //textBox.Text = textBox.Text + "(";

        }

        private void rpar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double sqr = double.Parse(textBox.Text);
                textBox.Text = textBox.Text + "=" + Convert.ToString(Math.Sqrt(sqr));
            }
            catch(SystemException)
            {
                textBox.Text = "Syntex Error";
            }

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "+";

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "-";

        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";

        }

        private void div_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "/";

        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;
            try
            {
                var res = obj.Eval(textBox.Text);
                str = Convert.ToString(res);
                textBox.Text = textBox.Text + "=" + str;
            }
            catch(SystemException)
            {
                textBox.Text = "Syntex Error";
                
            }
        }


        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text != "")
                {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                
            }
        }

       
    }
}
