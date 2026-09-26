# Student Management

![demo](demo.png)

A .NET 8 Windows Forms app for managing student records stored in SQL Server.

## Features

- View student records
- Add, update, search and delete records

## Requirements

- .NET 8
- SQL Server
- A database named `StudentDB` with a `Students` table that contains `Id`, `Name`, `Surname`, and `Email` columns

## Setup

Update the SQL Server connection string in `Form1.cs` to use your server and database. Make sure the StudentDB database and Students table exist.

## Run

Open the solution in Visual Studio, restore dependencies if prompted, and run the `hafta2` project.

## Usage

Start by adding a student by entering name, surname and email to their respective text boxes and clicking the `Add` button. \
Search students by using the text boxes and clicking to the `Search` button. \
For updating and deleting. First click to the student you wish to select and either update by editing its details or just click `Delete` button to delete the student.  
