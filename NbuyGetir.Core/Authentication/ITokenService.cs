using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authentication
{

    public class TokenClaim
    {
        public string ClaimType { get; set; }  //username, role
        public string ClaimValue { get; set; } //berkay, admin 

    }

    public class TokenModel
    {
        public string AccessToken { get; set; }  //Base64 formatındaki token bilgisi 
        public DateTime ExpireDate { get; set; } // tokenın ne zaman expire olacağı bilgisi --> tokenın kullanılamacayğı süre yani 

    }

    /// <summary>
    /// Belirli bir süreliğine Access Token üretmen için bu servisi kullanacağız. 
    /// Tokenda taşınacak bilgiler için TokenClaim adında bir sınıf kullanılacak. Key value olarak tokenda bilgiyi saklayacağız. 
    /// TokenModel ise kullanıcının Access Token ve bu token geçerlilik süresi için açtığımız model 
    /// </summary>
    public interface ITokenService
    {

        /// <summary>
        /// Sisteme giriş yapacak kullanıcılar için Erişim Bileti --> Access Token oluşturulacak
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>

        TokenModel CreateAccessToken(List<TokenClaim> claims);

        void RevokeAccessToken(string token);  // Kullanıcıya ait Access Token bilgisinin artık kullanılmaması için çalıştıracağımız method. Bu token bilgisi kullanıcıdan geri alınacaktır. eski tokenla sisteme gelip gelmediğinin kotnrolü. Login olduğunda bu tokenın(eski) bir daha aynı kullanıcı tarafından kullanılmaması için var 

    }
}
