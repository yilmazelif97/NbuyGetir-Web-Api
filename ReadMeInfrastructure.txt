
Bu katman, di�er katmanlara alt yap� hizmeti sunacak olan serviceleri bar�nd�ran katman.

Email, SMS, JWT ile token haberle�me alt yap�s�, bildirim serviceleri, Socket (signalR), chat ve real-time veri operasyonlar� i�in kullan�l�yor., cache i�lemleri gibi uygulamam�z i�in gerekli t�m altyap� servislerinin ba�lant�lar�n� bu katmanda yapaca��z. 

Sockets -> socket i�lemlerini bu klas�r alt�nda yap�lacak (SignalR) ile
EmailOperation -> E-posta g�nderme i�lemlerini bu klas�rde yap�lacak
Notification -> mobil uygulama i�in bildirim g�nderme i�lemleri bu klas�rde yap�lacak.
SMSOperation -> Sms i�lemleri bu klas�rde yap�lacak. 
Authentication (JWT) -> client ile server aras�ndaki haberle�me altyap�s� bu klas�rde tutulacakt�r.
Caching -> Redis ile cachelenmi� yani belirli b�r s�reli�ine RAM'de tutulan bilgileri bu klas�r alt�ndaki serviceleri kullanarak geli�tirilecek. 
Logging -> Loglama i�lemleri
Base Repository implementasyonlar� teknolojilere g�re bu klas�r alt�ndan yap�lacak. 

Bu uygulama alt�nda yukar�daki t�m oeprasyonlara ait interfaceler ve bu interfacelerden implemente olan s�n�flar�m�z, atlyap� servicelerimiz bulunacak. 