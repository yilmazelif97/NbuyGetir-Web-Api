using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Exceptions
{
    //hata yönetimi class üzerinden olacak 
    public static class ExceptionCodes
    {
        public const string UserNotFound = "1001";

        public const string OrderRejected = "2001";

        public const string AccountDEnied = "3001";
    }

    //instance yok sadece kalıtım olcak bu sınıfta
    //
    /// <summary>
    /// Uygulama içerisinde logic kaynaklı hataları fırlatmak için bu sınıf kullanılacak. 
    /// Uygulama içerisinde oluşacak hatalara ExceptionCode olarak birer kod verildi.
    /// Hata mesajı ile hangi kodun olınacağına dair bilgileri bu sınıftan kalıtım aalan sınıflara verilecek.
    /// Böylelikle uygulamada oluşan hataları daha kolay loglayabileceğiz. 
    /// Exception sınıı ana hata sınıfı olup kendi uygulama hata sınıflarımızda oluşturacağız 
    /// </summary>
    public abstract class ExceptionBase : Exception
    {

        public string ErrorCode { get; private set; }


        /// <summary>
        /// Bir hata durumunda hata ile ilgili bir class açıp mesaj ve errorCode bilgisini constructır ile belirtiliyor. 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>

        public ExceptionBase(string message,string errorCode):base(message)
        {
            ErrorCode = errorCode;
        }


    }
}

//instance alımasını engellemiş olduks adece gerekli olan throw new exception hangisiyle uyuşuyorsa ondan isntance alınacak 
