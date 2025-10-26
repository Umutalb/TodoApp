# TodoApp

A simple ASP.NET Core Web API project built as part of the *Mini Backend Event* series.

This project demonstrates basic CRUD (Create, Read, Update, Delete) operations using an *in-memory data store* and a single TodoItem model.  
It is designed to help participants understand how backend logic, controllers, and endpoints work in a simple real-world scenario.

---

### 🧱 Features
- Built with *.NET 8* and *Visual Studio 2022*
- Uses *in-memory storage* (no database required)
- Implements full *CRUD operations*
- Includes a completion toggle endpoint (/complete)
- Clean and minimal controller structure

---

### 🚀 API Endpoints

| Method | Route | Description |
|---|---|---|
| *GET* | /api/todos | Retrieve all todo items |
| *GET* | /api/todos/{id} | Retrieve a specific todo item by ID |
| *POST* | /api/todos | Create a new todo item |
| *PUT* | /api/todos/{id} | Update an existing todo item (currently updates only Title & Description) |
| *DELETE* | /api/todos/{id} | Delete a todo item |
| *PUT* | /api/todos/{id}/complete | Toggle the completion status |

---

### 🧠 Tech Stack
- *Language:* C#
- *Framework:* ASP.NET Core 8 Web API
- *IDE:* Visual Studio 2022
- *Data Layer:* In-Memory List

---

### 👨‍💻 About
This project is developed by **[Umut Albayrak](https://www.linkedin.com/in/umutalbayrak24)**  
as part of the *Mini Backend Event (October 2025)*.

> “Learn backend development by building small but complete real-world projects.”

---

### 🔗 Project Navigation

*➡ Next Project:* **[IssueApp](Coming Soon — IssueApp)**

---

🌐 *Event Series:* [Mini Backend Event Repository](https://github.com/Umutalb/MiniBackendEvent)
