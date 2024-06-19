# Create a minimal API with ASP.NET Core
This repository is my playground for learning and experimenting with minimal APIs using ASP.NET Core. The aim is to understand the basics of setting up and managing a minimal API.
### Steps and Concepts

#### Project Setup
- Create a new ASP.NET Core Empty project named TodoApi.

#### Configuring Program.cs
Initialize the app, onfigure services, and define endpoints.

#### Adding Necessary Packages
Install Microsoft.EntityFrameworkCore.InMemory for the in-memory database.
Install Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore for detailed error pages.

#### Creating Models
Todo.cs: Defines the to-do item model.
TodoDb.cs: Database context for managing to-do items.

#### Defining Endpoints
- GET /todoitems - Retrieve all to-do items.
- GET /todoitems/complete - Retrieve completed items.
- GET /todoitems/{id} - Retrieve a specific item.
- POST /todoitems - Add a new item.
- PUT /todoitems/{id} - Update an item.
- DELETE /todoitems/{id} - Delete an item.
- 
#### Running the Application
Use Ctrl+F5 to run and test the application locally.

#### Testing the API
Utilize tools like Swagger or Postman to test the endpoints.

## Additional Notes:
### API:
- It’s SQL over http
- API return .json

## 1.Models:
- Model is just a class with a bunch of properties in it
- But a model holds a very important role, because a model is your database tables (like excel spreadsheets)

### Id inside of a Model class is a primary key
Primary keys serve as unique identifiers for each row in a database table. Foreign keys link data in one table to the data in another table.
![Foreign-keys](https://github.com/yixin1230/Webapi/assets/100164159/9cbb658a-748e-4374-805d-8410cfc4699a)


### Relationships
One-to-many
Many-to-many
One-to-one
many always goes into ICollection


### Resources
* [.net blazor](https://www.youtube.com/watch?v=walv3nLTJ5g)
* [.net api](https://www.youtube.com/watch?v=BnlFovYeQtI&list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0&index=2)
* [Tutorial: Create a minimal API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio)
