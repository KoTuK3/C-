using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HT05_Task01
{
    class ColorTemplate : INotifyPropertyChanged
    {
        public string _hex;
        public ColorTemplate(object color)
        {
            Hex = color.ToString();
        }
        public string Hex
        {
            get => _hex;
            set
            {
                _hex = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return _hex;
        }
    }
}
