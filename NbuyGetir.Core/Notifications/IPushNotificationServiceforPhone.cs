using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Notifications
{
    public interface IPushNotificationServiceforPhone
    {
        /// <summary>
        /// Sistem mobil uygulamayı bir kullanıcı indirince user hesabında deviceID sini tutacağız. One Signal ile kişinin cihazına bildirim gönderilecektir. 
        /// appID -> mobil uygulamayı indiren kullanıcıya one signal tarafından verilen ID. Bu ID değerini user tablosunda tutacağız ve bildirim gönderirken bu ID değerine göre bildirim göndereceğiz
        /// </summary>
        /// <param name="appID"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendPushNotificationAsync(string appID, string message);


    }
}
