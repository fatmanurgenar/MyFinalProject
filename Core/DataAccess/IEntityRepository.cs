using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //T: Türü--> product,category
    // public interface IEntityRepository <T>--> T'yi sınırlandırmak istiyorum.-->
    //-> ne ile sınırlandırmak istiyorum? -->veri tabanı nesnelerimle..
    //public interface IEntityRepository <T> where T:class ile sınırlandırdım
    //buna generic constraint -->generic kısıt 
    //class: referans tip olabilir demek 
    //IEntity: T sadece IEntity olabilir veya IEntity implemente olan bir nesne olabilİr  
    //new(): new'lenebilir olmalı -->IEntity newlenemeyeceği için bundan da kurtulmuş olduk.
    public interface IEntityRepository <T> where T:class,IEntity,new()
    { 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
