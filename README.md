# Windows Forms CRUD Application using C# and MySQL

This project is a simple CRUD (Create, Read, Update, Delete) desktop application built using:

* C# Windows Forms
* MySQL Database
* MySQL.Data NuGet Package

## Features

* Add Student Records
* Update Existing Records
* Delete Records
* View Records using DataGridView
* MySQL Database Connectivity

---

## Technologies Used

* C#
* .NET Windows Forms
* MySQL
* Visual Studio
* MySQL Workbench

---

## Database Setup

Create the database:

```sql
CREATE DATABASE student;
```

Use the database:

```sql
USE student;
```

Create the table:

```sql
CREATE TABLE student (
       sid varchar(50) primary key,
       name varchar(50),
       email varchar(40) unique,
       mobile bigint
);
```

---

## Important Configuration

Before running the project, update the database connection string inside:

```text
db.cs
```

Change the following according to your local MySQL setup:

* Database name
* MySQL username
* Password

Example:

```csharp
public static string connectionString =
"server=localhost;port=3306;database=student;uid=root;pwd=yourpassword;";
```

---

## NuGet Package Required

Install the following package using NuGet Package Manager:

```text
MySql.Data
```

---

## How to Run

1. Clone the repository
2. Open the solution in Visual Studio (to open solution explorer, use thsi shortcut - ctrl+alt+l)
3. Configure the MySQL connection string in `db.cs`
4. Run the SQL schema
5. Start the application

