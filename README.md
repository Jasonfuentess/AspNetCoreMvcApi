# AspNetCoreMvcApi
GeoArticle API – ASP.NET Core REST API (Clean Architecture)

This is a multi-layer RESTful API built using ASP.NET Core MVC, structured around the Clean Architecture approach. It is designed to manage and maintain geo-referenced articles, such as city-based data entries with latitude and longitude.

🧱 Architecture Overview

java

Solution
│
├── Api                 → ASP.NET Core Web API (Controllers)
├── BusinessLayer       → Class Library (Business logic and services)
└── DataAccessLayer     → Class Library (EF Core DbContext and Repositories)
🌐 Use Case: Geo-Located Articles

The API allows full CRUD operations for entries representing articles or cities with geolocation data.
Each record includes:

Sid – String identifier

id – Primary integer ID

city_name – Name of the city

lat – Latitude

long – Longitude

🚀 Features

🔹 Create new geo-articles

🔹 Retrieve by ID or list all

🔹 Update existing records

🔹 Delete records

🔹 Structured with proper data validation and separation of concerns

⚙️ Tech Stack

ASP.NET Core Web API (MVC)

C#

Entity Framework Core

SQL Server

Postman (for endpoint testing)

## 🧪 Sample API Test (Postman)

### 🔍 GET Example

![GET Example](../assets/GET.JPEG)

### 🔍 POST  Example

![POST Example](../assets/POST.JPEG)

### 🔍 PUT  Example

![PUT Example](../assets/PUT.JPEG)

### 🔍 DELETE  Example

![DELETE Example](../assets/DELETE.JPEG)
