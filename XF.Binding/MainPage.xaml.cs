using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Binding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }

        private async void Entry_Focused(object sender, FocusEventArgs e)
        {
            mytexto.Unfocus();
            await PopupNavigation.PushAsync(new Dialog() { CloseWhenBackgroundIsClicked = false });
        }
    }
}
