using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavPageSample.page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage3 : ContentPage
    {
        
    // Launcher.OpenAsync is provided by Xamarin.Essentials.
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
       

    
    public MainPage3()
        {
            InitializeComponent();
             BindingContext = this;

         
    }

      






      
        private async void Button4_Clicked(object sender, EventArgs e)
        {

                ZXing.Mobile.MobileBarcodeScanner scanner = new ZXing.Mobile.MobileBarcodeScanner();

                ZXing.Result result = await scanner.Scan();
            
            



            if (result != null)
            {   

                msg.Text = result.Text;

                Label label = new Label
                {
                    Text = result.Text,
                    TextType = TextType.Html
                };
            }

      
          
 
    }




    }
}
