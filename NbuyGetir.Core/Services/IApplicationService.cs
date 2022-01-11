using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Services
{

    /// <summary>
    /// TRequestDTo -> input model
    /// TResultDto -> view model 
    /// 
    /// Frontend tarafından gelen bir isteğin işlenip frontend tarafına bir sonucun döndürülmesi için oluşturuldu. API de input Model ya da view Model yerine DTO (Data transfer object) terimi kullanılacaktır. 
    /// Buradaki servis Application katmanı için yazıldı 
    /// gelen tüm istekler bu servisten geçmek zorunda bir tane request alıp bir tane result döndürecek 
    /// 
    /// </summary>
    /// <typeparam name="TRequestDto"></typeparam>
    /// <typeparam name="TResultDto"></typeparam>
    public interface IApplicationService<TRequestDto,TResultDto>
    {

        Task<TRequestDto> HandleAsync(TRequestDto dto);
    }
}
