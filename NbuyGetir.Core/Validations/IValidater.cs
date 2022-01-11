using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Validations
{

    public class ValidationErrorResult
    {
        public string Key { get; set; }  //hangi propertyde alanda hata olduğunun bilgisi için 
        public string ValidationMessage { get; set; }  //hata mesajı için 

    }

    /// <summary>
    /// işlemin valid olup olmadığı, eğer değilse valid olmayanların listesi 

    /// </summary>
    public class ValidationResult
    {
        public bool isValid { get; private set; } = true;

        /// <summary>
        /// nesne içerisinde birden fazla hata olma ihtimaline göre eklendi 
        /// </summary>
        public List<ValidationErrorResult> Errors { get; set; }

        void AddError(ValidationErrorResult error)
        {
            isValid = false;  //tek bir hata bile varsa bu nesne valid olamaz, doğrulanamaz 

            Errors.Add(error);
        }
    }

 
    public interface IValidater<TDto> where TDto:class
    {

        /// <summary>
        /// Validate işlemi sonrası nesnenin valid olup olmaduğı  varsa hata mesajlarını yakalamk için yapıldı 
        /// </summary>
        ValidationResult ValidationResult { get; set; }


        /// <summary>
        /// dto yapıları frontend tarafından gelen bilgiler oluyor. Burda frontend tarafından gönderilen dto onun validasyon kurallarına uyup uymadığı kontrol edilecek. 
        /// </summary>
        /// <param name="dto"></param>
        void Validate(TDto dto);

    }
}

//bir oerasyonu servis yapıyorsa result döndürür. bir class bunu yapıyorsa class kendi içerisinde result döndürür. 
