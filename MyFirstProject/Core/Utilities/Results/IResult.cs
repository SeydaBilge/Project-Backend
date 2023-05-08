using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    //işlem sonucu ve kullanıcıyı bilgilendirme için mesaj

    public interface IResult
    {
        //get - sadece okuma yapıyoruz
        //Success - işlem başarılı mı başarısız mı
        //Message - kulllanıcıyı bilgilendirme mesajı
        bool Success { get; }
        string Message { get; }
    }
}
