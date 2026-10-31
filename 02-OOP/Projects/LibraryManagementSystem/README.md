# Library Management System

A console-based library example using classes, inheritance, book storage, and basic object relationships.

## Run

Open [LibraryManagementSystem.slnx](LibraryManagementSystem.slnx) in Visual Studio, or run:

```bash
dotnet run --project LibraryManagementSystem.csproj
```

## Class diagram

![Library Management System class diagram](LibraryManagementSystem.svg)

- [Open the editable Draw.io diagram](LibraryManagementSystem.drawio)

## Main types

| Type | Responsibility |
|---|---|
| `User` | Abstract base type with a name and shared book-display operation. |
| `Librarian` | Adds and removes books through the `Library` object. |
| `LibraryUser` | Displays available books, borrows by title, and has an initialized `LibraryCard`. |
| `Library` | Stores available and borrowed book arrays; validates add, remove, and borrow operations. |
| `Book` | Holds title, author, and year. |
| `LibraryCard` | Holds a generated card number for the current application run. |

## Improvements made during review

- Empty input and invalid menu choices no longer cause an index error.
- Book year input is validated.
- Borrowing checks that the requested title is available and moves that book from the available list to the borrowed list.
- The available and borrowed arrays enforce their capacity limits.
- The user's library card is initialized and shown after registration.
- Empty lists now display a helpful message.

## Remaining limitations

- Book data is held in memory only and is lost when the program exits.
- Storage has fixed limits: 100 available books and 50 borrowed books.
- Borrowed books are tracked for the current run; there is no return-book workflow or persistent user database.
