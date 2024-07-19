# ASP.NET Core MVC Project

## Overview

This project is an ASP.NET Core MVC application that includes two main modules:
1. **Departments Module**: Manage departments and their hierarchical structure.
2. **Reminders Module**: Set reminders to email notifications.

## Features

- **Departments Module**:
  - Departments can contain multiple sub-departments, supporting a multi-level hierarchy.
  - View a list of all sub-departments within a selected department.
  - View all parent departments up to the top-level for a selected department.

- **Reminders Module**:
  - Set reminders with a title and specific date-time.
    
## Technologies Used

- **ASP.NET Core MVC**: Framework for building the web application.
- **Entity Framework Core**: ORM for database access.
- **Microsoft SQL Server**: Database management system.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/AbdallahAbdelrasoul/RingoMediaTask.git
    cd RingoMediaTask
    ```

2. **Configure Database**:
    - Update the connection string in `appsettings.json` with your SQL Server instance:
    ```json
    "ConnectionStrings": {
         "DefaultConnection": "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True;TrustServerCertificate=True;"

    }
    or 
   "ConnectionStrings": {
         "DefaultConnection": "Data Source=your_server;Initial Catalog=your_database;User Id=your_username;Password=your_password;;TrustServerCertificate=True;"
    
    ```

3. **Run Migrations**:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. **Run the Application**:
    ```bash
    dotnet run
    ```

5. **Access the Application**:
    - Open your web browser and navigate to `https://localhost:5101` (or the URL specified in the console output).

## Usage

### Departments

- **View Departments**: Navigate to `/Departments/Index` to view the list of departments.
  
### Reminders

- **View Reminders**: Navigate to `/Reminders/Index` to see all reminders.
- **Create Reminder**: Use the form on `/Reminders/Create` to add a new reminder.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)

