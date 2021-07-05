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

namespace WPF_Exercises
{
    /// <summary>
    /// Interaction logic for RadioButtonsAndImages.xaml
    /// </summary>
    public partial class RadioButtonsAndImages : Window
    {
        public RadioButtonsAndImages()
        {
            InitializeComponent();
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes");
        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say yes");

        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you");
        }
    }
}
