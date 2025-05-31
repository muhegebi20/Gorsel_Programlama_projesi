# 🏨 Otel Yönetim Sistemi

Bu proje, bir otelin temel işleyişini dijital olarak yönetmeyi amaçlayan Windows Forms tabanlı bir **otel yönetim sistemi uygulamasıdır**. Proje Visual Studio ve C# diliyle geliştirilmiş olup veritabanı olarak **MongoDB** kullanılmaktadır.

## 📌 Özellikler

### 🔐 Giriş & Yetkilendirme
- Kullanıcılar e-posta ve şifre ile giriş yapabilir.
- Şifreler güvenli bir şekilde **BCrypt** ile hash’lenmiştir.
- Hatalı girişlerde kullanıcıya bilgilendirme yapılır.
- Adminler için ayrı giriş ekranı mevcuttur.

### 🖥️ Ana Sayfa
- Kullanıcı, giriş ve çıkış tarihini seçebilir.
- Kişi sayısına göre uygun odalar aranabilir.
- Kullanıcı dostu ve görsel açıdan sade arayüz.

### 🛠️ Admin Paneli
- Kullanıcı bilgilerini görüntüleme, düzenleme ve silme.
- Oda ekleme, güncelleme ve silme işlemleri.
- Mevcut rezervasyonların kontrolü.

### 🛏️ Oda Yönetimi
- Odalar tür, kapasite, fiyat ve durum bilgilerine göre yönetilir.
- Oda filtreleme: Durum, tür veya fiyat aralığına göre arama yapılabilir.
- Kullanıcıya sadece uygun odalar listelenir.

### 🔍 Rezervasyon Arama
- Seçilen tarih ve kişi sayısına göre uygun odaları listeler.
- Sonuçlar DataGridView üzerinden kullanıcıya sunulur.

---

## 🧪 Kullanılan Teknolojiler

- 👨‍💻 **.NET / Windows Forms**
- 💾 **MongoDB**
- 🔐 **BCrypt.Net** (şifre güvenliği)
- 🖼️ Custom UI (arka plan görselleri, modern buton tasarımları)

---

## 📂 Proje Yapısı

```plaintext
📁 Forms/           → Uygulama arayüz formları (Login, Admin, Main, etc.)
📁 Model/           → Room, User, Reservation sınıfları
📁 Controller/      → İş mantığı (roomController, reservationController vs
