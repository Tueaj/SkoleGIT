using AgentAssignment;
using System.Collections.Generic;
using System.Windows;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Agent> agents = new List<Agent>();

        public MainWindow()
        {
            InitializeComponent();
            agents.Add(new Agent() { ID = "001", CodeName = "Nina", Speciality = "Assassination", Assignment = "UpperVolta" });
            agents.Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            agentGrid.DataContext = agents;
        }
    }
}
