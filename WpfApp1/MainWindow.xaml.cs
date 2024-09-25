using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IsPalindrome(string text)
        {
            return text == new string(text.Reverse().ToArray()); // "System.Collections.Generic.IEnumerable<char>" в "char*"

        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            bool isPalindrome = IsPalindrome(i.Text);

          if (isPalindrome) 
            {
                qwe.Text = "Правильно";
            }   
          else
            {
                qwe.Text = "это не Полидром";
            }
           
        }
    }
}
