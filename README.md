# Auto Salon API

Backend REST API për aplikacionin **Auto Salon** — sistem menaxhimi për një sallon makinash.

## Teknologjitë

- **C#** / **ASP.NET Core** (.NET 10)
- **Swagger** për dokumentimin e API-së
- **CORS** i aktivizuar për frontend

## Struktura

```
Auto.API/
├── Controllers/
│   └── CarsController.cs    # Endpoints REST (GET, POST, PUT, DELETE)
├── Data/
│   ├── CarStore.cs          # Magazinë e të dhënave në memorie
│   └── Models/
│       └── Car.cs           # Modeli i makinës
├── Program.cs               # Konfigurimi i aplikacionit
└── appsettings.json
```

## Endpoint-et

| Metoda | URL | Përshkrimi |
|--------|-----|------------|
| GET    | `/cars`      | Merr të gjitha makinat |
| GET    | `/cars/{id}` | Merr një makinë sipas ID |
| POST   | `/cars`      | Shton një makinë të re |
| PUT    | `/cars/{id}` | Përditëson një makinë |
| DELETE | `/cars/{id}` | Fshin një makinë |

```

API-ja do të jetë aktive në: **http://localhost:5280**

Swagger UI: **http://localhost:5280/swagger**

## Frontend

Kjo API përdoret nga frontend-i: [Auto.Client](https://github.com/Xhoni11/Auto.Client)
