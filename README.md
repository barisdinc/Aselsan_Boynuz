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

# Donanım Seçimi Konusunda Fikirler

### MCU Seçimi
- 1.İhtimal Barış Dinç (TA7W) Hocanın hurdadan temin etmiş olduğu MSP430 MCUları kullanmak. Bu durumda yazacağımız kodun 16K'dan küçük olması lazım ki tüm MCU'lara fit etsin
  - MSP430FE427IPMR  - 32K Depolama
  - MSP430FE425AIMPR - 16K Depolama
  - MSP430F436IPZR   - 24K Depolama
  
- 2.İhtimal Sıradan bir arduino MCU kullanmak. 

### Ekran Seçimi
- SPI TFT LCD Kullanabiliriz. 
- Grafik LCD Kullanabiliriz. (Bu durumda MCP23017 gibi bir I/O Expander kullanıp I2C ile sürmek gerekiyor ekranı. Maliyet olarak fazla olabilir)
- 4x20 , 4x16 gibi Çok Satırlı Karakter LCD kullanabiliriz I2C Backpack ile. 

### Tuş Takımı
Varolan tuş takımını yeni kutuya taşımamız gerekecek. Bu durumda ekstra bir tuş takımına ihtiyaç olacak. Hali hazırda Up/Down işlemini Rotary Encoder ile halleder isek 2 buton eksik olacak şekilde 12 adet nümerik kısım için , 6 adet de fonksiyon tuşları için totalde 18 adet butona ihtiyaç var. Haliyle bu butonların da MCU'ya direkt ya da PCF8574 gibi bir expander üzerinden I2C hattına dahil edilmesi gerek.


### PIN Sayısı Konusu

| Fonksiyon             | Gereken Pin Sayısı  | Açıklama |
|-----------------------|:--------------------:|----------|
| I2C                   |          2          |Telsizden LCD bilgisini almak ,yeni LCD'ye veri yazmak, keypad bilgisini göndermek için|   
| Indicator Leds        |          3          |Yeşil , Kırmızı , Turuncu Ledleri Yakmak İçin                    |
| Keypad Interrupt      |          1          |Telsizin MCU'suna Tuşa Basıldı Bilgisini Göndermek için          |  
| Rotary Encoder        |          2          |Rotary Encoder Dönüş Yönünü Okumak İçin.Ekstra olarak Buton ile Kullanılırsa +1| 
| Keypad                |          9          |3x6 Matrix şeklinde düşünürsek ve **I2C için bir IC kullanmazsak.**  |
| **Total**                 |         **17**      ||



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

