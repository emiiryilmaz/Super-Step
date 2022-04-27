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
    public partial class DetailPage : ContentPage
    {
        public List<ProductDetail> IList { get; set; }
        public IList<ProductDetail> GeneralDetailList { get; set; }
     
        public DetailPage(int id)

        {           
            InitializeComponent();
            GeneralDetailList = new List<ProductDetail>(); 
            GeneralDetailList.Add(new ProductDetail { DetailImageURL = "pinkconversedetail.jpg", ProductID = 5, ProductBrand = "Converse", ProductDetails = "Converse Chuck Taylor All Star Move Canvas Kadın Pembe Sneaker", ProductPrice = "1299 TL" });
            GeneralDetailList.Add(new ProductDetail { DetailImageURL = "pinkconversedetail1.jpg", ProductID = 5 });
            GeneralDetailList.Add(new ProductDetail { DetailImageURL = "pinkconverse3.jpg", ProductID = 5 });
            GeneralDetailList.Add(new ProductDetail { DetailImageURL = "converseblackdetail.jpg", ProductID = 1 });
            GeneralDetailList.Add(new ProductDetail { DetailImageURL = "converseblackdetail1.jpg", ProductID = 1 });              
            IList = GeneralDetailList.Where(x => x.ProductID == id).ToList();         
            this.BindingContext = this;           
        }

        private void addbasketbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BasketPage());
        }

        private void addmyfavoritesbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
    public class ProductDetail
    {

        public string DetailImageURL
        {
            get;
            set;
        }

        public int ProductID
        {
            get;
            set;
        }
        public string ProductBrand
        {
            get;
            set;
        }
        public string ProductDetails
        {
            get;
            set;
        }
        public string ProductPrice
        {
            get;
            set;
        }

    }

    }