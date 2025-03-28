namespace lab2WINFORMS;

[Serializable]
public class OrderLine
{
    private int _quantity;
    private Item _item;


    public double Cost
    {
        get { return _item.UnitPrice * _quantity; }
    }
}