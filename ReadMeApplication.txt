
Bu katman controllerdan gelen i� isteklerinin koordinasyonun, y�netimini yapan katman olup bu katmandaki application servisler ile uygulaman�n di�er katmanlar�ndaki servisler bu katman i�erisine birib�rieri ile haberle�ir. Yani bu katman�n g�revi gelen i� isteklerinin (Use-Case) kullan�m durumlar�na g�re arka planda ne t�r i�lemlerin �a��r�laca��n� koordine etmektir. 

 Controller -> GetCampanyProducts => arka plandaki t�m kampanyal� �r�nlerin d�zg�n bir logicte listelenmesi i�in gereken t�m servicelerin �a�r�lmas�n� bu katman sa�layacak.

 son 10 sipari�imi getir. GetTop10LatestOrderRequest 0> DTo yani data transfer objesi d�nd�recek. 
   {"name":"sipari� ad�", "date":"sipari� traihi"} gibi

   Bu katmanda gelen i� iste�ine g�re verinin yani input modelin do�ru formatta olup olmad��� validasyonu, do�ru formatta ise yap�lacak olan i�lemlerin �a�r�lmas� -servis �a�r�lar�- bu operasyonlar sonras� yap�lacak i�lemler, mail at, sms at, bildirim g�nder gibi operasyonlar�n y�netimi sa�lanacakt�r. 

   Services -> Gelen i� isteklerini, requestleri, yakalayan ve i�leyen servislerimiz
   DTO -> Frontend taraf�ndan gelen modeller veya frontend projesine g�nderdi�imiz modeller 
   Commands -> Uygulama i�erisinde gelen i� isteklerini temsil eden komut s�n�flar� (post request)
   Queries -> uygulama i�erisindeki nesneleri frontend taraf�nda g�ndermekten sorumlu istek s�n�flar� (get request)
   Exceptions -> uygulaman�n di�er katmanlara eri�meden �nceki hata-durum y�netimleri i�in bu klas�rdeki s�n�flar kullan�lacakt�r. Mesela UserNotAllowed, OrderRejected gibi exceptionslar.


   Bu katman controller'da yazd���m�z codelar� temsil eden katman. 

   Not: Bu katman�n kullan�lmas�ndaki en b�y�k sebep uygulaman�n teknolojisinin yani API teknolojisinin de�i�mesi durumunda kodlar�n yeni gelen teknolojiye aktar�lmas�n�n daha kolay olmas�. Yani API taraf�nda uygulama taraf�nda bir teknoloji de�i�iminde h�zl� bir ge�i�-migration sa�lanacakt�r. 

   ~ Farkkl� uygulamalar gerekti�inde bu katmandaki kodlar� kullanabilir gibi d���n ~

