using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Sessions
{

    /// <summary>
    /// Kullanıcıya ait sepet bilgileri, sipariş işlemleri sırasında session da saklanacak. Bunun gibi oturum bazlı veri saklama durumlarımız için bu servisi kullanacağız. 
    /// </summary>
    public interface ISessionService<Tobject> where Tobject:class
    {

        void Add(Tobject @objects, string key); // key value cinsinden ramde oturum bilgisini object olarak tutmak için kullanacağız. 

        void Remove(string key); // ilgili sesion bilgisini RAM'den kaldırmak için kullanacağız.

        /// <summary>
        /// RAM'de oturum bazlı saklanan değer 
        /// </summary>
        Tobject GetSession (string key);
    }
}
