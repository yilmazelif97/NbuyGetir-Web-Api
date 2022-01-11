using NbuyGetir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        /// <summary>
        /// Ekranda ilk açılışta en üst seviye olan kategorileri listeleyeceğiz. Bu üst seviye altına eklenen alt kategorileri ise ürünler ile bağlayacağız. Ürünler bu kategorinin altında olacak, ürünler istoplevel altında işaretlenmemiş kategoriler altına eklenecekler 
        /// </summary>
        public bool isTopLevel { get; private set; } //en üst seviye kategori mi kontrolü burdan yapılıyor 

        private List<Product> _products = new List<Product>();
        public IReadOnlyList<Product> PRoducts => _products;


        private List<Category> _Subcategories = new List<Category>();
        public IReadOnlyList<Category> SubCategories => _Subcategories;

        public Category(string name, bool istoplevel)
        {
            SetName(name);
            isTopLevel = istoplevel ;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("KAtegori ismi boş geçilemez");
            }
        }


        public void AddSubCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                throw new Exception("Kategori ismi boş geçilemez");
            }


            //Dışarıdan üst seviye olan kategori başka kategorinin alt kategorisi olamaz 
            if (category.isTopLevel)
            {
                throw new Exception("Top kategoriye başka bir top kategori eklenemez");
            }

            _Subcategories.Add(category);


        }

        public void AddProduct(Product product)
        {

            //En üst seviye bir kategori değilse ve aynı zamanda kendi altında bi kategori yoksa en alt kategoridir.
            
            if (!isTopLevel && _Subcategories.Count() ==0 )  //en alt kategori demek
            {
                _products.Add(product);
            }
            {

            }
        }

    }
}
