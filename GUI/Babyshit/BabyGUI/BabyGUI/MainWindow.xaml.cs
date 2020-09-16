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

namespace BabyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<BabyName> babyList { get; set; }
        private string[,] BnGName { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            babyList = new List<BabyName>();
        }

        private void LoadTopNames(object sender, RoutedEventArgs e)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("babynames.txt");
            while ((line = file.ReadLine()) != null)
            {
                babyList.Add(new BabyName(line));
            }
            file.Close();
            BnGName = new string[11, 10];
            for (int i = 0; i < 11; i++)
            {
                foreach (BabyName babyName in babyList)
                {
                    int rank = babyName.Rank(i*10+1900);
                    if (rank <= 10 && rank != 0)
                    {
                        if (BnGName[i, rank - 1] == null)
                            BnGName[i, rank - 1] = babyName.Name;
                        else
                            BnGName[i, rank - 1] += " and " + babyName.Name;

                    }
                }

            }

        }

        private void YearSelect(object sender, SelectionChangedEventArgs e)
        {
            int Decade = DecadeList.SelectedIndex;
            string[] decTopNames = new string[10];
            for (int i = 0; i < 10; i++)
                decTopNames[i] = BnGName[Decade, i];

            lstDecadeTopNames.ItemsSource = decTopNames;

        }
    }
}
