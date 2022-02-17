
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavPageSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlertPage());

        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LifeStylePage());

        }

        private void Button12_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MedicineEntryPage());

        }

       



    }
}