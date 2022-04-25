using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStepDeneme
{
    public static class DataGenerator
    {
        public static List<Product> Datas = new List<Product>();
        public static List<Product> GetData()
        {
            Datas.Add(new Product { Id = 1, Price = 250, Model = "taylor", Name = "Converse", Image = @"Resources\drawable\blackconversechuck.jpg" , Categoryid =1 });
            Datas.Add(new Product { Id = 2, Price = 250f, Model = "taylor", Name = "Converse", Image = @"Resources\drawable\conversechuckerkek.jpg", Categoryid = 1 });
            Datas.Add(new Product { Id = 3, Price = 250f, Model = "taylor", Name = "Converse", Image = @"Resources\drawable\siyahconversechucktaylor.jpg", Categoryid = 3 });
            Datas.Add(new Product { Id = 4, Price = 250f, Model = "taylor", Name = "Converse", Image = @"Resources\drawable\siyahconversechuck70.jpg", Categoryid = 2 });
            return Datas;
        }
    }
}
