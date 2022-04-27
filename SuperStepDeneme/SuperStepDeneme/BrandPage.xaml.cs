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
    public partial class BrandPage : ContentPage
    {
        public BrandPage()
        {
            InitializeComponent();
        }

        private void converse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanConverse"));
        }

        private void skechers_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new ProductsByCategory("KidSkechers"));
        }

        private void nike_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("ManNike"));
        }
    }
}