using NbuyGetir.Common.Uri;
using NbuyGetir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NbuyGetir.Domain.Models
{
    public class Product : AuditableEntity
    {
        public string Name { get;private set; }
        public decimal UnitPrice { get;private set; } //alış fiyatı 
        public decimal ListPrice { get; private set; } //satış fiyatı 
        public decimal DiscountedListPrice { get; private set; } //bu alan sadece programda tarafında tutulacak. DB ye kayıt yok 
        public int Stock { get; set; }  //current stock 
        public string Description { get; set; }  //x lt ya da 2 kg gibi ürün açıklaması
        public string PictureBase64 { get; private set; }
        public string PictureUrl { get; set; }
        public bool iscriticalstockproduct {  //stock kritik seviyede diye işaretlemek için. 
            get {
                return Stock < 10 ? true : false;
         }   } 

        /// <summary>
        /// urunun indirimli olup olmadığı db de skalanmayacak. zaten elimizde bilgiere göre bu property tarafından indirimli ürün olup olmadığını buluyoruz. ürün indirimli mi 
        /// </summary>
        public bool isDiscounted { get 
            {
                return DiscountedListPrice < ListPrice ? true : false;
            }  
        }

        public Product(string name, decimal unitprica, decimal listPrice,  int _stock, string descipriton, string pictureURL, decimal discountedListPrice)
        {
            SetName(name);
            setPrice(UnitPrice,listPrice,discountedListPrice);
            SetDescription(descipriton);
            SetStock(_stock);

        }

        //aşağıdaki fonksiyonları çağırarak birim birim güncelleme yapılabilir. mesela sadece ürünün ismini değiştirmek istediğinde SetName() fonksiyonunu çağırırsın 

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Ürün ismi boş geçilemez");
            }

            Name = name.Trim();
        }

        /// <summary>
        /// ilk kayıt işleminde sadece stok değeri formdan alınırken kullanılacağı için private yapıldı. Diğer tüm stok işlemlerinde stockin ve stockout operasyonları kullanılacak
        /// </summary>
        /// <param name="stock"></param>
        private void SetStock(int stock)
        {
            if (stock < 0)
            {
                throw new Exception("şu an bir ürün eklenmiyor. 0dan büyük bir değer giriniz");
            }

            if (stock<10)
            {
                //kritik seviyede ürün olarak işaretleyelim 
            }

            Stock = stock;

        }

        public void STockIn(int quality)
        {
            if (quality>0)
            {
                throw new Exception("stoığa girilecek yeni ürün adeti 0 ve daha düşük olamaz");
            }

            Stock += quality;
        }

        public void STtockout ( int quantity)
        {

            if (quantity<0)
            {
                throw new Exception("0dan küçük değer stoktan düşemez");
            }
            if (iscriticalstockproduct)
            {
                //Kritik stok seviyesindeki bir ürün sipariş edildi diye bir mesaj atalım. 
            }

            if (quantity>Stock)
            {
                //hatalı kayıt gönderme işlemi  yani 3 tane ürünün varken 5 tane veremezsin gibi o yüzden bu kontrol yapılıyor 

                throw new Exception("olandan daha fazla ürünü stok out yapamazsınız");

            }

            Stock -= quantity;
        }

        
        public void SetPictureUrl(string pictureUrl)
        {
           
            if (!UrlHelper.IsUrl(pictureUrl))
            {
                throw new Exception("resim yolu url formatında değil");
            }

            if (string.IsNullOrEmpty(pictureUrl))
            {
                pictureUrl = "default-product.jpg";
            }

            else
            {
                PictureUrl = pictureUrl.Trim();
            }

        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new Exception("Ürünün açıklaması boş bırakılamaz");
            }
            if (description.Length > 50)
            {
                throw new Exception("ürün açıklaması 50 karakterden fazla girilemez");
            }

            Description = description;
        }


        /// <summary>
        /// ürüne ait fiyatların değişimini bu metod ile yapılacak 
        /// </summary>
        /// <param name="unitprice"></param>
        /// <param name="listprice"></param>
        /// <param name="disocuntedlistprice"></param>

        public void setPrice (decimal unitprice, decimal listprice, decimal disocuntedlistprice )
        {
            if (unitprice>listprice)
            {
                throw new Exception("Birim fiyatı liste fiyatından büyyük olamaz");
            }

            if (unitprice<=0 || listprice<=0 ||disocuntedlistprice<=0)
            {
                throw new Exception("ürün fiyatı ya da birim fiyatı ya da indirimli satış fiyatı negatif ya da sıfır değelerleri girilemez");
            }

            if (disocuntedlistprice > listprice)
            {
                throw new Exception("indirimli satış fiyatı, satış fiyatından büyük olamaz");
            }

            if (disocuntedlistprice<unitprice)
            {
                throw new Exception("sindirimli satış fiyatı birim fiyattan küçük olamaz");
            }

            ListPrice = listprice;
            UnitPrice = unitprice;
            DiscountedListPrice = disocuntedlistprice;
            
        }

        /// <summary>
        /// Bu metod ile ürünün astış fiyatına belirli bir oranda indirim yapılır. İndirim oranı güncellenir ve sadece program tarafında discountedlistprice tutulacak bu indirimli fiyat olacaktır. 11 unitprice, 13 listprice, 12.5 disocuntedlistprice 
        /// </summary>
        /// <param name="discountamount"></param>
        public void DecreasePrice(decimal newprice)  //ürünün satış fiyatına indirim yap 
        {

            if (newprice > ListPrice)
            {
                throw new Exception("Yeni fiyat eski fiyattan küçük olamaz ");
            }
           
            if (newprice<=UnitPrice)
            {
                throw new Exception("indirimli fiyat birim fiyatından küçük olamaz");
            }

            DiscountedListPrice = newprice;


        }

        /// <summary>
        /// ürünün liste fiyatı güncellenme durumu için bu fonksiyon yazıldı, satış fiyatına zam 
        /// </summary>
        /// <param name="newlistprice"></param>
        /// <param name="newdiscountednewlistprice"></param>
        public void IncreasePrice(decimal newlistprice, decimal newdiscountednewlistprice)
        {
            if (newlistprice < ListPrice  ) 
            {
                throw new Exception("ürünün liste fiyatı yeni fiyattan büyük olamaz");
            }
            if (newdiscountednewlistprice > newlistprice)
            {
                throw new Exception("indirimli fiyat yeni liste fiyatından büyük olamaz ");
            }

            ListPrice = newlistprice;

            DiscountedListPrice = newdiscountednewlistprice;

            //zamlı ürünleri event olarak fırlat sonra

        }

        
    }
}
