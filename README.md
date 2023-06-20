# megamind
Simple CRUD operation using .NET MVC

# User Registration Project

This is a user registration project built with ASP.NET MVC. It allows users to register by filling out a form and stores the registration data in a database. Users can also view, edit, and delete their registration data.

## Dependencies

To run this project, you need to have the following dependencies installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version X.X.X)
- [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc) (version X.X.X)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/) (version X.X.X)
- [Microsoft SQL Server](https://www.microsoft.com/sql-server) (version X.X.X)

## Getting Started

Follow the steps below to get started with the project:

1. Clone the repository:

   ```shell
   git clone https://github.com/your-username/user-registration-project.git
Change to the project directory:

shell
cd user-registration-project
Restore the NuGet packages:

shell
dotnet restore
Configure the Database Connection:

Open the appsettings.json file.
Update the ConnectionString value with your SQL Server connection string.
Run the Database Migrations:

shell
dotnet ef database update
Start the application:

shell
dotnet run
Open a web browser and navigate to http://localhost:5000 to access the user registration form.

Folder Structure
The project's folder structure is as follows:

Controllers/: Contains the controllers for handling user registration and data management.

Models/: Contains the data models used in the project.

Views/: Contains the Razor views for rendering HTML templates.

Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.
