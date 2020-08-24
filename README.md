# Parking-Lot-Detecter-with-Image-Processing
Kameradan alınan görüntülerin(canlı olarak) işlenilerek otopark alanındaki boş alanların tespit edilmesi. 

  Öncelikle Otopark üzerinde park alanları fare ile işaretlenir. Kamera üzerinde bu işaretli alanlara araba park edilmesi durumunda boş ve dolu park alanı sayıları 
güncellenerek kullanıcıya bildirilir.

![image](https://github.com/sinansa91/Parking-Lot-Detecter-with-Image-Processing/blob/master/Images/4.PNG)

![image](https://github.com/sinansa91/Parking-Lot-Detecter-with-Image-Processing/blob/master/Images/1.png)

Kullanılan Teknolojiler

1) Grayscale, yalnızca beyaz ve siyah renk tonlarının kullanılarak fotoğrafların ve görsellerin meydana getirilmesidir. 

2) Histogram, gruplandırılmış bir veri dağılımının sütun grafiğiyle gösterimidir. Diğer bir ifadeyle, tekrarlı sayılardan oluşan verilerin, uygulanan işlemlerden sonra önce tabloya, tablodan yararlanarak grafiğe aktarılması, yani veri gruplarının grafiğinin dikdörtgen sütunlar halinde gösterilmesidir.

3) Image Substraction veya Pixel Substraction, bir pikselin veya tüm görüntünün dijital sayısal değerinin başka bir görüntüden çıkarıldığı bir işlemdir. Bu, öncelikle iki nedenden  yapılır. Bir görüntünün üzerinde gölge olan yarım görüntünün düzensiz bölümlerinin tesviye edilmesi veya iki görüntü arasındaki değişikliklerin saptanması. Bu değişiklik tespiti, görüntüdeki bir şeyin hareket edip etmediğini anlamak için kullanılabilir.

4) Otsu Yöntemi, görüntüdeki piksel değerlerini kontrol ederek ikili renk tabanlı bir görüntü elde etmek için kullanılır.

5) Morfoloji (Boşluk Doldurma): Görüntüler üzerinde yapılan genişletme, aşındırma, sınır belirleme, iskelet ve dışbükey kabuk bulma gibi, temeli küme teorisine dayalı işlemlerdir.


![image](https://github.com/sinansa91/Parking-Lot-Detecter-with-Image-Processing/blob/master/Images/Boş.jpg)
![image](https://github.com/sinansa91/Parking-Lot-Detecter-with-Image-Processing/blob/master/Images/Dolu.jpg)

![image](https://github.com/sinansa91/Parking-Lot-Detecter-with-Image-Processing/blob/master/Images/3.PNG)
