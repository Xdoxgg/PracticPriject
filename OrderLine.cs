namespace lab2;

[Serializable]
public class OrderLine
{
    private int _quantity;
    private Item _item;
    public Item Item => _item;
    public int Quantity => _quantity;
    public double Cost
    {
        get { return _item.UnitPrice * _quantity; }
    }
}