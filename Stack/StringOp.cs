using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class StringOp
    {
        public string[] seperate(string exp)
        {
            return exp.Trim().Split(' '); //Trim() baştaki ve sondaki boşlukları kaldırmak için kullanılıyor.
        } 

        public bool isNumber(string item)
        {
            int result;
            return int.TryParse(item,out result); //TryParse metodu gelen bi string in sayı olup olmadığını kontrol ediyor. out değeri herzaman yazılmalı

        }

        public bool isOperator(string val)
        {
            if (val == "+" || val == "-" || val == "*" || val == "/")
                return true;
            else
                return false;
        }


    }
}
