using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperStepDeneme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
      
            InitializeComponent();
            

        }

        private void brandsmenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BrandPage());
        }

        private void manmenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManPage());
        }

        private void womanmenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WomanPage());
        }

        private void kidmenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KidPage());
        }
    }
}