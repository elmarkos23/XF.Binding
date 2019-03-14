﻿using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Binding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dialog : PopupPage
    {
		public Dialog ()
		{
			InitializeComponent ();
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}