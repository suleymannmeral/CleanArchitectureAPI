# 📚 Clean Architecture API

Bu proje Clean Architecture mimarisini öğrenmek amacı ile geliştirilen bir API projesidir.


> 🔧 Proje geliştirme süreci **aktif olarak devam etmektedir**.  


## 🛠 Kullanılan Teknolojiler

| Teknoloji              | Açıklama                                              |
|------------------------|--------------------------------------------------------|
| **ASP.NET Core Web API** | Projenin backend altyapısı                            |
| **MSSQL**              | Veritabanı yönetimi için                              |
| **Entity Framework Core** | ORM aracı olarak                                     |
| **Identity + JWT**     | Kimlik doğrulama ve yetkilendirme işlemleri için      |
| **Postman**            | API testleri ve dokümantasyonu                        |

---

## 🧱 Katmanlar

Bu projede Clean Architecture yapısı temel alınarak katmanlı bir mimari benimsenmiştir. Her bir katman belirli bir sorumluluğu yerine getirmek üzere yapılandırılmıştır:

| Katman Adı           | Açıklama |
|----------------------|----------|
| **Domain Katmanı**   | (Bu katman, uygulamanın iş kurallarını ve temel varlıklarını içerir. Diğer katmanlara bağımlı değildir.) |
| **Application Katmanı** | (Uygulamanın use case'lerini ve iş akışlarını içerir. Domain katmanına bağımlıdır ama dış katmanlara bağımlı değildir.) |
| **Infrastructure Katmanı** | (Veritabanı işlemleri, dış servislerle iletişim gibi altyapı ile ilgili işlemler burada bulunur.) |
| **Presentation Katmanı**      | (Kullanıcıdan gelen isteklerin alındığı ve dış dünyaya açılan uç noktalardır. Controller yapıları burada bulunur.) |
| **WEBAPI Katmanı**      | (Projenin konfigrasyonu işlemelerini içermektedir.(DI kayıtları, Middlewareler vs....) |


> 🔄 Bu yapı sayesinde, her bir katman birbirinden ayrılmış olur ve bakım, test edilebilirlik ile ölçeklenebilirlik artar.

## 📌 Notlar

- Projede CQRS tasarım deseni kullanılmıştır.
- Kod yapısı `Clean Code` prensiplerine uygun olarak yazılmaya özen gösterilmiştir.

---

## 📬 İletişim

Her türlü soru, görüş veya öneriniz için bana GitHub üzerinden ulaşabilirsiniz.

---
