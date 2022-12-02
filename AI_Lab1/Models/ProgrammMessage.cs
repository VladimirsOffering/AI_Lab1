using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab1.Models
{
    class ProgrammMessage :  ViewModelBase , IMessage
    {
        string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        public ProgrammMessage(string text)
        {
            Text = text;
        }
    }
}
