# Web Application Student Management

This web application is designed to manage student data along with their associated departments. It includes controllers for handling CRUD operations on student resources and retrieving student data with departments. The application is built using ASP.NET Core with Entity Framework Core for data access.

## Controllers

### StudentController

The `StudentController` is responsible for handling HTTP requests related to student resources.

- **GET /api/Student**: Retrieves all students.
- **POST /api/Student**: Adds a new student.
- **PUT /api/Student/{id}**: Updates an existing student with the given ID.
- **DELETE /api/Student/{id}**: Deletes the student with the given ID.

### StudentWithDepartmentController

The `StudentWithDepartmentController` retrieves students along with their associated departments.

- **GET /api/StudentWithDepartment/withDepartments**: Retrieves all students with their associated departments.

## Data Transfer Objects (DTOs)

### StudentWithDepartmentsDTO

The `StudentWithDepartmentsDTO` is a Data Transfer Object representing student data along with their associated departments. It includes properties such as `StudentId`, `Name`, `Age`, `Address`, `Image`, and `Departments`.

## Data Model

### Department

The `Department` class represents a department entity in the model. It includes properties such as `Id` and `Name`, as well as a navigation property `StudentDepartments` representing the relationship between departments and students.

### Student

The `Student` class represents a student entity in the model. It includes properties such as `Id`, `Name`, `Age`, `Address`, `Image`, and `StudentDepartments`, representing the relationship between students and departments.

### StudentDepartment

The `StudentDepartment` class represents the join entity in a many-to-many relationship between students and departments. It includes `StudentId` and `DepartmentId` properties along with navigation properties `Student` and `Department` representing the related entities.

## Data Access

### SchoolContext

The `SchoolContext` class is the Entity Framework DbContext for interacting with the database. It includes `DbSet` properties for `Student`, `Department`, and `StudentDepartment` entities, as well as configuration for their relationships in the `OnModelCreating` method.

## Usage

To utilize this web application, adhere to these steps:

1. **Clone the repository**: Obtain a local copy of the project by cloning the repository.
   
2. **Configure the database connection**: Navigate to `appsettings.json` and configure the database connection according to your environment settings.

3. **Run Entity Framework migrations**: Execute Entity Framework migrations to create the necessary database schema.

4. **Build and run the application**: Build the application and run it using your preferred development environment.

5. **Interact with the APIs**: Utilize HTTP requests to interact with the provided APIs.

Ensure to relocate the "FrontEnd" folder outside of the project to avoid encountering errors. 
This folder contains an HTML page designed to test the API, so you'll need to run it with a live server.

## Dependencies

- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Mvc
- Microsoft.EntityFrameworkCore

## Contributors

- Fares
- fares.gomaa.work@gmail.com

## License

This project is licensed under the [MIT License](LICENSE).
