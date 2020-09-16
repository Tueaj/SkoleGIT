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
            ObservableCollection<Agent> listData;
            listData = new ObservableCollection<Agent>();
            Agent test1 = new Agent("xxx","Test","none","none");
            Agent test2 = new Agent("xxx", "Test2", "none", "none");
            listData.Add(test1);
            listData.Add(test2);
            InfoList.ItemsSource = listData;


        }
    }
}
