using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //product ile ilgili veritabannda yapacağım operasyonları içeren interface.
    // Operasyon: şunu ekle/sil/güncelle/listele gibi operasyonlar
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }

    }

    //code refactoring