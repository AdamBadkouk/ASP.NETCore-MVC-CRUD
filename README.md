# ASP.NET Core MVC CRUD Operations

A simple **ASP.NET Core** MVC application for managing student records with **Entity Framework Core** and **SQL Server**.

## Features

- **CRUD Operations** for student management
- Student information tracking (Name, Email, Phone, City)
- Entity Framework Core with SQL Server backend
- Responsive web interface
- Data validation with annotations

## Technologies

- **Framework**: ASP.NET Core MVC (.NET 10.0)
- **ORM**: Entity Framework Core 10.0
- **Database**: SQL Server (LocalDB/SQL Server Express 2025)
- **Language**: C# 14

## Package References

The project uses the following NuGet packages:

- `Microsoft.EntityFrameworkCore` (10.0.0)
- `Microsoft.EntityFrameworkCore.SqlServer` (10.0.0)
- `Microsoft.EntityFrameworkCore.Tools` (10.0.0)
- 

## Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) 
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (SQL Server 2025 Express)
- [Visual Studio 2026](https://visualstudio.microsoft.com/) (recommended) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/AdamBadkouk/ASP.NETCore-MVC-CRUD
cd ASP.NETCore-MVC
```

### 2. Update Connection String

Edit the `appsettings.json` file in the `ASP.NETCore-MVC` folder to match your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DB_NAME;Encrypt=False;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

> **Note**:
> - Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name.
> - Replace `YOUR_DB_NAME` with your actual Database name


### 3. Apply Database Migrations

Open a terminal in the project directory and run:

```bash
cd ASP.NETCore-MVC
dotnet ef database update
```

This will create the database and apply all migrations.

### 4. Run the Application

#### Using Visual Studio:
1. Open `WebApi.slnx` 
2. Press `F5` or click the **Run** button

#### Using .NET CLI:
```bash
cd WebApi
dotnet run
```

The application will be available at:
- HTTPS: `https://localhost:7243`
- HTTP: `http://localhost:5057`


## Usage

### Managing Students

1. Navigate to the **Students** page from the navigation menu
2. **Add** new students using the "Create New" button
3. **Edit** existing student records
4. **Delete** students from the list
5. **View** detailed student information


## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature`)
3. Commit your changes (`git commit -m 'Add some Feature'`)
4. Push to the branch (`git push origin feature`)
5. Open a Pull Request

**Happy Coding!**

