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
    /// Interaction logic for DependencyProperties.xaml
    /// </summary>
    public partial class DependencyProperties : Window
    {
        //Creating own dependency property
        public int MyProperty
        {
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        public static readonly DependencyProperty myDependencyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(DependencyProperties), new PropertyMetadata(0)); 

        public DependencyProperties()
        {
            InitializeComponent();
        }
    }

   

}
