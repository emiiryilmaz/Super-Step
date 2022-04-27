using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperStepDeneme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsByCategory : ContentPage
    {
        public List<Product> IList  { get; set; }
        public IList<Product> GeneralList { get; set; }
        public ProductsByCategory(string model)
        {
            
            InitializeComponent();
            GeneralList = new List<Product>();
            GeneralList.Add(new Product { ImageURL = "blackconversechuck.jpg",ProductBrand = "ManConverse", Gender ="Erkek" ,ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 ,ProductID =1 });
            GeneralList.Add(new Product { ImageURL = "conversechuckerkek.jpg", ProductBrand = "ManConverse", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 2 });
            GeneralList.Add(new Product { ImageURL = "siyahconversechucktaylor.jpg", ProductBrand = "ManConverse", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 3});
            GeneralList.Add(new Product { ImageURL = "siyahconversecuhck70.jpg", ProductBrand = "ManConverse", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 4 });
            
            GeneralList.Add(new Product { ImageURL = "pinkconverse.jpg", ProductBrand = "WomanConverse", Gender = "Kadın", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100,ProductID = 5 });
            GeneralList.Add(new Product { ImageURL = "blackconversechuck.jpg", ProductBrand = "WomanConverse", Gender = "Kadın", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 6 });
            GeneralList.Add(new Product { ImageURL = "siyahconversechucktaylor.jpg", ProductBrand = "WomanConverse", Gender = "Kadın", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 7 });
            GeneralList.Add(new Product { ImageURL = "siyahconversecuhck70.jpg", ProductBrand = "WomanConverse", Gender = "Kadın", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 8 });
            
            GeneralList.Add(new Product { ImageURL = "mannike1.jpg", ProductBrand = "ManNike", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 9});
            GeneralList.Add(new Product { ImageURL = "mannike2.jpg", ProductBrand = "ManNike", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 10 });
            GeneralList.Add(new Product { ImageURL = "mannike3.jpg", ProductBrand = "ManNike", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 11 });
            GeneralList.Add(new Product { ImageURL = "mannike4.jpg", ProductBrand = "ManNike", Gender = "Erkek", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 12 });

            GeneralList.Add(new Product { ImageURL = "womannike1.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 13 });
            GeneralList.Add(new Product { ImageURL = "womannike2.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 14 });
            GeneralList.Add(new Product { ImageURL = "womannike3.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 15 });
            GeneralList.Add(new Product { ImageURL = "womannike4.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 16 });

            GeneralList.Add(new Product { ImageURL = "kidskechers1.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 17 });
            GeneralList.Add(new Product { ImageURL = "kidskechers2.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 18 });
            GeneralList.Add(new Product { ImageURL = "kidskechers3.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 19 });
            GeneralList.Add(new Product { ImageURL = "skecherskid4.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 20 });

            GeneralList.Add(new Product { ImageURL = "kidpuma1.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 21 });
            GeneralList.Add(new Product { ImageURL = "kidpuma2.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 22 });
            GeneralList.Add(new Product { ImageURL = "kidpuma3.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 23 });
            GeneralList.Add(new Product { ImageURL = "kidpuma4.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 24 });

            GeneralList.Add(new Product { ImageURL = "manadidas1.jpg", ProductBrand = "ManAdidas", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 25 });
            GeneralList.Add(new Product { ImageURL = "manadidas2.jpg", ProductBrand = "ManAdidas", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 26 });
            GeneralList.Add(new Product { ImageURL = "manadidas3.jpg", ProductBrand = "ManAdidas", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 27 });
            GeneralList.Add(new Product { ImageURL = "manadidas4.jpg", ProductBrand = "ManAdidas", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 28 });

            GeneralList.Add(new Product { ImageURL = "womanskechers1.jpg", ProductBrand = "WomanSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 29 });
            GeneralList.Add(new Product { ImageURL = "womanskechers2.jpg", ProductBrand = "WomanSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 30 });
            GeneralList.Add(new Product { ImageURL = "womanskechers3.jpg", ProductBrand = "WomanSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 31 });
            GeneralList.Add(new Product { ImageURL = "womanskechers4.jpg", ProductBrand = "WomanSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 32 });

            GeneralList.Add(new Product { ImageURL = "womanbag1.jpg", ProductBrand = "WomanBag", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 36 });
            GeneralList.Add(new Product { ImageURL = "womanbag2.jpg", ProductBrand = "WomanBag", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 33 });
            GeneralList.Add(new Product { ImageURL = "womanbag3.jpg", ProductBrand = "WomanBag", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 34 });
            GeneralList.Add(new Product { ImageURL = "womanbag4.jpg", ProductBrand = "WomanBag", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100, ProductID = 35 });



            IList = GeneralList.Where(x => x.ProductBrand == model).ToList();

            this.BindingContext = this;                       
        }

        public class Product
        {
            public string Gender
            {
                get;
                set;
            }

            public string ProductBrand
            {
                get;
                set;
            }
            public string ProductModel
            {
                get;
                set;
            }
            public int ProductID
            {
                get;
                set;
            }
     
            public string Description
            {
                get;
                set;
            }
            public string ImageURL
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public string DetailImageURL
            {
                get;
                set;
            }

        }

        private void searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = GeneralList.Where(c => c.ProductBrand.ToLower().Contains(searchbar1.Text.ToLower()));
            Collection1.ItemsSource = searchresult;
        }

        private void ProductDetail_Clicked(object sender, EventArgs e)
        {    
            Navigation.PushAsync(new DetailPage(5));      
        }

    }
}