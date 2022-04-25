using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStepDeneme
{
    public class Product
    {
        private int id;
        private int categoryid;
        private string name;
        private double price;
        private string image;
        private string model;
        public Product()
        {

        }
        public Product(int id_, double price_, string image_, string model_, string name_, int categoryid_)
        {
            id = id_;
            price = price_;
            image = image_;
            model = model_;
            name = name_;
            categoryid = categoryid_;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }


    }
}
