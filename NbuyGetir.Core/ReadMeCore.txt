

Bu katman diğer tüm katmanları besleyen abstract class, base class, interfaces gibi ana şablonların uygulandığı bir katman olup tüm katmanlar bu katmandan faydalanabilir. Uygulamanın ilk geliştirmelerini bu katman üzerinden yapıp diğer katmanlara ait implementasyonlar yapılacaktır. 

Bu katman diğer katmanlardan farklı olarak cross-cutting katman olaran isimlendirilir. Diğer katmanlar uygulamanın belirli bir kısmına ait kendileri ile alakalı sorumlulukları(seperation of concerns (katmanların ilgilerine göre ayrımları)) yerine getirirken bu katmanda herhangi bir sorumluluk prensibi bulunmamaktadır. Sadece ilgili katmanlara ait base implementasyonlara yer verilir. 

BaseEntity, IEntity, IRepository, IDomainEvent, IDomainService, IApplicationService, IEmailSErvice, ISmsSender, INotification, ITokenSErvice vs. gibi tüm implementasyonların base'i burada bulunacaktır. 


Not  --> Uygulamanın ilk iş isteği UI dediğimiz frontend katmanı ile başlar (html,css,js, UI Elements ) olup kullanıcının uygulama ile tasarımsal olarak etkileşime geçtiği katman. Bu katman frontend developerların katmanı(Mobile App, Web App) olabilir. 

UI(Jquery, ReactJS, Angular, Vue,Spa uygulamaları bulunablir ) katmanından sonra Presentation katmanına gelinir (MVC, WEB API, DESKTOP) (Backend katmanı) -> Application (gelen isteklerin yönlendirildiği, ilgili servislere aktarıldığı katman) --> Infrastructure veya Domain veya Persistance katmanına bağlar. Application katmanı diğer 3 alt katmanın birbirleri ile iletişimde bulunmasını sağlar. 