# InventoryHub - FullStack

---

## 🧭 **Overview**
ProductHub API is a lightweight and optimized ASP.NET Core Minimal API built to demonstrate modern backend fundamentals such as in-memory caching, CORS configuration, and clean endpoint design.
The API exposes a simple product list with categories and showcases how to:
- Serve fast responses using IMemoryCache
- Configure CORS for frontend integrations (Blazor, React, Angular)
- Build APIs using the minimal hosting model in .NET 8
- Provide clean routing and prevent 404 root errors
- This project was created as part of a learning exercise in backend development, optimization, and AI-assisted coding with Microsoft Copilot.

---

## ⚙️ **Features**
### 🧩 **Core Features**
- Minimal API architecture for fast and modern development
- Product listing endpoint (/api/productlist) with nested category data
- In-memory caching (60-second sliding expiration)
- CORS-ready with AllowAnyOrigin, AllowAnyMethod, AllowAnyHeader
- Root health endpoint (/) that returns "API is running"

---

### 🚀 **Advanced Features**
- Efficient caching using MemoryCacheEntryOptions
- Clean dependency injection of caching services
- Organized endpoint mapping for scalability
- AI-assisted improvements using Microsoft Copilot for debugging, optimization, and code clarity

---

## 📊 **Performance Optimizations**
- Leveraged in-memory caching to reduce repeated data processing
- Ensured sliding expiration to keep responses fresh but efficient
- Used minimal middleware to improve pipeline performance
- Reduced redundant computation by storing structured product data in cache

---

## 🔒 **Validation & Error Handling**
- Clear "API is running" message prevents root path 404 errors
- Results.Ok() ensures consistent JSON formatting
- Automatic regeneration of cached data if cache entry is missing
- Avoids CORS issues through fully permissive development configuration

---

## 🚀 **Future Enhancements**
- Integrate a real database (SQL Server/PostgreSQL)
- Add CRUD operations for products
- Implement request validation (FluentValidation)
- Add authentication & authorization
- Implement distributed caching (Redis)
- Create a Blazor or React frontend to consume the API

---

## 📜 **License**
This project is for educational purposes under Coursera Microsoft Full Stack Developer assignment. You may modify and use this project for learning, but proper credit to the author is appreciated.
