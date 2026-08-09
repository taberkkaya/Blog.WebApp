# Cihan Gökpınar — SAP FI Blog & Knowledge Hub

SAP FI danışmanlığı, güncel yazılar ve uygulama dokümanları için geliştirilmiş tam kapsamlı web uygulaması. Proje; ziyaretçi sitesi, içerik kütüphanesi ve yönetim panelinden oluşur.

## Teknolojiler

- Angular 18
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core ve SQL Server
- Clean Architecture, CQRS ve MediatR
- ASP.NET Core Identity ve JWT
- Quill içerik editörü

## Proje yapısı

```text
Blog.Client/my-app                         Angular kullanıcı ve admin arayüzü
Blog.Server/AK.BlogWebApp.WebAPI           API başlangıç projesi
Blog.Server/AK.BlogWebApp.Application      Uygulama ve CQRS katmanı
Blog.Server/AK.BlogWebApp.Domain           Domain modelleri
Blog.Server/AK.BlogWebApp.Infrastructure   Veritabanı ve altyapı katmanı
```

## Gereksinimler

- .NET 8 SDK veya üzeri
- Node.js 20 veya üzeri
- SQL Server
- Angular CLI

## Güvenli yerel yapılandırma

Gerçek veritabanı bağlantısı, JWT anahtarı ve production parolaları repoya eklenmemelidir. Bunları .NET User Secrets ile tanımlayın:

```powershell
cd Blog.Server/AK.BlogWebApp.WebAPI
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:SqlServer" "YOUR_LOCAL_CONNECTION_STRING"
dotnet user-secrets set "Jwt:SecretKey" "YOUR_LONG_RANDOM_LOCAL_SECRET"
dotnet user-secrets set "Jwt:Issuer" "Blog.WebApp"
dotnet user-secrets set "Jwt:Audience" "Blog.WebApp.Client"
```

Alternatif olarak yalnızca yerelde kullanılan `appsettings.Local.json` dosyasını tercih edebilirsiniz. Bu dosya `.gitignore` kapsamındadır.

## Veritabanını hazırlama

```powershell
cd Blog.Server
dotnet ef database update `
  --project AK.BlogWebApp.Infrastructure `
  --startup-project AK.BlogWebApp.WebAPI
```

## Backend'i çalıştırma

```powershell
cd Blog.Server
dotnet run --project AK.BlogWebApp.WebAPI --launch-profile https
```

Swagger: `https://localhost:7054/swagger`

## Frontend'i çalıştırma

Yeni terminal açın:

```powershell
cd Blog.Client/my-app
npm install
npm start
```

```text
Site:         http://localhost:4200
Admin girişi: http://localhost:4200/login
```

Frontend'in yerel API adresi `src/app/constants.ts` dosyasında tanımlıdır.

## Doğrulama

```powershell
dotnet build Blog.Server/AK.BlogWebApp.sln
cd Blog.Client/my-app
npm run build
```

## Güvenlik notları

- Connection string, JWT secret ve yayın profillerini commit etmeyin.
- Production değerlerini environment variable veya güvenli secret store üzerinden sağlayın.
- Daha önce yayımlanmış bir parola veya anahtar varsa repodan silmek yeterli değildir; ilgili değeri mutlaka yenileyin.
