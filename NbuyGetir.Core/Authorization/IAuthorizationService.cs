using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authorization
{

    /// <summary>
    /// Bu servis ile sistemdeki kullanıcının ilgili kaynağa erişim yetkinin olup olmadığı kontrol edilir. 
    /// Claim ve Role bazlı kontrolleri içerisinde yapılacaktır. 
    /// </summary>
    public interface IAuthorizationService
    {

        /// <summary>
        /// Sistemde oturum açan kullanıcının sistemdeki özel kaynaklara yetkisi var mı kontrolü yapılacaktır. Örneğin; kargo sorumlusu sadece kargodaki ürünü görebilecek gibi.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>

        bool HasRole(string roleName);
        bool HasRoles(params string[] roleNames);
        bool HasClaim(string claim);
        bool HasClaims(params string[] claims); //claims bilgisi kullanıcıya tanımlanmış olan özellikler. örneğin NbuyGetir çalışanı mı, indirim çeki tanımlamış mı gibi kullanıcıya tanımlanan extra özelliklere claim denecek. 


    }
}
