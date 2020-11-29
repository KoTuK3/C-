using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace HT05_Task01
{

    internal sealed class ViewModel : INotifyPropertyChanged
    {
        private readonly Command _addCommand;
        private readonly Command _removeCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ICollection<ColorTemplate> Colors = new ObservableCollection<ColorTemplate>();

        private Color _color = new Color();
        private bool _isAlphaActive;
        private bool _isRedActive;
        private bool _isGreenActive;
        private bool _isBlueActive;

        public ViewModel()
        {
            Alpha = 255;
            Red = 50;
            Green = 50;
            Blue = 50;

            IsAlphaActive = true;
            IsRedActive = true;
            IsGreenActive = true;
            IsBlueActive = true;

            _addCommand = new DelegateCommand(AddColor, () => Colors.Where(c => c.Hex == SelectedColor.Hex).Count() == 0);
            _removeCommand = new DelegateCommand(RemoveItem);
        }

        public void RemoveItem(object parameter)
        {
            var item = parameter as ColorTemplate;
            if (item != null)
                Colors.Remove(item);
        }

        private void AddColor()
        {
            if (Colors.Where(c => c.Hex == SelectedColor.Hex).Count() == 0)
            {
                Colors.Add(SelectedColor);
            }
        }

        public bool IsAlphaActive
        {
            get => _isAlphaActive;
            set
            {
                _isAlphaActive = value;
                OnPropertyChanged(nameof(IsAlphaActive));
            }
        }

        public bool IsRedActive
        {
            get => _isRedActive;
            set
            {
                _isRedActive = value;
                OnPropertyChanged(nameof(IsRedActive));
            }
        }

        public bool IsGreenActive
        {
            get => _isGreenActive;
            set
            {
                _isGreenActive = value;
                OnPropertyChanged(nameof(IsGreenActive));
            }
        }

        public bool IsBlueActive
        {
            get => _isBlueActive;
            set
            {
                _isBlueActive = value;
                OnPropertyChanged(nameof(IsBlueActive));
            }
        }

        public byte Alpha
        {
            get => _color.A;
            set
            {
                if (IsAlphaActive)
                {
                    _color.A = value;
                    OnPropertyChanged(nameof(SelectedColor));
                    OnPropertyChanged(nameof(Alpha));
                }
            }
        }

        public byte Red
        {
            get => _color.R;
            set
            {
                if (IsRedActive)
                {
                    _color.R = value;
                    OnPropertyChanged(nameof(SelectedColor));
                    OnPropertyChanged(nameof(Red));
                }
            }
        }

        public byte Green
        {
            get => _color.G;
            set
            {
                if (IsGreenActive)
                {
                    _color.G = value;
                    OnPropertyChanged(nameof(SelectedColor));
                    OnPropertyChanged(nameof(Green));
                }
            }
        }

        public byte Blue
        {
            get => _color.B;
            set
            {
                if (IsBlueActive)
                {
                    _color.B = value;
                    OnPropertyChanged(nameof(SelectedColor));
                    OnPropertyChanged(nameof(Blue));
                }
            }
        }

        public ColorTemplate SelectedColor
        {
            get => new ColorTemplate(_color);
            set
            {
                _color = (Color)ColorConverter.ConvertFromString(value?.Hex);
                Alpha = _color.A;
                Red = _color.R;
                Green = _color.G;
                Blue = _color.B;

                OnPropertyChanged(nameof(SelectedColor));
            }
        }

        public IEnumerable<ColorTemplate> SelectedColors => Colors;

        public ICommand AddCommand => _addCommand;

        public ICommand RemoveCommand => _removeCommand;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
