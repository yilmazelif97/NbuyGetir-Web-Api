using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Entities
{

    /// <summary>
    /// denetlenebilir entity --> kimin tarafından updated, created işlemlerinin yapıldığı bilgisini tutacağız. 
    /// </summary>
    public interface IAudiTableEntity
    {


        //bu entity ürün gibi önemli bir nesne ise bu alanlar kesinlikle tutulur. 

        //entity kim tarafından oluşturuldu ve güncellendi bilgileri burda tutuluyor. 
         string CreatedBy { get; set; }
         string UpdatedBy { get; set; }

        /// <summary>
        /// entity ilk hangi tarihte eklendi 
        /// </summary>
         DateTime CreatedDate { get; set; }

        /// <summary>
        /// entity hangi tarihte güncellendi 
        /// </summary>
         DateTime? UpdatedDate { get; set; }



    }
}
