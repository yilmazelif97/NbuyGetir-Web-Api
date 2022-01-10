
Bu katman controllerdan gelen iþ isteklerinin koordinasyonun, yönetimini yapan katman olup bu katmandaki application servisler ile uygulamanýn diðer katmanlarýndaki servisler bu katman içerisine biribþrieri ile haberleþir. Yani bu katmanýn görevi gelen iþ isteklerinin (Use-Case) kullaným durumlarýna göre arka planda ne tür iþlemlerin çaðýrýlacaðýný koordine etmektir. 

 Controller -> GetCampanyProducts => arka plandaki tüm kampanyalý ürünlerin düzgün bir logicte listelenmesi için gereken tüm servicelerin çaðrýlmasýný bu katman saðlayacak.

 son 10 sipariþimi getir. GetTop10LatestOrderRequest 0> DTo yani data transfer objesi döndürecek. 
   {"name":"sipariþ adý", "date":"sipariþ traihi"} gibi

   Bu katmanda gelen iþ isteðine göre verinin yani input modelin doðru formatta olup olmadýðý validasyonu, doðru formatta ise yapýlacak olan iþlemlerin çaðrýlmasý -servis çaðrýlarý- bu operasyonlar sonrasý yapýlacak iþlemler, mail at, sms at, bildirim gönder gibi operasyonlarýn yönetimi saðlanacaktýr. 

   Services -> Gelen iþ isteklerini, requestleri, yakalayan ve iþleyen servislerimiz
   DTO -> Frontend tarafýndan gelen modeller veya frontend projesine gönderdiðimiz modeller 
   Commands -> Uygulama içerisinde gelen iþ isteklerini temsil eden komut sýnýflarý (post request)
   Queries -> uygulama içerisindeki nesneleri frontend tarafýnda göndermekten sorumlu istek sýnýflarý (get request)
   Exceptions -> uygulamanýn diðer katmanlara eriþmeden önceki hata-durum yönetimleri için bu klasördeki sýnýflar kullanýlacaktýr. Mesela UserNotAllowed, OrderRejected gibi exceptionslar.


   Bu katman controller'da yazdýðýmýz codelarý temsil eden katman. 

   Not: Bu katmanýn kullanýlmasýndaki en büyük sebep uygulamanýn teknolojisinin yani API teknolojisinin deðiþmesi durumunda kodlarýn yeni gelen teknolojiye aktarýlmasýnýn daha kolay olmasý. Yani API tarafýnda uygulama tarafýnda bir teknoloji deðiþiminde hýzlý bir geçiþ-migration saðlanacaktýr. 

   ~ Farkklý uygulamalar gerektiðinde bu katmandaki kodlarý kullanabilir gibi düþün ~

