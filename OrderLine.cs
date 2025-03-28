namespace lab2;

[Serializable]
public class OrderLine
{
    private int _quantity;
    private Item _item;

    public Item Item
    {
        get => _item;
        set => _item = value ?? throw new ArgumentNullException("Невалидное значение Item:NULL");
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value <= 0) throw new ArgumentException("Невалидное значение Quantity");
        }
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