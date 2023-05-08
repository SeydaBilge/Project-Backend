using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        //constructor'a 2 parametre yazılacak
        //getter'lar readonly'dir. Readonly'ler constructor da set edilebiir
        //sadece constructor da set edilsin diye sınırlıyoruz
        //iki farklı costructor var biri mesaj ve başarı imzası içeriyo diğeri sadece başarı durumu içeriyo
        //this -> kendisi demek 
        //this(success) ile result(bool success) fonksiyonuna success parametresi gönderdik ve onun da çalışmasını sağladk

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }
        public Result(bool success) //overloading
        {
          
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }

    }
}
