using System.Collections.Generic;

class ShoppingProduct
{
    public readonly List<ShoppingItems> _shoppingItem;
    public ShoppingProduct()
    {
        _shoppingItem = new List<ShoppingItems>();
    }
    public void AddProduct(ShoppingItems product) 
    {
        _shoppingItem.Add(product);
    }
    public void PrintCart()
    {
        foreach (var item in _shoppingItem) 
        {
            Console.WriteLine(item);
        }
    }
    public double TotalBill()
    {
        double total = 0.0;
        foreach (var item in _shoppingItem) 
        {
            total = item.Price * item.Quantity;
        }
        return total;
    }
}