using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace MVVMessengerExample
{
    public class ViewModal1
    {
        public ViewModal1()
        {
            Name = "I m sender";
            SendMessageCommand = new DelegateCommand<string>(OnMessageSent);
        }

        public ICommand SendMessageCommand { get; set; }

        public string Name { get; set; }

        public void OnMessageSent(string s)
        {
            Messenger.Default.Send<string>(s);
        }

    }
}
