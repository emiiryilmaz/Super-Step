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
    public partial class ProductsByCategory : ContentPage
    {
        public List<Product> IList  { get; set; }
        public IList<Product> GeneralList { get; set; }
        public ProductsByCategory(string model)
        {
            InitializeComponent();
            GeneralList = new List<Product>();

            GeneralList.Add(new Product { ImageURL = "blackconversechuck.jpg",ProductBrand = "ManConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "conversechuckerkek.jpg", ProductBrand = "ManConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "siyahconversechucktaylor.jpg", ProductBrand = "ManConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "siyahconversecuhck70.jpg", ProductBrand = "ManConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            
            GeneralList.Add(new Product { ImageURL = "pinkconverse.jpg", ProductBrand = "WomanConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "blackconversechuck.jpg", ProductBrand = "WomanConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "siyahconversechucktaylor.jpg", ProductBrand = "WomanConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "siyahconversecuhck70.jpg", ProductBrand = "WomanConverse", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            
            GeneralList.Add(new Product { ImageURL = "mannike1.jpg", ProductBrand = "ManNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "mannike2.jpg", ProductBrand = "ManNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "mannike3.jpg", ProductBrand = "ManNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "mannike4.jpg", ProductBrand = "ManNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });

            GeneralList.Add(new Product { ImageURL = "womannike1.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "womannike2.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "womannike3.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "womannike4.jpg", ProductBrand = "WomanNike", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });

            GeneralList.Add(new Product { ImageURL = "kidskechers1.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "kidskechers2.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "kidskechers3.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "skecherskid4.jpg", ProductBrand = "KidSkechers", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });

            GeneralList.Add(new Product { ImageURL = "kidpuma1.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "kidpuma2.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "kidpuma3.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });
            GeneralList.Add(new Product { ImageURL = "kidpuma4.jpg", ProductBrand = "KidPuma", ProductModel = "Chuck Taylor ", Description = " Erkek Siyah Sneaker", Price = 100 });



            IList = GeneralList.Where(x => x.ProductBrand == model).ToList();
            this.BindingContext = this;                       
        }
      
        public class Product
        {

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

        }
    }
}