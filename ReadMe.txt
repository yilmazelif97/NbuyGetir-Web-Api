
Domain Layer: uygulamadaki Entitylerin, domain serviceslerin, Eventlerin ve repository interfacelerinin bulundu�u katmand�r. Uygulaman�n en �nemli katman� olup, t�m di�er katmanlar bu katmandan beslenir. Bu katmandaki s�n�flar� kullanabilir. Bu katman "Core" katman� d���ndaki hi�bir katmana direkt ba�l� de�ildir. 

Logic i�lemlerini Domain Serviceler �stlenecektir.

Kurallar:
Ayn� anda bir sipari� i�erisinde ayn� �r�nden 10 adetten fazla sipari� edilemez
Belirli bir adet �zerinde tek seferde sipari� edilemesin.
Gece 12den sonraki sipari�ler i�in sipari� s�raya al�ns�n, bir sonraki g�n g�nderim yap�ls�n.
Kampanya tarigi son 12 saat kala kampanya sonlanmas� ile alakal� m��terilere mail g�nderilisn. 
Stocktaki �r�n adedi critic �r�n e�i�ine (10 adet) d��t��� anda ilgili �r�nlerin sat��� durdurulsun. 
Sipari�i olu�tururken stok yeterli mi de�il mi kontrol� yapan bir servis tan�mlayaca��z. 

Mesela bu �r�nler stok kalmay�nca event f�rlatman gerekiyor gibi. 