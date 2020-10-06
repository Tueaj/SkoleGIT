using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using AgentAssignment;

namespace AgentAssigment
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

        /*private void AddNewClicked(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            vm.AddNewAgent();
            InfoList.SelectedIndex = InfoList.Items.Count - 1;

        }

        private void NextClicked(object sender, RoutedEventArgs e)
        {
            if (InfoList.SelectedIndex < InfoList.Items.Count - 1)
            {
                InfoList.SelectedIndex++;
            }

        }

        private void BackClicked(object sender, RoutedEventArgs e)
        {
            if (InfoList.SelectedIndex > 0)
            {
                InfoList.SelectedIndex--;
            }
        }*/
    }
}
