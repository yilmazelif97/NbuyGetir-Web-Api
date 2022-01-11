using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Caching
{

    public class CacheData<T>
    {

        //gelen veriye göre kategori ya da product gibi key buna göre şekllenecek.

        public string Key { get; set; }  //cachelenecek veri için bir key değeri tutuyoruz. bu key değeri üzerinden bu data bilgimize ulaşacağız. 

        public List<T> Data { get; set; } //Liste halinde json dizisi olarak buraya data set edeceğiz. 
    }

    /// <summary>
    /// GEtir uygulamasındaki kategorileri ve bu karegorilere ait alt kategori bilgisini cacheden yani RAM üzerinden okuacaağz. Böylece her segerinde DBden çekmediğimiz için daha hızlı sonuç döndüreceğiz. Bu giti çok fazla CRUD operasyonun yapılmadığı sınıfımızı RAMden okuyabiliriz. Aynı zamnda sepet gibi işlemler içinde tanımlanabilir. 
    /// Çok fazla insert,update işlemi olmayan verilerimiz için cache mekanizmasını kullanırız.
    /// </summary>
    public interface ICacheService<TObject> where TObject:class
    {

        /// <summary>
        /// veriyi RAM'de tutarken key bilgisi üzerinden sistemde tutmamıza yarar. 
        /// </summary>
        /// <param name="cacheData"></param>
        void SetCache( string key, TObject cacheData );

        /// <summary>
        /// json string deseralize edip key e göre cache storedan okuma yapılacak 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>

        TObject GetFromCache(string key);  //ilgili ramde cachedeki dataya set ederken verdiğimiz key üzerinden erişim json formatında deserizalize edilmiş veriye ulaşacağız. 

    }
}

//dbye kayıt yok RAM üzerinden bu  işlemler yapılacak 
