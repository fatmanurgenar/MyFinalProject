﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //globaldeğişken
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,sql,server,postgres,mongoDb
            _products = new List<Product> {
              new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
              new Product{ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
              new Product{ProductId=3,CategoryId=3,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
              new Product{ProductId=4,CategoryId=4,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
              new Product{ProductId=5,CategoryId=5,ProductName="Fare",UnitPrice=85,UnitInStock=1},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            /*Product productToDelete= null;
             foreach (var p in _product)
             {
                 if (product.ProtactId == p.ProtactId)
                 {
                     productToDelete = p;
                 }
             }

            */

            //LİNQ -Language Integrated Query
            //Lambda

            //her p için p nin(o an dolaştığım ürünün) id si,
            //benim parametre ile gönderdiğim ürünün id sine eşitse
            //onun referansını productToDeleteye eştile.

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);

             

        }
        public List<Product> GetAll()
        {
            return _products;
        }


        public void Update(Product product)
        {
            //güncellenecek referansı bulmam lazım.
            //Gönderdiğim ürünid'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;


        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirirve onu döndürür.
            
          return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
