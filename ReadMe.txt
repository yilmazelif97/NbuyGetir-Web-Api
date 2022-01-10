
Domain Layer: uygulamadaki Entitylerin, domain serviceslerin, Eventlerin ve repository interfacelerinin bulunduðu katmandýr. Uygulamanýn en önemli katmaný olup, tüm diðer katmanlar bu katmandan beslenir. Bu katmandaki sýnýflarý kullanabilir. Bu katman "Core" katmaný dýþýndaki hiçbir katmana direkt baðlý deðildir. 

Logic iþlemlerini Domain Serviceler üstlenecektir.

Kurallar:
Ayný anda bir sipariþ içerisinde ayný üründen 10 adetten fazla sipariþ edilemez
Belirli bir adet üzerinde tek seferde sipariþ edilemesin.
Gece 12den sonraki sipariþler için sipariþ sýraya alýnsýn, bir sonraki gün gönderim yapýlsýn.
Kampanya tarigi son 12 saat kala kampanya sonlanmasý ile alakalý müþterilere mail gönderilisn. 
Stocktaki ürün adedi critic ürün eþiðine (10 adet) düþtüðü anda ilgili ürünlerin satýþý durdurulsun. 
Sipariþi oluþtururken stok yeterli mi deðil mi kontrolü yapan bir servis tanýmlayacaðýz. 

Mesela bu ürünler stok kalmayýnca event fýrlatman gerekiyor gibi. 