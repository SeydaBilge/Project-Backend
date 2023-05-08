using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //işlem sonucu ve mesaj IResult üzerinden alınacak. Burada sadece datayı alıyoruz. Kendmizi tekrar etmemek için
    //Bu sebeple sen bir IResult'sın diyoruz
    //hangi tipi döndüreceğini bana söyle<T>
    public interface IDataResult<T>:IResult
    { 
        //interface interface implemente etti
        T Data { get; }
        //ürünler vs 


    }
}
