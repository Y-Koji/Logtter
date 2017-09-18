using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logtter.ViewModel
{
    class ViewModelTemplate<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
