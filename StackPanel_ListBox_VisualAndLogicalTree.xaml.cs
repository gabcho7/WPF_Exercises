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
    /// Interaction logic for StackPanel_ListBox_VisualAndLogicalTree.xaml
    /// </summary>
    public partial class StackPanel_ListBox_VisualAndLogicalTree : Window
    {
        public StackPanel_ListBox_VisualAndLogicalTree()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }
    }
}
