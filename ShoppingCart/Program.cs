
var shoppingProduct = new ShoppingProduct();


//string name = string.Empty;
//int quantity = 0;
//int price = 0;
//int choice = -1;

//void UserMenu()
//{
//    Console.WriteLine("Press 0 to exit: ");
//    Console.WriteLine("Press 1 to continue: ");
//    Console.Write("Enter the value :");
//    int choice = Convert.ToInt32(Console.ReadLine());
//}


//try
//{
    
//    while (!choice.Equals(0));
//    {
//        UserMenu();
//        Console.Clear();
//        switch (choice)
//        {
//            case 0:
//                Console.WriteLine("exited");
//                break;
//            case 1:
//                Console.WriteLine("Enter the Product Name: ");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter quantity");
//                int quantity = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter Price: ");
//                int price = Convert.ToInt32(Console.ReadLine());
//                var products = new ShoppingItems(name, quantity, price);
//                shoppingProduct.AddProduct(products);

//                Console.WriteLine("Enter 0 to exit");
//                choice = Convert.ToInt32(Console.ReadLine());

//                break;

//        }
//    }

//}
//finally
//{
//    Console.WriteLine("Exit");
//}

void AddProduct()
{
    string choice = string.Empty;
    while (!choice.Equals("e"))
    {

        string name = string.Empty;
        int quantity = 0;
        int price = 0;

        Console.WriteLine("Enter the Product Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter quantity");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Price: ");
        price = Convert.ToInt32(Console.ReadLine());
        var products = new ShoppingItems(name, quantity, price);
        shoppingProduct.AddProduct(products);

        Console.WriteLine("Enter e to exit");
        //choice = Convert.ToInt32(Console.ReadLine());
        choice = Console.ReadLine();


    }
}
void PrintCart()
{
shoppingProduct.PrintCart();
}

void TotalPrice()
{
    OrderedItems item = new OrderedItems();
    double totalPrice = shoppingProduct.TotalBill();
    Console.WriteLine("TotalPrice bill" + item.TotalBillAmt(totalPrice));
}

AddProduct();
PrintCart();
TotalPrice();


