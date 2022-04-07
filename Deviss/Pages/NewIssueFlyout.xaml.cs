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

namespace Deviss.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewIssueFlyout : ContentPage
    {
        public ListView ListView;

        public NewIssueFlyout()
        {
            InitializeComponent();

            BindingContext = new NewIssueFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class NewIssueFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NewIssueFlyoutMenuItem> MenuItems { get; set; }

            public NewIssueFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<NewIssueFlyoutMenuItem>(new[]
                {
                    new NewIssueFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new NewIssueFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new NewIssueFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new NewIssueFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new NewIssueFlyoutMenuItem { Id = 4, Title = "Page 5" },
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