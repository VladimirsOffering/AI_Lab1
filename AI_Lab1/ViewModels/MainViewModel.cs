using AI_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AI_Lab1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<IMessage> Messages { get; set; }

        string currentText;
        public string CurrentText
        {
            get => currentText;
            set
            {
                currentText = value;
                OnPropertyChanged("CurrentText");
            }
        }

        private ICommand sendMsgCommand;
        public ICommand SendMsgCommand
        {
            get
            {
                if (sendMsgCommand == null)
                {
                    sendMsgCommand = new RelayCommand(
                        param => this.SendMessage()
                    );
                }
                return sendMsgCommand;
            }
        }

        public void SendMessage()
        {
            if (String.IsNullOrWhiteSpace(CurrentText))
            {
                return;
            }
            Messages.Add(new UserMessage(CurrentText));
            CurrentText = "";
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<IMessage>();
            Messages.Add(new ProgrammMessage("Вы загадали гриб?"));
            Messages.Add(new UserMessage("test"));
        }
    }
}
