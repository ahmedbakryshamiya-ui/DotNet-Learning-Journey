const int numberOfProducts = 50;
const int detailsOfProduct = 3;

string?[,] inventory = new string?[numberOfProducts, detailsOfProduct];
int productCount = 0;

while (true)
{
    Console.WriteLine(
        "Welcome to the Inventory System\n" +
        "------------------------------\n" +
        "1. Add product\n" +
        "2. Update product quantity\n" +
        "3. View products\n" +
        "4. Exit");

    Console.Write("Choose an option: ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Please enter a valid menu number.");
        continue;
    }

    switch (choice)
    {
        case 1:
            AddProduct();
            break;
        case 2:
            UpdateProduct();
            break;
        case 3:
            ViewProducts();
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Choose an option from 1 to 4.");
            break;
    }
}

void AddProduct()
{
    if (productCount >= numberOfProducts)
    {
        Console.WriteLine($"Inventory is full. The limit is {numberOfProducts} products.");
        return;
    }

    Console.Write("Enter product name: ");
    string name = Console.ReadLine()?.Trim() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Product name cannot be empty.");
        return;
    }

    Console.Write("Enter product quantity: ");
    if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
    {
        Console.WriteLine("Quantity must be a non-negative whole number.");
        return;
    }

    Console.Write("Enter product price: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
    {
        Console.WriteLine("Price must be a non-negative number.");
        return;
    }

    inventory[productCount, 0] = name;
    inventory[productCount, 1] = quantity.ToString();
    inventory[productCount, 2] = price.ToString("F2");
    productCount++;

    Console.WriteLine("Product added successfully.");
}

void ViewProducts()
{
    if (productCount == 0)
    {
        Console.WriteLine("The inventory is empty.");
        return;
    }

    Console.WriteLine("Product list");
    Console.WriteLine("-------------");
    for (int i = 0; i < productCount; i++)
    {
        Console.WriteLine(
            $"ID: {i} | Name: {inventory[i, 0]} | " +
            $"Quantity: {inventory[i, 1]} | Price: {inventory[i, 2]}");
    }
}

void UpdateProduct()
{
    if (productCount == 0)
    {
        Console.WriteLine("There are no products to update.");
        return;
    }

    Console.Write("Enter the product name to update: ");
    string searchProduct = Console.ReadLine()?.Trim() ?? string.Empty;

    int productId = -1;
    for (int i = 0; i < productCount; i++)
    {
        if (string.Equals(inventory[i, 0], searchProduct, StringComparison.OrdinalIgnoreCase))
        {
            productId = i;
            break;
        }
    }

    if (productId == -1)
    {
        Console.WriteLine("Product not found.");
        return;
    }

    Console.Write("Enter the new quantity: ");
    if (!int.TryParse(Console.ReadLine(), out int newQuantity) || newQuantity < 0)
    {
        Console.WriteLine("Quantity must be a non-negative whole number.");
        return;
    }

    inventory[productId, 1] = newQuantity.ToString();
    Console.WriteLine("Quantity updated successfully.");
}
