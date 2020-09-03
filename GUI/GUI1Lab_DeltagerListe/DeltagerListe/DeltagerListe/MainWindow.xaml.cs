using System;
using System.Collections;
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
using System.IO;
using System.Text;

namespace DeltagerListe
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] tokens;
            char[] seperators = { ',' };
            string str = "";

            FileStream fs = new FileStream(@"C:\Users\Tue\OneDrive - Aarhus Universitet\Mappe\Opgave4_semester\GUI\GUI1Lab_DeltagerListe deltagerliste.csv",
                                       FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            
            //while ((str = sr.ReadLine())!=null)
            //{
                str = sr.ReadLine();
                tokens = str.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(String.Format("{0,-20}", tokens[0]) +
                              String.Format("{0,-15}", tokens[1]) +
                              String.Format("{0,-15}", tokens[2]));
            //}

            liste.ItemsSource = tokens;
            sr.Close();
            fs.Close();

            Console.ReadLine();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
