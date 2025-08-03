# 🚀 Satış Analiz ve ORM Karşılaştırma Dashboardu  
**Büyük Veri ile ASP.NET Core MVC, Dapper & Entity Framework Core Performans Karşılaştırma Paneli**

![Platform](https://img.shields.io/badge/platform-ASP.NET%20MVC-blue)
![Database](https://img.shields.io/badge/database-MSSQL%20(LocalDB)-orange)
![CodeFirst](https://img.shields.io/badge/EF-Code%20First-success)
![UI](https://img.shields.io/badge/UI-Bootstrap%205-blueviolet)
![Status](https://img.shields.io/badge/status-Active-brightgreen)
![Dapper](https://img.shields.io/badge/EF-Dapper-brightgreen)
---

## 🎯 Proje Özeti
Bu proje, 10 milyon+ satırlık **gerçek satış verisi** kullanılarak geliştirilmiş, Dapper ve Entity Framework Core’un büyük veri üzerindeki performans farklarını karşılaştıran modern bir analiz dashboardudur.  
Kullanıcılar; satış istatistikleri, ciro, kâr, en çok satan ürünler ve mağazalar, şehir bazlı aylık grafikler gibi analizleri canlı olarak görüntüleyebilir.  
Ayrıca iki ORM'in **sorgu süresi** ve **bellek kullanımı** gibi metrikleri detaylı karşılaştırmalı olarak sunulur.

---

## 🏆 Neden Bu Proje?

- **Gerçek Büyük Veri:** 10M+ satırlık veri ile test
- **ORM Karşılaştırması:** Dapper ve EF Core’un hız, sorgu ve bellek performansı farkları
- **Modern Dashboard:** Responsive, kullanıcı dostu, dinamik arayüz
- **Geliştirici Odaklı:** SQL ve LINQ sorgu önizlemesi, grafiklerle destekli canlı analiz

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji         | Açıklama                            |
|------------------|-------------------------------------|
| ASP.NET Core MVC | Web uygulama çatısı                 |
| Dapper           | Hafif ve yüksek performanslı ORM   |
| EF Core          | ORM karşılaştırması için            |
| MSSQL            | Büyük veri tabanı                   |
| Bootstrap 5      | Responsive ve modern arayüz         |
| Chart.js         | Dinamik grafik ve görselleştirme    |
| jQuery / JS      | Dinamik işlemler ve event handling  |
| HTML5 & CSS3     | Arayüz temel yapısı ve stil         |

---

## ✨ Öne Çıkan Özellikler

- 🔍 **Dapper ile yüksek performanslı veri sorgulama**
- 🧠 **EF Core ile karşılaştırmalı sorgu süresi ve bellek ölçümü**
- 📊 **10M+ kayıt içeren büyük veri setiyle gerçekçi test ortamı**
- 📈 **Toplam satış, ciro, aylık satışlar, şehir bazlı istatistikler**
- 🏆 **En çok satan ürün ve mağazalara göre kategori bazlı analiz**
- 📝 **Son siparişler ve müşteri yorum kutuları**
- ⚡ **Chart.js ile interaktif ve dinamik grafikler**
- 📱 **Responsive arayüz: Mobil & masaüstü uyumu**

---

## 🧩 Proje Yapısı
├── Controllers/ -> MVC Controller dosyaları (Dapper, EF, İstatistik, Test)
├── Models/ -> Entity ve DTO sınıfları (Record, Sale, StatDto...)
├── Views/ -> Razor View dosyaları (Dashboard, Karşılaştırma...)
├── Context/ -> EF ve Dapper için DbContext ve bağlantılar
├── Services/ -> Dapper & EF servisleri, analiz servisleri
└── wwwroot/ -> CSS, JS, Bootstrap, Chart.js ve görseller



---

## 📸 Ekran Görüntüleri

<p align="center">
  <img src="https://github.com/user-attachments/assets/8e696edd-c0d6-4f7a-b59a-d7a5024f9670" width="100%" alt="Dashboard G1" />
</p>
<br />

<p align="center">
  <img src="https://github.com/user-attachments/assets/18ce9aa3-ec03-49a0-8f40-e2567316556e" width="100%" alt="Dashboard G2" />
</p>
<br />

<p align="center">
  <img src="https://github.com/user-attachments/assets/6fe3ffd5-903d-4652-9538-bcd565eb7807" width="100%" alt="Dashboard G3" />
</p>
<br />

<p align="center">
  <img src="https://github.com/user-attachments/assets/65813696-af0c-4796-9362-e7f568f7afa3" width="100%" alt="Dashboard G4" />
</p>

---

## 📦 Veri Seti ve Katkılar

- **Veri Seti:** [10M Turkish Market Sales Dataset – Ömer Çolakoğlu (Kaggle)](https://www.kaggle.com/)
- **Katkı ve Teşekkür:**
  - 🧠 **Ömer Çolakoğlu:** Büyük veri setini paylaşan Kaggle kullanıcısı
  - 🎓 **Murat Yücedağ:** Proje mentoru ve eğitimci
  - 🛠️ **My Yazılım:** Eğitim, destek ve yönlendirme için teşekkürler

---

## 📝 Notlar

- Tüm grafikler ve istatistikler dinamik olarak güncellenir.
- Dashboard, Bootstrap 5 ve Chart.js ile responsive şekilde tasarlanmıştır.
- Minimal ve hızlı yüklenen tek sayfa uygulama (SPA) deneyimi hedeflenmiştir.

---

© 2025 – **Satış Dashboardu Projesi**  
Eğitim: My Yazılım – 9. Proje  
Mentör: Murat Yücedağ  
Veri Seti: Ömer Çolakoğlu (Kaggle)

