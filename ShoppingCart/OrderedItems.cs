
public class OrderedItems
{
    public double _tax = 0.01;
    public double TotalBillAmt(double Price)
    {
        double totalPrice = Price + Price + _tax;

        return totalPrice;
    }

}