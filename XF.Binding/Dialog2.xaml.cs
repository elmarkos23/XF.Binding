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
	public partial class Dialog2 : PopupPage
    {
        
        public enum EnumAction { NextPicture, CompletePicture };
        public TaskCompletionSource<EnumAction> task;

        public Dialog2(TaskCompletionSource<EnumAction> taskCompletion)
        {
            InitializeComponent();
            task = taskCompletion;
        }
        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            task?.SetResult(EnumAction.NextPicture);
        }

        private async void btnComplete_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            task?.SetResult(EnumAction.CompletePicture);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (task != null)
                if (!task.Task.IsCanceled && !task.Task.IsFaulted && !task.Task.IsCompleted)
                    task.SetCanceled();
        }
    }
}