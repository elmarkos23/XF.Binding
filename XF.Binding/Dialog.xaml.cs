using Rg.Plugins.Popup.Extensions;
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
            lvDatos.ItemsSource = Get();
        }
        public List<Producto> Get()
        {
            List<Producto> lst = new List<Producto>();
            lst.Add(new Producto { id = 0, Nombre = "Mododroid 1" });
            lst.Add(new Producto { id = 0, Nombre = "Mododroid 2" });
            lst.Add(new Producto { id = 0, Nombre = "Mododroid 3" });
            lst.Add(new Producto { id = 0, Nombre = "Mododroid 4" });
            lst.Add(new Producto { id = 0, Nombre = "Mododroid 5" });
            return lst;
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as Producto;
                if (item == null)
                    return;
                EntValor.Text =item.Nombre.ToString();
                await Navigation.PopPopupAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Aceptar");
            }

            
        }
    }
}