# BudgetTracker

A personal finance web application built with Blazor Server to help track income and expenses.

## Features

- Add and categorize income and expense transactions
- View all transactions in a searchable table
- Financial dashboard with balance overview and monthly summaries
- User authentication and secure data storage
- Responsive design that works on mobile and desktop

## Tech Stack

- **Frontend**: Blazor Server, Bootstrap 5
- **Backend**: ASP.NET Core 6
- **Database**: Entity Framework Core with SQL Server
- **Authentication**: ASP.NET Core Identity

## Getting Started

1. Clone the repository
2. Install .NET 6 SDK
3. Run `dotnet restore` to install packages
4. Run `dotnet ef database update` to create the database
5. Start the app with `dotnet run` or F5 in Visual Studio

## Database

The app uses Entity Framework Code First migrations. The database will be created automatically when you run the update command.

## Future Plans

- Expense categories with spending limits
- Data export functionality
- Basic reporting and charts
- Receipt photo upload

## Development

This is a learning project to practice full-stack web development with .NET technologies.
