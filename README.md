# Traversal Core Proje 8.0

**TraversalCoreProje** — Asp.Net Core + MVC + N-Katmanlı mimari ile geliştirilmiş, dinamik ve modüler bir seyahat/rezervasyon uygulaması.  
Eğitmenliğini Murat Yücedağ hocamın yürüttüğü ve YouTube üzerinde yayınlanan Traversal serisi üzerinden geliştirilmiştir.

---

## 🚀 Projenin Amacı & Ne İşe Yarıyor

Bu proje ile;  
- Admin, kullanıcı ve misafir (vitrin) olmak üzere üç farklı rol için panel yapısı sağlanır.  
- Adminler; tur rotaları, rehberler, üyeler, mesajlar, yorumlar, duyurular gibi modüller üzerinde CRUD işlemleri yapabilir.  
- Kullanıcılar; rezervasyonlarını görüntüleyebilir, yeni rezervasyon yapabilir, profilini düzenleyebilir.  
- Misafirler/vitrin kullanıcıları; siteye üye olmadan aktif tur rotalarını, rehberleri ve iletişim bilgilerini görebilir.  
- API + SignalR desteği ile kullanıcıların bulunduğu ülkenin anlık olarak grafik üzerinde görünmesini sağlayan dinamik bir yapı sunulur.  

--- 

## 🛠️ Teknolojiler & Mimariler  

- **C# / .NET Core (Asp.Net Core)** — Back-end, dinamik yapı  
- **MVC & N-Katmanlı Mimari** — Presentation / Business / DataAccess / Entity / API / APIConsume / UI katmanları ile modüler yapı  
- **ORM: Entity Framework (Code-First)** — MSSQL ile veritabanı iletişimi  
- **CQRS Design Pattern** — Okuma ve yazma işlemlerini ayırarak kod organizasyonu  
- **DTO + AutoMapper** — Veri transferi ve mapping işlemleri için  
- **PartialView + View Component / Katmanlı UI** — UI sayfalarının modüler, okunabilir ve yeniden kullanılabilir olması için  
- **Authentication & Authorization** — Roller bazında erişim kontrolü (Admin, Kullanıcı, Misafir)  
- **SignalR** — İstemci ve sunucu arasında anlık veri aktarımı (örneğin; kullanıcı ülke dağılımı grafiği)  

---

## 🧩 Katman Yapısı  

| Katman | Görevi |
|--------|--------|
| Presentation Layer (UI) | Kullanıcıya sunulan arayüz |
| Business Logic Layer | İş mantığı, kurallar ve operasyonlar |
| Data Access Layer | Veritabanı ile iletişim, CRUD işlemleri |
| Entity Layer | Code-First varlık tanımı, modeller |
| API Katmanı | Diğer platformlardan veri alımı / sunumu, servis uç noktaları |
| API Consume Katmanı | API tüketimi, veri çekme/gönderme |
| UI Katmanı (PartialView) | UI bileşenlerinin modüler ve yeniden kullanılabilir olması |

---

## 🎯 Panel & Özellikler  

### Admin Panel  
- Dashboard – Sistem istatistikleri  
- Tur Rotaları — Listeleme, oluşturma, güncelleme, silme  
- Rehber Listesi — Rehber ekleme, silme, aktif/pasif durumu güncelleme  
- Üyeler, Yorumlar, Mesajlar, Duyurular — CRUD işlemleri  
- Rol / Rol İşlemleri — Kullanıcı rolleri oluşturma / yönetme  
- Raporlar — PDF olarak şirket raporu oluşturma  
- E-mail Gönderimi — Kullanıcılara toplu ya da bireysel mail gönderimi
#
![AdminDashboard](https://github.com/user-attachments/assets/8a7c98e4-ed45-44c5-a81c-b6d54156a0da)

### Kullanıcı Paneli  
- Dashboard — Profil bilgisi, aktif rehberleri görüntüleme  
- Son Rotalar — Admin tarafından eklenen son turların listesi  
- Profilim — Profil görüntüleme / düzenleme  
- Rezervasyonlar — Aktif, geçmiş, onay bekleyen rezervasyonların listesi + yeni rezervasyon yapma

  ![AnaSayfa1](https://github.com/user-attachments/assets/3acc821e-fdf8-4026-99b6-5fea8d9ca6b8)


### Vitrin Paneli (Misafir)  
- Tur Rotaları ve Rehberleri Görüntüleme — Rol gerekmeden sayfaya erişim  
- Login / Kayıt ol  
- 404 Hata Sayfası  
#
![GirişSayfası](https://github.com/user-attachments/assets/1595ec6a-c54d-4be8-b0a4-c29820a58936)
#
![HesapOluştur](https://github.com/user-attachments/assets/11a808e9-5b65-45d7-9f09-a0ffd2f1d068)
#
![Hata Sayfası](https://github.com/user-attachments/assets/f563bc88-480a-46eb-9a83-ee6ec0e105f4)
##

# Proje Görüntüleri



![AnaSayfa5](https://github.com/user-attachments/assets/fa9cec7e-c37b-4c3c-bb51-348110fc8f99)
#
![AnaSayfa4](https://github.com/user-attachments/assets/05527b95-3c81-460e-b1ae-2d83f17cf2de)
#
![AnaSayfa3](https://github.com/user-attachments/assets/d516c42d-fe07-4303-b1b0-905c636cb521)
#
![AnaSayfa2](https://github.com/user-attachments/assets/89fc4674-66b0-4209-9ee0-e61787d56232)
#
![AdminYeniRezervasyon](https://github.com/user-attachments/assets/f4660bd1-7fcc-4199-90b8-480d571689b3)
#
![AdminTurRotalarımız](https://github.com/user-attachments/assets/45508a95-7b3b-42e4-a33d-f57563fee1a8)
#
![Rotalar5](https://github.com/user-attachments/assets/1f227cf8-3cbb-49ee-8a0d-f90d015390f9)
#
![Rotalar4](https://github.com/user-attachments/assets/3874cdac-1309-470e-9175-c684e0a07807)
#
![Rotalar3](https://github.com/user-attachments/assets/ddbed1a7-9d40-444c-8ba0-aa62e643b6e5)
#
![Rotalar2](https://github.com/user-attachments/assets/1e414cd8-7bb8-4ddf-9a93-6c95d614c0d9)
#
![Rotalar1](https://github.com/user-attachments/assets/c423f6e3-3b23-4c67-8d8d-fb68491afcb3)
#
![Rehberlerimiz1](https://github.com/user-attachments/assets/adc33e78-9eb2-4881-ba61-c9fd37d61cc7)
#
![İletişim1](https://github.com/user-attachments/assets/ab7ec1a6-2899-4f4b-8290-1ff495e31ae5)
#
![AnaSayfa6](https://github.com/user-attachments/assets/ca93ea25-890e-423d-87a0-b180eedd8451)
