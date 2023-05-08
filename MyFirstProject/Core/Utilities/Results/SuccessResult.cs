using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //inheritanca 
    public class SuccessResult : Result
    {
        //constructor
        //successresult sadece mesaj alsın
        //base e true gönderiyoruz zaten başarılı ve message veriyoruz
        public SuccessResult(string message) : base(true,message)
        {

        }

        //base'in te parametreli olanını çalıştır
        //mesaj yok
        public SuccessResult() : base(true) 
        {

        }

    }
}
