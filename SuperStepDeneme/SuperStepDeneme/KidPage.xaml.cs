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
    public partial class KidPage : ContentPage
    {
        public KidPage()
        {
            InitializeComponent();
        }

        private void kidskechers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("KidSkechers"));

        }

        private void kidpuma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("KidPuma"));

        }
    }
}