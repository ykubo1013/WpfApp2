using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class DispText : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string TTT { get; set; } = "aaa";
        public string SSS { get; set; } = "bbb";

        public string AAA { get; set; }

        public DispText() { }

        public void SumName()
        {
            AAA = TTT + SSS;
            OnPropertyChanged("AAA");
        }


    }


}
