
Bu katman, diðer katmanlara alt yapý hizmeti sunacak olan serviceleri barýndýran katman.

Email, SMS, JWT ile token haberleþme alt yapýsý, bildirim serviceleri, Socket (signalR), chat ve real-time veri operasyonlarý için kullanýlýyor., cache iþlemleri gibi uygulamamýz için gerekli tüm altyapý servislerinin baðlantýlarýný bu katmanda yapacaðýz. 

Sockets -> socket iþlemlerini bu klasör altýnda yapýlacak (SignalR) ile
EmailOperation -> E-posta gönderme iþlemlerini bu klasörde yapýlacak
Notification -> mobil uygulama için bildirim gönderme iþlemleri bu klasörde yapýlacak.
SMSOperation -> Sms iþlemleri bu klasörde yapýlacak. 
Authentication (JWT) -> client ile server arasýndaki haberleþme altyapýsý bu klasörde tutulacaktýr.
Caching -> Redis ile cachelenmiþ yani belirli bþr süreliðine RAM'de tutulan bilgileri bu klasör altýndaki serviceleri kullanarak geliþtirilecek. 
Logging -> Loglama iþlemleri
Base Repository implementasyonlarý teknolojilere göre bu klasör altýndan yapýlacak. 

Bu uygulama altýnda yukarýdaki tüm oeprasyonlara ait interfaceler ve bu interfacelerden implemente olan sýnýflarýmýz, atlyapý servicelerimiz bulunacak. 