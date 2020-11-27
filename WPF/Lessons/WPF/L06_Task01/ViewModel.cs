using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace L06_Task01
{
    internal sealed class ViewModel : INotifyPropertyChanged
    {
        private readonly Command _addCommand;
        private readonly Command _removeCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Color> Colors = new List<Color>();

        private Color _color = new Color();
        public ViewModel()
        {
            _color.A = 50;
            _color.R = 50;
            _color.G = 50;
            _color.B = 50;

            //_addCommand = new DelegateCommand(SetBlueColor, IsCanSetBlueColor);
            //_removeCommand = new DelegateCommand(() => SelectedColor = "Green", () => SelectedColor != "Green");
        }

        public byte Alpha
        {
            get => _color.A;
            set
            {
                _color.A = value;
                OnPropertyChanged(nameof(SelectedColor));
            }
        }

        public byte Red
        {
            get => _color.R;
            set
            {
                _color.R = value;
                OnPropertyChanged(nameof(SelectedColor));
            }
        }

        public byte Green
        {
            get => _color.G;
            set 
            {
                _color.G = value;
                OnPropertyChanged(nameof(SelectedColor));
            } 
        }

        public byte Blue
        {
            get => _color.B;
            set 
            {
                _color.B = value;
                OnPropertyChanged(nameof(SelectedColor));
            } 
        }

        public void AddColor(Color color)
        {
            if (Colors.Contains(color))
            {
                Colors.Add(color);
            }
        }
        public void Remove(Color color)
        {
            if (Colors.Count > 0)
            {
                Colors.Remove(color);
            }
        }

        public Color SelectedColor
        {
            get => _color;
        }
        
        public ICommand AddCommand => _addCommand;

        public ICommand RemoveCommand => _removeCommand;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
