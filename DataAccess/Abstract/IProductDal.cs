using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //product ile ilgili veritabannda yapacağım operasyonları içeren interface.
    // Operasyon: şunu ekle/sil/güncelle/listele gibi operasyonlar
    public interface IProductDal
    {
        List<Product> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //ürünleri kategoriye göre filtrele.
        List<Product> GetAllByCategory(int categoryId);
                }

    }
