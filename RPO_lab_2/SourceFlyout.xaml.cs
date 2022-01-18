using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPO_lab_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SourceFlyout : ContentPage
    {
        public ListView ListView;

        public SourceFlyout()
        {
            InitializeComponent();

            BindingContext = new SourceFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class SourceFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SourceFlyoutMenuItem> MenuItems { get; set; }

            public SourceFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<SourceFlyoutMenuItem>(new[]
                {
                    new SourceFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new SourceFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new SourceFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new SourceFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new SourceFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}