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
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        public ListBox()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });

            lbMaches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMaches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: " 
                    + (lbMaches.SelectedItem as Match).Team1 + " " +
                    (lbMaches.SelectedItem as Match).Score1 + " " + 
                    (lbMaches.SelectedItem as Match).Score2 + " " +
                    (lbMaches.SelectedItem as Match).Team2);
                    
               
            }
            
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}