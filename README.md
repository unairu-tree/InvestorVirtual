# 🚀 InvestorVirtual

> Hobby-styled learning based web application for stock market investment concepts, built with ASP.NET Core MVC and Entity Framework Core.

![.NET Version](https://img.shields.io/badge/.NET-10.0-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10.0-blue)
![License](https://img.shields.io/badge/license-Apache_2.0-green)

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Features](#features)
- [Usage](#usage)
- [Database Setup](#database-setup)
- [Configuration](#configuration)
- [License](#license)
- [Contact](#contact)

---

## 📖 About the Project

This is a learning based web application built around the concept of stock market investment. It is designed to help users understand the basics of investing in stocks, learn new terms used in the finance industry, and practice making investment decisions.
It demonstrates core concepts like MVC architecture, Entity Framework Core, and RESTful API design.

---

## 🛠️ Technologies Used

| Technology                  | Version  | Purpose                                                       |
|-----------------------------|----------|---------------------------------------------------------------|
| .NET SDK                    | 10.0     | Framework                                                     |
| ASP.NET Core MVC            | 10.0     | Web framework                                                 |
| Entity Framework Core       | 10.0     | ORM / Database access                                         |
| LocalDB                     | -        | Database                                                      |
| Bootstrap                   | 5.3      | Frontend styling                                              |
| Razor Pages / Views         | -        | Server-side HTML rendering                                    |
| Visual Studio               | 2026     | IDE                                                           |
| Git (integrated in VS)      | -        | Version control                                               |
| GitHub                      | -        | Repository hosting                                            |
| C#                          | 10.0     | Programming language                                          |
| JavaScript                  | -        | Client-side scripting                                         |
| HTML                        | -        | Markup language                                               |
| CSS                         | -        | Styling language                                              |
| Gemini AI                   | Gemini 3 | For CSS, JS, HTML, Data seeding, Company description summary. |
| Yahoo Finance               | -        | For stock data and company information                        |
| Grammarly Character Counter | -        | For checking character count in text                          |
| CorelDraw                   | X7       | For company logo svg creation                                 |

---

## ✅ Prerequisites

Make sure you have the following installed before running the project:

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2026](https://visualstudio.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or LocalDb (Data storage module from Visual Studio)/SQLite (if used)
- [Git](https://git-scm.com/) or use integrated Git in Visual Studio

---

## 🚀 Getting Started

Follow these steps to get the project running locally.

### 1. Clone the repository

```bash
git clone https://github.com/unairu-tree/InvestorVirtual.git
cd InvestorVirtual
```

Or download the ZIP file from GitHub and extract it.
Then start "InvestorVirtual.slnx".

### 2. Restore dependencies

(If needed in case Visual Studio does not restore them by default)

```bash
dotnet restore
```

### 3. Apply database migrations

```bash
dotnet ef database update
```

Or "Update-Database" in the Package Manager Console in Visual Studio.
(Make sure that "InvestorVirtual" is selected as solution startup project while "InvestorVirtual.Data" is selected as the default package manager project)

### 4. Run the application

```bash
dotnet run
```

Or press F5 in Visual Studio to start debugging.
Alternatively, you can use Ctrl + F5 to run without debugging.

---

## 📁 Project Structure

```
InvestorVirtual/
│
├── wwwroot/                      # Static files (CSS, JS, images)
├── Areas/                        # Identity
├── Controllers/                  # MVC Controllers
├── ViewModels/                   # ViewModels
├── Views/                        # Razor Views (.cshtml)
├── appsettings.json              # App configuration
├── Program.cs                    # App entry point and middleware setup
├── InvestorVirtual.Common/    
|   ├── Extensions/               # Extension methods
|   ├── ApplicationConstants.cs   # Application-wide constants
|   └── EntityValidation.cs       # Entity validation attributes
├── InvestorVirtual.Core       
|   ├── Contracts/                # Interfaces for services and repositories
|   ├── Models/                   # DTO models
|   └── Services/                 # Business logic services
└── InvestorVirtual.Data       
    ├── Common/                   # Repository base classes and interfaces
    ├── Configuration/            # Data model seeding configuration
    ├── Migrations/               # EF Core migrations
    ├── Models/                   # Database models
    └── ApplicationDbContext.cs   # EF Core DbContext
```

---

## ✨ Features

- [x] User registration and login (ASP.NET Identity)
- [x] CRUD operations for [LearningTerm.cs]
- [x] RESTful API endpoints
- [x] Input validation (server-side & client-side)
- [x] Responsive UI with Bootstrap
- [x] Theme changing, including pallets and light/dark mode
- [ ] Charts for visualizing stock data (using Chart.js or similar)
- [ ] Interactive investing with virtual currency
- [ ] Day cycle simulation for stock market (using background services)
- [ ] Role specific actions and management (ASP.NET Identity)

---

## 💻 Usage

Describe how to use the main features of the app after launching it. Add screenshots if possible.

```
1. Navigate to /Register to create an account.
2. Log in at /Login.
3. Use the dashboard to manage your [entities].
```

> 💡 **Tip:** You can add screenshots using: `![Screenshot](docs/screenshot.png)`

---

## 🗄️ Database Setup

The project uses **Entity Framework Core** with a Code-First approach.

Connection string is configured in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=InvestorVirtualDB;Integrated Security=True;TrustServerCertificate=True"
}
```

To create and seed the database:

```bash
dotnet ef database update
```

Or "Update-Database" in the Package Manager Console in Visual Studio.
(Make sure that "InvestorVirtual" is selected as solution startup project while "InvestorVirtual.Data" is selected as the default package manager project)

---

## ⚙️ Configuration

Key settings in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=InvestorVirtualDB;Integrated Security=True;TrustServerCertificate=True"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Identity": {
    "Password": {
      "RequireDigit": true,
      "RequiredLength": 10,
      "RequiredUniqueChars": 5,
      "RequireNonAlphanumeric": true,
      "RequireUppercase": true,
      "RequireLowercase": true
    },
    "Lockout": {
      "DefaultLockoutTimeSpan": "00:10:00",
      "MaxFailedAccessAttempts": 3,
      "AllowedForNewUsers": true
    },
    "User": {
      "RequireUniqueEmail": true
    },
    "SignIn": {
      "RequireConfirmedAccount": true,
      "RequireConfirmedEmail": true,
      "RequireConfirmedPhoneNumber": true
    }
  }
}
```

---

## 📄 License

This project is licensed under the **Apache 2.0 License**. See the [LICENSE](LICENSE) file for details.

---

## 📬 Contact

**Unairu** – [@unairu-tree](https://github.com/unairu-tree)

Project Link: [https://github.com/unairu-tree/InvestorVirtual](https://github.com/unairu-tree/InvestorVirtual)

---