using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authentication
{
    public class AuthenticationError
    {
        public string Code { get; set; }  //202not found gibi hata kodları 
        public string Message { get; set; }  // Böyle bir kullanıcı sistemde bulunamadı 
        public string Key { get; set; } //login işleminde alınan hataların hangi alanda alındığı burdan alıncak mesela username yanlış gibi
    }

    public class AuthenticationResult
    {

        public bool isSucceeded { get; private set; } = true;
        public string AccessToken { get; private set; }
        public List<AuthenticationError> Errors {get;private set;}

        void AddError(AuthenticationError error)
        {
            isSucceeded = false;
            Errors.Add(error);

        }

        public void SetAccessToken(string token)
        {
            AccessToken = token;

        }

    }

    //login olan kullanıcılar gelcek 
    public interface IAuthenticationService
    {
        /// <summary>
        /// login olduktan sonra remember me true olursa bu token 1 aylık bir token olsun. Diğer türlü 1 günlük token oluşturulacak. 
        /// JWT --> json web token oluşturulacak
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="rememberme"></param>
        /// <returns></returns>
        AuthenticationResult Login(string email, string password, bool rememberme);

        void Logout(string AccessToken); // kullanıcıya giriş işlemleri için verilen accessToken expire edilecek. Artık bu token geçersiz olacak. Kullanıcının sistemden güvenli çıkışı için var. 


    }
}
