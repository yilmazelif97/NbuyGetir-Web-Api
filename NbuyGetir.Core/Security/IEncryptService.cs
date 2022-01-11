using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Security
{
    public interface IEncryptService
    {

        /// <summary>
        /// MD5 ile ya da SHA, DES, 3DE gibi algoritmalar ile şifreleme işlemleri yapan bir servis olarak kullanılacaktır. 
        /// MD5 hash algortimasının geri dönüşü yok 
        /// </summary>
        /// <param name="plainTExt"></param>
        /// <returns></returns>

        string Encrypt(string plainTExt);


    }
}
