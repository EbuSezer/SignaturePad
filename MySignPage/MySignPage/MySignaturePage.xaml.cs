using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySignPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MySignaturePage : ContentPage
	{
		public MySignaturePage ()
		{
			InitializeComponent ();
		}

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            mySignView.Clear();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Stream image = await mySignView.GetImageStreamAsync(SignatureImageFormat.Jpeg);
        }
    }
}