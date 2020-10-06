using AgentAssignment;
using System.Windows;

namespace AgentAssignmentLab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Agent agent = new Agent("007", "James Bond", "Assassination", "UpperVolta");
        public MainWindow()
        {
            InitializeComponent();
            DataContext = agent;
        }
    }
}
