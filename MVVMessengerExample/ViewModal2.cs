using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;

namespace MVVMessengerExample
{
    public class ViewModal2 : INotifyPropertyChanged
    {
        public ViewModal2()
        {
            Name = "just initialized";
            Messenger.Default.Register<string>(this, OnMessageUpdate);
        }

        private string name;
        public string Name { get { return name;  } set { name = value; OnPropertyChanged("Name"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        //https://docs.microsoft.com/en-us/dotnet/framework/wpf/data/how-to-implement-property-change-notification
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void OnMessageUpdate(string Name)
        {
            this.Name = Name;
        }
    }
}
