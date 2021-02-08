using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //çıplak class kalmasın - bir class herhangi bir inheritance ve interface implementasyonu
    //almıyorsa anla ki ilerde problem yaşayacaksın!!
    //bu varlıklarımızı işaretleme(gruplama) eğilimine gideriz 
    //gruplama--derizki concrete klasöründeki sınıflar bir veritabanı tablosuna karşılık geliyor.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
