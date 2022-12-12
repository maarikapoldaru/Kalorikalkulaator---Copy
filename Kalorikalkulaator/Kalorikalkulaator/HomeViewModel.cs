using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;
namespace Kalorikalkulaator
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!(object.Equals(field, newValue)))
            {
                field = (newValue);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
        private string details;
        public string Name { get; set; }
        public string Details { get => details; set => SetProperty(ref details, value); }
    }
}