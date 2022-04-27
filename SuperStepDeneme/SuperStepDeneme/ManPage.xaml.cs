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
    public partial class ManPage : ContentPage
    {
        public ManPage()
        {
            InitializeComponent();
        }

        private void manconverse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("ManConverse"));
        }

        private void mannike_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("ManNike"));
        }

        private void manadidas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductsByCategory("ManAdidas"));
        }
    }
}