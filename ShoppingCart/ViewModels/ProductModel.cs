using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.ViewModels;

namespace ShoppingCart.ViewModels
{
    public class ProductModel
    { 
        public List<Product> _Products { get; set; }

        public List<Product> findAll()
    {
        _Products = new List<Product> {
                        new  Product()
                    {
                        Id = "1",
                        Name = "Flower1",
                        Photo = "thumb1.jpg",
                        Price =2.80
                    },
                    new  Product()
                    {
                        Id = "2",
                        Name = "Flower2",
                        Photo = "thumb2.jpg",
                        Price =3.80
                    },
                    new  Product()
                    {
                        Id = "3",
                        Name = "Flower3",
                        Photo = "thumb3.jpg",
                        Price =4.45
                    },
                    new  Product()
                    {
                        Id = "4",
                        Name = "Flower4",
                        Photo = "thumb4.jpg",
                        Price =3.70
                    },
                    new  Product()
                    {
                        Id = "5",
                        Name = "Flower5",
                        Photo = "thumb5.jpg",
                        Price =5.80
                    },
                    new  Product()
                    {
                        Id = "6",
                        Name = "Flower6",
                        Photo = "thumb6.jpg",
                        Price =2.70
                    },
                    new  Product()
                    {
                        Id = "7",
                        Name = "Flower7",
                        Photo = "thumb7.jpg",
                        Price =3.90
                    },
                    new  Product()
                    {
                        Id = "8",
                        Name = "Flower8",
                        Photo = "thumb8.jpg",
                        Price =4.55
                    },
                    new  Product()
                    {
                        Id = "9",
                        Name = "Flower9",
                        Photo = "thumb9.jpg",
                        Price =6.70
                    },
                    new  Product()
                    {
                        Id = "10",
                        Name = "Flower10",
                        Photo = "thumb10.jpg",
                        Price =6.50
                    }
            };

        return _Products;

    }
    public Product find(string id)
    {
        List<Product> products = findAll();
        var prod = products.Where(a => a.Id == id).FirstOrDefault();
        return prod;
    }
}
}
