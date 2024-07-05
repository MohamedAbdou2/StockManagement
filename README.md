# Stock Management System

## Overview

This project is a Stock Management System that allows users to manage items and stores, perform CRUD operations, and handle purchases. It is built using the ASP.NET Core MVC framework, SQL Server for the database, and follows the three-tier architecture. The project utilizes lazy loading, generic repository, repository design patterns, and dependency injection. AJAX is used for real-time quantity updates.

## Features

- **Items Management**: Create, Read, Update, and Delete (CRUD) operations for items.
- **Stores Management**: CRUD operations for stores.
- **Store Item Management**: Add items to specific stores with quantities.
- **Purchases**: Handle purchases, update item quantities across stores.
- **Real-time Quantity Updates**: AJAX-enabled quantity updates for seamless user experience.

## Technologies Used

- **ASP.NET Core MVC**: For building the web application.
- **SQL Server**: For database management.
- **Three-tier Architecture**: Presentation, Business Logic, and Data Access layers.
- **Lazy Loading**: For efficient data loading.
- **Generic Repository**: For common data access operations.
- **Repository Design Patterns**: For flexible and maintainable code.
- **Dependency Injection**: For managing dependencies.
- **AJAX**: For real-time updates.

## Database

The database backup file (`.bak`) is attached to the project. Restore the database in SQL Server to get started.

## Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/MohamedAbdou2/StockManagement.git
2-**Restore the database**:

Open SQL Server Management Studio (SSMS).
Restore the database using the provided .bak file.
3-**Update the connection string**:

In appsettings.json, update the connection string to match your SQL Server configuration.
4-**Build and run the project**:

Open the solution in Visual Studio.
Build the project to restore dependencies.
Run the project.
## Usage
-**Items**
List Items: View a list of all items.
Create Item: Add a new item.
Edit Item: Modify an existing item.
Delete Item: Remove an item.
-**Stores**
List Stores: View a list of all stores.
Create Store: Add a new store.
Edit Store: Modify an existing store.
Delete Store: Remove a store.
-**Store Items**
Add Item to Store: Select an item and add it to a specific store with a quantity.
View Store Items: View items in a specific store along with their quantities.
-**Purchases**
Make Purchase: Select items and specify quantities for purchase.
Update Quantities: Quantities are updated in real-time using AJAX.
