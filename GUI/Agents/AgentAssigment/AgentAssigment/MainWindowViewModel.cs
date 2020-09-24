using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using AgentAssignment;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;

namespace AgentAssigment
{
    [Serializable]
    class MainWindowViewModel : BindableBase
    {

        ObservableCollection<Agent> listData;
        private string filename = "";
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
                    SetProperty(ref currentAgent, value);
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

        private int currentIndex = -1;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                SetProperty(ref currentIndex, value);
            }
        }

        private ICommand nextAgentCommand;

        public ICommand NextAgentCommand
        {
            get
            {
                return nextAgentCommand ?? (nextAgentCommand =
                        new DelegateCommand(NextCommandExecute, NextCommandCanExecute).ObservesProperty(() =>
                            CurrentIndex)
                    );
            }
        }
        private void NextCommandExecute()
        {
            if (CurrentIndex < listData.Count - 1) ++CurrentIndex;
        }
        private bool NextCommandCanExecute()
        {
            if (CurrentIndex < listData.Count -1)
                return true;
            else
                return false;
        }

        private ICommand previousAgentCommand;

        public ICommand PreviousAgentCommand
        {
            get
            {
                return previousAgentCommand ?? (previousAgentCommand =
                        new DelegateCommand(PreviousCommandExecute, PreviousCommandCanExecute).ObservesProperty(() =>
                            CurrentIndex)
                    );
            }
        }
        private void PreviousCommandExecute()
        {
            if (CurrentIndex > 0) --CurrentIndex;
        }
        private bool PreviousCommandCanExecute()
        {
            if (CurrentIndex > 0)
                return true;
            else
                return false;
        }

        private ICommand addAgentCommand;

        public ICommand AddAgentCommand
        {
            get
            {
                return addAgentCommand ?? (addAgentCommand =
                        new DelegateCommand(AddAgentCommandHandler));
            }
        }
        private void AddAgentCommandHandler()
        {
            listData.Add(new Agent("new","new","new","new"));
            CurrentIndex = listData.Count - 1;
        }

        private ICommand deleteAgentCommand;

        public ICommand DeleteAgentCommand
        {
            get
            {
                return deleteAgentCommand ?? (deleteAgentCommand =
                        new DelegateCommand(DeleteCommandExecute, DeleteCommandCanExecute).ObservesProperty(() =>
                            CurrentIndex)
                    );
            }
        }
        private void DeleteCommandExecute()
        {
            if (CurrentIndex >= 0) listData.RemoveAt(currentIndex);
        }
        private bool DeleteCommandCanExecute()
        {
            if (CurrentIndex >= 0 && listData.Count > 0)
                return true;
            else
                return false;
        }

        ICommand closeAppCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                return closeAppCommand ?? (closeAppCommand = new DelegateCommand(() =>
                {
                    App.Current.MainWindow.Close();
                }));
            }
        }

        ICommand savewFileAsCommand;
        public ICommand SaveFileAsCommand
        {
            get
            {
                return savewFileAsCommand ?? (savewFileAsCommand = new DelegateCommand(() =>
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.ShowDialog();
                    if (saveFileDialog.FileName != "")
                    {
                        // Create an instance of the XmlSerializer class and specify the type of object to serialize.
                        XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Agent>));
                        TextWriter writer = new StreamWriter(saveFileDialog.FileName);
                        // Serialize all the agents.
                        serializer.Serialize(writer, listData);
                        writer.Close();
                        filename = saveFileDialog.FileName;
                    }
                }));
            }
        }

        ICommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return _SaveCommand ?? (_SaveCommand = new DelegateCommand(SaveFileCommand_Execute, SaveFileCommand_CanExecute)
                    .ObservesProperty(() => listData.Count));
            }
        }

        private void SaveFileCommand_Execute()
        {
            // Create an instance of the XmlSerializer class and specify the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Agent>));
            TextWriter writer = new StreamWriter(filename);
            // Serialize all the agents.
            serializer.Serialize(writer, listData);
            writer.Close();
        }

        private bool SaveFileCommand_CanExecute()
        {
            return (filename != "") && (listData.Count > 0);
        }
        /*
        ICommand _NewFileCommand;
        public ICommand NewFileCommand
        {
            get { return _NewFileCommand ?? (_NewFileCommand = new DelegateCommand(NewFileCommand_Execute)); }
        }

        private void NewFileCommand_Execute()
        {
            MessageBoxResult res = MessageBox.Show("Any unsaved data will be lost. Are you sure you want to initiate a new file?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (res == MessageBoxResult.Yes)
            {
                listData.Clear();
                filename = "";
            }
        }
        

        ICommand _OpenFileCommand;
        public ICommand OpenFileCommand
        {
            get { return _OpenFileCommand ?? (_OpenFileCommand = new DelegateCommand<string>(OpenFileCommand_Execute)); }
        }

        private void OpenFileCommand_Execute(string argFilename)
        {
            if (argFilename == "")
            {

                MessageBox.Show("You must enter a file name in the File Name textbox!", "Unable to save file",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                filename = argFilename;
                var tempAgents = new ObservableCollection<Agent>();

                // Create an instance of the XmlSerializer class and specify the type of object to deserialize.
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Agent>));
                try
                {
                    TextReader reader = new StreamReader(filename);
                    // Deserialize all the agents.
                    tempAgents = (ObservableCollection<Agent>)serializer.Deserialize(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to open file", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                listData = tempAgents;

                // We have to insert the agents in the existing collection. 
                //Agents.Clear();
                //foreach (var agent in tempAgents)
                //    Add(agent);
            }
        }*/
    }
}
