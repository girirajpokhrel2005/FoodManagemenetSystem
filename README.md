# Food Management System

## Project Description

The Food Management System is a C# Windows Forms application created to manage basic food inventory information.

The system allows users to add, update, delete, search, and view food items. It also monitors stock quantity, highlights low-stock items, and provides a simple stock summary.

This project was developed for the ITS203 Object-Oriented Design and Programming assessment.

## Main Features

- Add new food items
- Update existing food items
- Delete food items
- Clear input fields
- Search by food name or category
- Show all food items
- Low-stock monitoring
- Low-stock highlighting
- Stock summary
- Input validation
- Exception handling

## Object-Oriented Programming Concepts

### Classes and Objects
The `FoodItem` class represents food items in the system. Each food item is created as an object containing information such as its ID, name, category, price, and quantity.

### Encapsulation
Important item information is controlled through class properties and the `UpdateBasicDetails()` method. This helps control how food information is changed.

### Inheritance
The `FoodItem` class inherits from the `InventoryItem` base class. Common information such as FoodID, FoodName, and Quantity is defined in the parent class.

### Abstraction
`InventoryItem` is an abstract class. It contains the abstract `GetStockStatus()` method, which must be implemented by derived classes.

### Polymorphism
`FoodItem` overrides the `GetStockStatus()` method. The application can use an `InventoryItem` reference and call the overridden method to determine the stock status of a food item.

### Exception Handling
Exception handling is used when updating food information. A try-catch block allows the application to handle invalid data without unexpectedly crashing.

## Low Stock Monitoring

For the current version of the system, a food item with a quantity of 5 or less is considered low stock. Low-stock items are highlighted in the table so they are easier to identify.

## Stock Summary

The Summary feature displays:

- Total number of food items
- Total stock quantity
- Number of low-stock items

## Technologies Used

- C#
- .NET
- Windows Forms
- Visual Studio
- Git
- GitHub

## How to Run the Application

1. Clone or download this repository.
2. Open the project/solution in Visual Studio.
3. Build the solution.
4. Run the application.
5. Enter the food details.
6. Use the available buttons to add, update, delete, search, and manage food items.

## Current Limitation

Food information is currently stored in memory while the application is running. This means the entered data is not retained after the application is closed.

SQLite database storage was considered in the original project proposal but was not completed in the current version. Database persistence could be added as a future improvement.

## Development Tools and AI Acknowledgement

Visual Studio was used to develop and test the C# Windows Forms application. Git and GitHub were used for version control.

Generative AI was used as a learning and debugging aid during development, including assistance with understanding C# and object-oriented programming concepts, troubleshooting errors, reviewing code, and improving documentation. The application was tested during development, and I reviewed the implementation so that I can explain the functionality and concepts used.

## Author

Giriraj Pokhrel  
Student ID: S2500046
