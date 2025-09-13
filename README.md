# Library Management System

## Overview
The **Library Management System** is a software solution designed to help local libraries manage their books, clients, and rental operations efficiently. The system allows libraries to track book availability, manage client information, record rentals and returns, and streamline day-to-day operations.

---

## Features
- **Book Management**
  - Add, edit, or remove books
  - Track available vs. rented books
  - Organize books by title, author, genre, or ISBN
  - **Add books directly in the database using the C# Windows Forms app**

- **Client Management**
  - Store client details (name, contact info, membership ID)

- **Renting & Returning**
  - Record when a client borrows a book
  - Track due dates and overdue books
  - Update book availability upon return

- **Deliveries**
  - Register incoming deliveries of new books
  - Update stock when new items are added

---

## Benefits
- Reduces manual work and errors
- Provides quick access to client and book records
- Helps libraries track overdue returns
- Improves organization and book tracking

---

## Database Setup
1. Open your SQL management tool (e.g., MySQL Workbench, SQL Server Management Studio).  
2. Open the file `lybraryManagementDB.sql`.  
3. Copy the code inside and **run the script** to create the database and tables.  
4. In the C# Windows Forms app, you can now add books, clients, and manage rentals directly in the app, which will update the database automatically.

---

## Getting Started
1. Clone this repository:
    ```bash
    git clone https://github.com/your-username/library-management-system.git
    ```
2. Open the project in **Visual Studio**.  
3. Build and run the application.  
4. Make sure the database is set up using `lybraryManagementDB.sql`.

---

## Author
**Dimitar Sideris**  
Student & Developer
