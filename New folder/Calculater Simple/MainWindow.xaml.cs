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

namespace Calculater
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

        int count;
        float num, ans;
        Boolean lbl = false;


        private void point_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + ".";
            }
            else
            {
                textBox.Text = textBox.Text + ".";

            }
        }
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";

            }
        }     
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";

            }
        }

        private void tow_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";

            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";

            }
        }

        private void _for_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";

            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";

            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";

            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";

            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";

            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = textBox.Text + "9";
            }
            else
            {
                    textBox.Text = textBox.Text + "9";                
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num = float.Parse(textBox.Text);
                if (lbl == false)
                {
                    label.Content = string.Empty;
                    label.Content = num + " /";
                }
                else
                {
                    
                }
                textBox.Clear();
                textBox.Focus();

                count = 1;
            }
            catch (SystemException)
            {
                textBox.Text = string.Empty;
                label.Content = "Syntax Error";
            }

        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                num = float.Parse(textBox.Text);
                if (lbl == false)
                {
                    label.Content = num + " *";
                }             

                textBox.Clear();
                textBox.Focus();
                count = 2;
            }
            catch(SystemException)
            {
                textBox.Text = string.Empty;
                label.Content = "Syntax Error";
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num = float.Parse(textBox.Text);
                if (lbl == false)
                {
                    label.Content = num + " -";
                }
                textBox.Clear();
                textBox.Focus();
                count = 3;
            }
            catch (SystemException)
            {
                textBox.Text = string.Empty;
                label.Content = "Syntax Error";
            }
        }

        private void pluse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num = float.Parse(textBox.Text);

                if (lbl == false)
                {
                    label.Content = num + " +";
                }

                textBox.Clear();
                textBox.Focus();
                count = 4;
            }
            catch (SystemException)
            {
                textBox.Text = string.Empty;
                label.Content = "Syntax Error";
            }
        }

        private void root_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double sqer = double.Parse(textBox.Text);
                label.Content = "√" + sqer;

                double sqrt = Math.Sqrt(sqer);
                textBox.Text = Convert.ToString(Math.Round(sqrt, 8).ToString());
            }
            catch (SystemException)
            {
                textBox.Text = string.Empty;
                label.Content = "Syntax Error";
            }
        }
        private void result_Click(object sender, RoutedEventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    try
                    {
                        if (lbl == false)
                        {
                            label.Content = num + " / " + textBox.Text;

                            ans = num / float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                            lbl = true;
                        }
                        else
                        {
                            label.Content = label.Content + " / " + textBox.Text;

                            ans = num / float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                            lbl = true;
                        }
                    }
                    catch (SystemException)
                    {
                        textBox.Text = string.Empty;
                        label.Content = "Syntax Error";
                    }
                   
                    
                    break;
                case 2:
                    try
                    {
                        if (lbl == false)
                        {
                            label.Content = num + " * " + textBox.Text;

                            ans = num * float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                            lbl = true;
                        }
                        else
                        {
                            label.Content = label.Content + " * " + textBox.Text;

                            ans = num * float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                        }
                       

                    }
                    catch (SystemException)
                    {
                        textBox.Text = string.Empty;
                        label.Content = "Syntax Error";
                    }
                    break;
                case 3:

                    try
                    {
                        if (lbl == false)
                        {

                            label.Content = num + " - " + textBox.Text;

                            ans = num - float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                            lbl = true;
                        }
                        else
                        {
                            label.Content = label.Content + " - " + textBox.Text;

                            ans = num - float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                        }

                    }
                    catch (SystemException)
                    {
                        textBox.Text = string.Empty;
                        label.Content = "Syntax Error";
                    }
                   
                    break;
                case 4:
                    try
                    {
                        if (lbl == false)
                        {
                            label.Content = num + " + " + textBox.Text;

                            ans = num + float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();
                            lbl = true;
                        }
                        else
                        {
                            label.Content = label.Content + " + " + textBox.Text;
                            ans = num + float.Parse(textBox.Text);
                            textBox.Text = ans.ToString();

                        }
                        

                    }
                    catch (SystemException)
                    {
                        textBox.Text = string.Empty;
                        label.Content = "Syntax Error";
                    }
                   
                    break;
                default:
                    label.Content = "Wrong Method";
                    break;
            }
        }

        private void fact_Click(object sender, RoutedEventArgs e)
        {
            try
            { 

                int f = 1;
                float num = float.Parse(textBox.Text);
                double a = Math.Round(num);
                for (int i = 1; i <= a; i++)
                {
                    f = f * i;

                }
                textBox.Text = f.ToString();
                label.Content = textBox.Text + "! =";
                f = 1;
            }
            catch (SystemException)
            {
                textBox.Text = "syentax Error!";
            }

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            lbl = false;
        }
    }
}
