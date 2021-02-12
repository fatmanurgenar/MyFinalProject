using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{   //standart kod --hemen bunu generic base haline getirmeli 
    //neden standart categori için bu classı yazarken sadece product olan yerlere category gelecek gerisi aynı 
    //NuGet 
    public class EfProductDal : IProductDal
    {

        public void Add(Product entity)
        {
            //IDispossable pattern implementation of c#
            using (NorthwindContext context =new NorthwindContext())
            {
                
                var addedEntity = context.Entry(entity);   //referansı yakalama
                addedEntity.State = EntityState.Added;     //eklenecek nesne 
                context.SaveChanges();                     //işlemleri gerçekleştir -ekle-

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var deletedEntity = context.Entry(entity);   //referansı yakalama
                deletedEntity.State = EntityState.Deleted;     //silinecek nesne 
                context.SaveChanges();                     //işlemleri gerçekleştir 

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var updatedEntity = context.Entry(entity);   //referansı yakalama
                updatedEntity.State = EntityState.Modified;     //güncellenecek nesne 
                context.SaveChanges();                     //işlemleri gerçekleştir 
            }
        }
    }
}
