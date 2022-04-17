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
    public partial class Page1 : TabbedPage
    {
        public Page1()
        {
            InitializeComponent();
            var clr = Color.White; this.BarBackgroundColor = clr;
            var clr2 = Color.Black; this.BarTextColor = clr2;
            var clr3 = Color.DarkRed; this.SelectedTabColor = clr3;
        }
    }
}