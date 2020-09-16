using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AgentAssignment;

namespace AgentAssigment
{
    
    class MainWindowViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Agent> listData;

        public MainWindowViewModel()
        {
            listData = new ObservableCollection<Agent>();
            Agent test1 = new Agent("xxx", "Test", "none", "none");
            Agent test2 = new Agent("xxx", "Test2", "none", "none");
            listData.Add(test1);
            listData.Add(test2);
            CurrentAgent = listData[0];

        }

        Agent currentAgent = null;

        public Agent CurrentAgent
        {
            get { return currentAgent; }
            set
            {
                if (currentAgent != value)
                {
                    currentAgent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Agent> ListData
        {
            get
            {
                return listData;
            }
        }

        public void AddNewAgent()
        {
            listData.Add(new Agent());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
