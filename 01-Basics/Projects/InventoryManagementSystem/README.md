# Inventory Management System

A console program for adding products, updating product quantities, and viewing the current inventory.

## Run

Open [InventoryManagementSystem.slnx](InventoryManagementSystem.slnx) in Visual Studio, or run:

```bash
dotnet run --project InventoryManagementSystem.csproj
```

## Program flow

![Inventory management flow](InventoryManagementSystem.svg)

- [Open the editable Draw.io diagram](InventoryManagementSystem.drawio)
- [Source code](Program.cs)

## How it works

- Stores up to 50 product rows in a two-dimensional nullable string array.
- Each row has three values: product name, quantity, and price.
- The menu supports Add, Update quantity, View, and Exit.
- Update searches product names without case sensitivity and changes quantity only.

## Current behavior and limitations

- Capacity is checked before adding, so the array cannot be written past its 50-row limit.
- Menu input, quantity, and price are validated. Quantity must be a non-negative whole number and price must be non-negative.
- Product name cannot be empty.
- Products are held in memory only and are lost when the application exits.
- Updating a product changes quantity only; price cannot currently be updated.
- This is a learning example using a fixed-size array, not a persistent inventory database.
