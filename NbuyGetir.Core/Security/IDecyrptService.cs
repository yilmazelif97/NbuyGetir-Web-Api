using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Security
{
    public interface IDecyrptService
    {

        /// <summary>
        /// byte[] dizisi olarak şifrekenmiş datayı string olarak şifresi çözülmüş bir şekilde geri döndürebiliriz 
        /// </summary>
        /// <param name="chiper"></param>
        /// <returns></returns>
        byte[] Decrypt(byte[] chiper);

    }
}
