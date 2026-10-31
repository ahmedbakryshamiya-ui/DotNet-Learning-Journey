

using System.Threading.Channels;

int numberOfProducts =50;
int detailsOfProduct = 3;
string[,] inventory =
    new string[numberOfProducts, detailsOfProduct];
int productCount = 0;
while (true)
{
    Console.WriteLine("Welcome to the nventory System Enter your Choice" +
    "\n------------------------------" +
    "\n1.Add product" +
    "\n2.Update product" +
    "\n3.View product" +
    "\n4.Exit ");

    
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            // Add product
            Addproduct();
            break;
        case 2:
            // Update product
            UpdateProduct();
            break;
        case 3:
            // View product
            ViewProduct();
            break;
        case 4:
            // Exit
            Environment.Exit(0);
            break;

    }

}
void Addproduct()
{

    Console.WriteLine("Enter product name");
    string name = Console.ReadLine();

    Console.WriteLine("Enter product quantity");
    string quantity = Console.ReadLine();

    Console.WriteLine("Enter product price");
    string price = Console.ReadLine();

    inventory[productCount, 0] = name;
    inventory[productCount, 1] = quantity;
    inventory[productCount, 2] = price;
    productCount++;
    Console.WriteLine("Product added successfuly");
    Console.WriteLine("=========================");
}
void ViewProduct()
{
    if (productCount > 0)
    {
        Console.WriteLine("Product list");
        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"Product ID:{i} ,Product Name: {inventory[i, 0]} ,Product quantity  {inventory[i, 1]} ,Product price:{inventory[i, 2]} ");
        }
    }
}

void UpdateProduct() 
{
    Console.WriteLine("Enter product name to update");
    string searchProduct = Console.ReadLine();
    int productID = -1;

    if (productCount > 0)
    {
        for (int i = 0; i < productCount; i++)
        {
            if (inventory[i, 0] == searchProduct)
            {
                productID = i;
                break;
            }
        }
        if (productID != -1)
        {
            Console.WriteLine("Enter the new quantity");
            string newquantity = Console.ReadLine();
            inventory[productID, 1] = newquantity;
            Console.WriteLine("quantity updated successful");
        }
        else
        {
            Console.WriteLine("product not found");
        }

    }
    

}


