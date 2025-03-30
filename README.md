# 🧪 Technical Test - .NET 8 Web API

This project was developed as part of a technical challenge. It is a clean and modular .NET 8 Web API that performs full CRUD operations on a `Product` entity, following Clean Architecture principles.

All endpoints are exposed and testable through Swagger.

---

## 🛠️ Technologies Used

- .NET 8 Web API
- C#
- Clean Architecture (layered structure)
- In-Memory Repository (no database required)
- Swagger (OpenAPI UI)

---

## 📁 Project Structure

```
TechnicalTest/
├── API/Controllers/             → API Controllers
├── Application/Interfaces/      → Interfaces for business logic
├── Domain/Entities/             → Domain models
├── Infrastructure/Repositories/ → In-memory repository implementation
├── Program.cs                   → Application startup configuration
└── Properties/launchSettings.json
```

---

## 🚀 How to Run the Project

1. Open the project in **Visual Studio 2022 or newer**
2. Make sure you have the **.NET 8 SDK** installed
3. Use the launch profile: **`TechnicalTest`**
4. Press `F5` or run the project
5. Open your browser and navigate to:

```
https://localhost:5001/swagger
```

> If you're using a different port, check the `launchSettings.json` file.

---

## 🔍 Available Endpoints

| Method | Route                | Description                    |
|--------|----------------------|--------------------------------|
| GET    | /api/products        | Retrieves all products         |
| GET    | /api/products/{id}   | Retrieves a product by ID      |
| POST   | /api/products        | Creates a new product          |
| PUT    | /api/products/{id}   | Updates an existing product    |
| DELETE | /api/products/{id}   | Deletes a product              |

You can test all endpoints directly from Swagger.

---

## 💡 Notes

- The project uses an **in-memory repository**, so data is not persisted between runs.
- The architecture follows Clean Architecture principles for better scalability and maintainability.
- No external dependencies or database configuration required.

---
