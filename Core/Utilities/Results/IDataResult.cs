using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //hangi tipi döndüreceğini bana söyle --> <T>
    public interface IDataResult<T>:IResult
    {
        //IReesulttaki mesajlar dışında birde T türünde datamız olacak bu classta 
        T Data { get; }
    }
}
