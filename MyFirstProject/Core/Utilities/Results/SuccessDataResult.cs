﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //işlem sonucu default true olacak
    public class SuccessDataResult<T>:DataResult<T>
    {
        
        private bool v;
        private object productsListed;
      

        public SuccessDataResult(T data, string message):base(data,true,message) 
        {

        }

        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }
        //default dataya karşılık gelir
        //
        public SuccessDataResult():base(default,true)
        {
            
        }

       
    }
}
