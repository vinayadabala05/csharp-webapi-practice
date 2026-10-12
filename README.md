# C# ASP.NET Web API Practice Project

Simple beginner-level **ASP.NET Web API** project created for learning backend development.

## What this project does

- Creates a basic Web API with CRUD-style endpoints for Products
- Uses in-memory data (no database required to run)
- Demonstrates Controllers, Models, and basic REST API structure

## Endpoints

| Method | Endpoint              | Description          |
|--------|-----------------------|----------------------|
| GET    | /api/products         | Get all products     |
| GET    | /api/products/{id}    | Get product by ID    |
| POST   | /api/products         | Create a new product |
| PUT    | /api/products/{id}    | Update a product     |
| DELETE | /api/products/{id}    | Delete a product     |

## How to run

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/download)
2. Open terminal in the project folder
3. Run:

```bash
dotnet run
```

4. Open browser or Postman:
   - `https://localhost:5001/api/products`

## Project Structure

```
csharp-webapi-practice/
├── Controllers/
│   └── ProductsController.cs
├── Models/
│   └── Product.cs
├── Program.cs
├── csharp-webapi-practice.csproj
└── README.md
```

## Author

**Vinay Adabala**  
GitHub: [vinayadabala05](https://github.com/vinayadabala05)
