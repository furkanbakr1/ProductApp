# 🛍️ ProductApp - ASP.NET Core MVC ile Ürün Yönetim Sistemi

ProductApp, ASP.NET Core MVC teknolojisiyle geliştirilmiş, JWT destekli, çok katmanlı mimariye sahip örnek bir ürün yönetim sistemidir. Admin paneli, rol yönetimi, kullanıcı yönetimi, API endpoint'leri ve bootstrap ile responsive bir arayüze sahiptir.

---

## 🚀 Özellikler

- Kullanıcı Kayıt / Giriş Sistemi (ASP.NET Identity)
- JWT ile API Güvenliği
- Ürün Listeleme ve Ekleme (CRUD)
- Admin Paneli:
  - Kullanıcı yönetimi
  - Rol yönetimi
- Swagger UI ile API test ortamı
- Bootstrap 5 UI ile modern arayüz
- Çok Katmanlı Mimari:
  - `Entities`
  - `DataAccess`
  - `Business`
  - `Web`

---

## 🛠️ Teknolojiler

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- Identity + JWT Authentication
- AutoMapper
- FluentValidation
- Swagger (Swashbuckle)
- Bootstrap 5

---

## 📂 Katman Yapısı

ProductApp/ │ ├── ProductApp.Entities → Entity sınıfları ├── ProductApp.DataAccess → DbContext & Repositories ├── ProductApp.Business → Servisler (Business Logic) ├── ProductApp.Web → Web projesi (MVC + Razor + API) │ ├── Areas/Admin → Yönetim Paneli │ └── Controllers → Ürün ve API controller'ları
E-posta : admin@admin.com
Şifre : Admin123!

> Not: Bu bilgiler `IdentitySeedData.cs` dosyasında otomatik olarak oluşturulmaktadır.

---

## 🔧 Kurulum

```bash
git clone https://github.com/furkanbakr1/ProductApp.git
cd ProductApp
dotnet ef database update
dotnet run

 API Kullanımı
JWT ile korunan API'leri Swagger üzerinden test etmek için:

/api/AuthApi/Login üzerinden token al.

Swagger UI sağ üstteki "Authorize" butonuna tıkla.

Token'ı "Bearer <token>" formatında gir.
