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

namespace HT04_Task01
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

        public object Clone()
        {
            // shallow copy (поверхневе копіювання) - копіюються лише 
            // значення value типів та посилання reference типів
            ColorTemplate clone = (ColorTemplate)this.MemberwiseClone();

            // deep copy (глибоке копіювання) - кожний reference тип
            // копіюється власним методом клонування
            clone.Hex = (string)this.Hex.Clone();
            return clone;
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
    internal sealed class ViewModel : INotifyPropertyChanged
    {
        private readonly Command _addCommand;
        private readonly Command _removeCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ICollection<ColorTemplate> Colors = new ObservableCollection<ColorTemplate>();

        private Color _color = new Color();

        public ViewModel()
        {
            _color.A = 50;
            _color.R = 50;
            _color.G = 50;
            _color.B = 50;

            _addCommand = new DelegateCommand(() => Colors.Add(SelectedColor), () => Colors.Where(c => c.Hex == SelectedColor.Hex).Count() == 0);
            _removeCommand = new DelegateCommand(() => Colors.Remove(Colors.Where(c => c.Hex == SelectedColor.Hex).FirstOrDefault()), SelectedColor != null);
        }

        public byte Alpha
        {
            get => _color.A;
            set
            {
                _color.A = value;
                OnPropertyChanged(nameof(SelectedColor));
                OnPropertyChanged(nameof(Alpha));
            }
        }

        public byte Red
        {
            get => _color.R;
            set
            {
                _color.R = value;
                OnPropertyChanged(nameof(SelectedColor));
                OnPropertyChanged(nameof(Red));
            }
        }

        public byte Green
        {
            get => _color.G;
            set
            {
                _color.G = value;
                OnPropertyChanged(nameof(SelectedColor));
                OnPropertyChanged(nameof(Green));
            }
        }

        public byte Blue
        {
            get => _color.B;
            set
            {
                _color.B = value;
                OnPropertyChanged(nameof(SelectedColor));
                OnPropertyChanged(nameof(Blue));
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
