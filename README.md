# PatikaBackendWeek7

1-Linq
-------------------
Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

Çift olan sayılar

Tek olan sayılar

Negatif sayılar

Pozitif Sayılar

15'ten büyük ve 22'den küçük sayılar

Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)

2-Patikafy
-------------------
![image](https://github.com/user-attachments/assets/76ca947a-299c-4d6b-a54a-4da413d85834)

Yukarıda 11 sanatçımız için bir veri tablosu verilmiştir. Tablodaki her bir satır bir nesneye karşılık gelecek şekilde bu nesnelerden oluşan bir liste tanımlayınız. Ardından bu liste üzerinden aşığıdaki sorguları gerçekleştiriniz.

Adı 'S' ile başlayan şarkıcılar

Albüm satışları 10 milyon'un üzerinde olan şarkıcılar

2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

En çok albüm satan şarkıcı

En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı

3-Patikaflix
-------------------
Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor. Elemanların oluşturuluşu Console ekranı üzerinden olacak.

Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.

Ardından aşağıda istenilen işlemleri gerçekleştiriniz.

-İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)

-Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.

Örnek Çıktı

![image](https://github.com/user-attachments/assets/774e4241-3842-4b40-b78c-9194ece59d0d)

4- LINQ Join
-------------------
Bir kütüphane yönetim sistemi oluşturun. Bu sistemde iki adet tablo bulunmaktadır: Yazarlar ve Kitaplar. 
Aşağıda her iki tablonun yapısı verilmiştir:

-Yazarlar Tablosu (Authors)

AuthorId (int) - Yazarın benzersiz kimliği

Name (string) - Yazarın adı

-Kitaplar Tablosu (Books)

BookId (int) - Kitabın benzersiz kimliği

Title (string) - Kitabın başlığı

AuthorId (int) - Kitabın yazarının kimliği (Yazarlar tablosundaki AuthorId ile ilişkilidir)

Görev:

1-Tabloları Tanımlayın:

Author ve Book adında iki sınıf oluşturun ve yukarıdaki tablo yapılarını bu sınıflara uygun şekilde tanımlayın.

2-Verileri Ekleyin:

Her iki tabloya da örnek veriler ekleyin. En az 3 yazar ve 4 kitap ekleyin.

3-LINQ Sorgusu Yazın:

Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.

4-Sonuçları Yazdırın:

Oluşturduğunuz LINQ sorgusunun sonucunu ekrana yazdırın. Her kitabın başlığı ve yazarının adını içeren bilgileri göstermelisiniz.
