# 🧀 Dairy-Restaurant – Backend (ASP.NET Core API)

## 📘 Overview
This is the backend for a full-stack Dairy-Restaurant web application, built using ASP.NET Core Web API with layered architecture and built-in dependency injection.

---

## 🔧 Technologies Used

- C# with .NET 6+
- ASP.NET Core Web API
- Entity Framework Core (DB First approach)
- SQL Server
- Layered Architecture:
  - **Controllers** – define API endpoints
  - **Services** – business logic
  - **Repositories** – data access layer
- Built-in Dependency Injection (DI)

---

## 🗂 Project Structure

```
/Controllers  
/Services  
/Repositories  
/Models  
/Data  
Program.cs
```

---

## ⚙️ Setup Instructions

1. Navigate to the server project folder:
   ```bash
   cd Server
   ```
2. Configure the database connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=BigBite;Trusted_Connection=True;"
   }
   ```
3. Scaffold models from the database:
   ```bash
   dotnet ef dbcontext scaffold "Server=localhost;Database=BigBite;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
   ```
4. Run the Web API:
   ```bash
   dotnet run
   ```

---

## 🧪 Testing

- Unit tests using xUnit (if implemented)

---

## 📄 License

MIT
