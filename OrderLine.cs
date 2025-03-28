namespace lab2;

[Serializable]
public class OrderLine
{
    private int _quantity;
    private Item _item;

    public Item Item
    {
        get => _item;
        set => _item = value;
    }

    public int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public double Cost
    {
        get { return _item.UnitPrice * _quantity; }
    }

    public OrderLine(int quantity, Item item)
    {
        Quantity = quantity;
        Item = item;
    }

    public OrderLine()
    {
    }
}