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
    public partial class WomanPage : ContentPage
    {
        public WomanPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void womanskechers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanSkechers"));
        }

        private void womanadidas_Clicked(object sender, EventArgs e)
        {

        }

        private void womannewbalance_Clicked(object sender, EventArgs e)
        {

        }

        private void womanlacoste_Clicked(object sender, EventArgs e)
        {

        }

        private void womanconverse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanConverse"));
        }

        private void womannike_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanNike"));
        }

        private void womanblazer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanNike"));

        }

        private void womannconverse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanConverse"));
        }

        private void womanbag_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("WomanBag"));
        }
    }
}