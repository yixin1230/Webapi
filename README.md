# Create a minimal API with ASP.NET Core

## Introduction
This repository is my playground for learning and experimenting with minimal APIs using ASP.NET Core. The aim is to understand the basics of setting up and managing a minimal API.
Steps and Concepts

### Project Setup

- Create a new ASP.NET Core Empty project named TodoApi.
### Configuring Program.cs

Initialize the app, configure services, and define endpoints.
### Adding Necessary Packages

Install Microsoft.EntityFrameworkCore.InMemory for the in-memory database.
Install Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore for detailed error pages.
### Creating Models

Todo.cs: Defines the to-do item model.
TodoDb.cs: Database context for managing to-do items.
### Defining Endpoints

- GET /todoitems - Retrieve all to-do items.
- GET /todoitems/complete - Retrieve completed items.
- GET /todoitems/{id} - Retrieve a specific item.
- POST /todoitems - Add a new item.
- PUT /todoitems/{id} - Update an item.
- DELETE /todoitems/{id} - Delete an item.
### Running the Application

Use Ctrl+F5 to run and test the application locally.
### Testing the API

Utilize tools like Swagger or Postman to test the endpoints.

## Additional Notes:
### API:

It’s SQL over http

API return .json

## 1.Models:

Model is just a class with a bunch of properties in it
but a model holds a very important role, because a model is your database tables (like excel spreadsheets)

### Id inside of a Model class is a primary key

Primary keys serve as unique identifiers for each row in a database table. Foreign keys link data in one table to the data in another table.

![Foreign-keys.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/95c49394-ba29-48ab-9af4-18a95f04bc83/d20834fd-89ab-4235-bc4f-df4aae2fac9d/Foreign-keys.png)

### Relationships

One-to-many

Many-to-many

One-to-one

many always goes into ICollection

## **2.Add a database context**

going to be installing entity framework into [asp.net](http://asp.net) web api app

install Nuget, not success, I need to restart

install SQL sever

### list questions:

### Resources
* [.net blazor](https://www.youtube.com/watch?v=walv3nLTJ5g)
* [.net api](https://www.youtube.com/watch?v=BnlFovYeQtI&list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0&index=2)
