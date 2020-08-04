# Aselsan_Boynuz
Aselsan 4822/4826 serisi telsizlerin kontrol kafasinin renkli LCD ile degistirilmesi projesidir.
Proje kapsaminda su calismalar yurutulecektir;
- Mevcut aselsan  protokolu ile ayni protokolu (I2C) kullanacaktir, boylece hem TAMSAT Kit olan cihazlarda hem de olmayan cihazlarda calisabilecektir
- Uzeirnde renkli LCD ile hazirlanmis bir gorsel arayuz bulunacaktir
- Tus takimi olacaktir, kontrol tuslari tercihan ekranin sagina soluna (bankamatik kullanimi gibi) yerlestirilecektir
- Hizli frekans ilerlemesi icin yukar/asagi tusu yerine rotartu encoder koyulacaktir
- Dis kutu eskisi ile ayni videlama noktalarina sahip yeni tasarim bir 3d printer da bastirilabilir kutu ile degistirilecektir
- Is aydinlatmasi mevcut ASELSAN dan daha yuksek olacaktir
- Eger Bluetooth modulu takilirsa cep telefonuna koyulacak bir yazilimla yonetilmesi saglanabilir...
-
-
<B>NOT</BR>
Projede 3D cizim yapabileceklerin destegine ihtiyacimiz olacaktir


# Yapılacaklar Listesi
- [x]  Font Decoding Algoritmasının Yazılması
- [ ]  Harici MCU üzerine Rotary Encoder Bağlanarak Channel Up/Down Simülasyonu Yapılması
- [ ]  Tüm Karakterlerin Segment Kodlarının Oluşturulması
- [ ]  Özel Ekran Sembolleri için Special Character Generate İşleminin Yapılması
- [ ]  Harici MCU üzerine 1 Adet Led Bağlanarak Arka Aydınlatma Simülasyonu Yapılması
- [ ]  Harici MCU üzerine 3 Adet Led Bağlanarak Pwr , RX , TX Led Simülasyonu Yapılması
- [ ]  Boynuz Kasa Tasarımı için Taslak Hazırlanması
- [ ]  Harici MCU üzerine Tuş Takımı Bağlanarak Orjinal Tuş Takımı Simülasyonu Yapılması
- [ ]  Arduino Kodunun MSP430 için Rewrite Edilmesi
- [ ]  Grafik LCD İle Telsizden Gelen Verilerin Ekranda Görüntülenmesi
- [ ]  PCB Tasarımının Yapılması




ilk sketch
<IMG SRC=https://github.com/barisdinc/Aselsan_Boynuz/blob/master/3D/Aselsan_Boynum_ilk_sketch.jpg>

ilk donanim tasarimi
<IMG SRC=https://github.com/barisdinc/Aselsan_Boynuz/blob/master/Donanim/Tasarim/Tasarim_2.jpg>

