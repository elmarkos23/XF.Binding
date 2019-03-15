using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static XF.Binding.Dialog2;

namespace XF.Binding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        
        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            mytexto.Unfocus();
            fun();
            
         
        }
        private async void fun()
        {
            await PopupNavigation.Instance.PushAsync(new Dialog() { CloseWhenBackgroundIsClicked = false });

        }

        private async void Mytexto2_Focused(object sender, FocusEventArgs e)
        {
            mytexto2.Unfocus();
           
        }
    }
}
