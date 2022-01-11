using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Entities
{

    //abstract olmasının sebebi bundan instance alınmayacak  
    public abstract class AuditableEntity : Entity, IAudiTableEntity
    {
        public string CreatedBy { get; set ; }
        public string UpdatedBy { get; set;  }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
