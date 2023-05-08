using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        //base'in te parametreli olanını çalıştır
        //mesaj yok
        public ErrorResult() : base(false)
        {

        }
    }
}
