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

namespace In_class_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Txt_Favorite_Color.Text = string.Empty;
            Txt_Enter_Name.Clear();
            btnClickMe.IsEnabled = false;
            //assign text as variable
            var x = Txt_Favorite_Color.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var response=  MessageBox.Show("You clicked me!", "Enter title here", MessageBoxButton.YesNoCancel);
            string message = $"Hey {Txt_Enter_Name.Text} that's cool that your favorite color is {Txt_Favorite_Color.Text}!";
            MessageBox.Show(message, "!~Welcome to MIS 3033~!");
        }

        private void Txt_Favorite_Color_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show("You changed me!");
        }

        private void Txt_Enter_Name_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Key down!");

        }

        private bool ShouldWeEnableTheButton()
        {
            bool result = false;
            if (Txt_Favorite_Color.Text != string.Empty
                && Txt_Enter_Name.Text != string.Empty)
            {
                result = true;
            }

            return result;
        }
    }
}
