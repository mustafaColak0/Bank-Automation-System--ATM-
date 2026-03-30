
# 🏦 Gelişmiş Banka ve ATM Otomasyon Sistemi

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Console App](https://img.shields.io/badge/Console-Application-black?style=for-the-badge)

Bu proje, C# programlama dili kullanılarak sıfırdan geliştirilmiş, sağlam bir mimariye sahip interaktif bir Banka/ATM simülasyonudur. Sistem, kullanıcıların temel finansal işlemlerini konsol üzerinden güvenli, hızlı ve "çökmeye karşı dayanıklı" (crash-proof) bir şekilde yapabilmesi için tasarlanmıştır.

## 📋 İçindekiler
- [Projenin Amacı](#-projenin-amacı)
- [Temel Özellikler](#-temel-özellikler)
- [Teknik Altyapı ve Kullanılan Yapılar](#-teknik-altyapı-ve-kullanılan-yapılar)
- [Kurulum ve Çalıştırma](#-kurulum-ve-çalıştırma)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Gelecek Hedefleri (Yol Haritası)](#-gelecek-hedefleri)

---

## 🎯 Projenin Amacı
Bu projenin temel geliştirilme amacı; Algoritma mantığını oturtmak, veri yapılarını (Collections) anlamak ve kullanıcıdan gelen hatalı veya beklenmedik verileri (Exception Handling) sistemi çökertmeden yönetebilmektir. 

## 🚀 Temel Özellikler

* **🔐 Güvenli Kimlik Doğrulama:** Kullanıcıların sisteme hesap numarası/kullanıcı adı ve şifre ile güvenli girişi.
* **💰 Dinamik Bakiye Yönetimi:** Para çekme ve yatırma işlemlerinde bakiyenin anlık olarak güncellenmesi.
* **🛡️ Hata ve İstisna Yönetimi (Exception Handling):**
  * Kullanıcının sayı yerine harf girmesi durumunda sistemin çökmesini engelleyen `Try-Catch` blokları.
  * Çekilmek istenen tutarın bakiyeden büyük olması durumunda "Yetersiz Bakiye" kontrolü.
  * Negatif değer girişlerinin engellenmesi.
* **🔄 Kesintisiz Akış:** Kullanıcı "Çıkış" yapana kadar ana menünün sürekli aktif kalmasını sağlayan sonsuz döngü mimarisi.

---

## 💻 Teknik Altyapı ve Kullanılan Yapılar

Proje geliştirilirken modern C# programlama prensipleri kullanılmıştır:

* **Veri Tutma (Koleksiyonlar):** Kullanıcı bilgileri ve bakiyeleri eşleştirmek için yüksek hızlı `Dictionary<TKey, TValue>` ve `List<T>` yapıları kullanıldı.
* **Akış Kontrolü:** Uygulamanın yaşam döngüsü `while(true)` döngüleri ile sağlandı.
* **Karar Mekanizmaları:** Kullanıcı seçimlerine göre yönlendirmeler `switch-case` ve `if-else` blokları ile inşa edildi.
* **String Manipülasyonu:** Kullanıcıdan alınan metin girdilerini standartlaştırmak için (büyük/küçük harf duyarlılığını ortadan kaldırmak vb.) C# string metotları kullanıldı.

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi kendi ortamınızda test etmek için aşağıdaki adımları izleyebilirsiniz:

### Gereksinimler
- Bilgisayarınızda **.NET SDK** (Önerilen: 6.0 veya üzeri) yüklü olmalıdır.
- Visual Studio 2022 veya Visual Studio Code.

### Adımlar

1. Bu depoyu yerel bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/mustafaColak0/bank-automation-system.git](https://github.com/mustafaColak0/bank-automation-system.git)
