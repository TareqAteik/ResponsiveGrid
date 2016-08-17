using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveGrid
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<string> items = new ObservableCollection<string>();

        public ObservableCollection<string> Items
        {
            get
            {
                return items;
            }

            set
            {
                if (value != items)
                {
                    value = items;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Items"));
                }
            }
        }

        public MainViewModel()
        {
            for (var i = 0; i < 10; i++)
                Items.Add("http://lorempixel.com/150/150/sports/" + i);
            for (var i = 0; i < 10; i++)
                Items.Add("http://lorempixel.com/150/150/city/" + i);
        }
    }
}
