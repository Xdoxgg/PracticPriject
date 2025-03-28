namespace lab2;

[Serializable]
public class Item
{
    private int _article;
    private string _name;
    private double _unitPrice;

    public Item()
    {
    }

    public int Article
    {
        get => _article;
        set => _article = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public double UnitPrice
    {
        get => _unitPrice;
        set => _unitPrice = value;
    }

    public Item(int article, string name, double unitPrice)
    {
        _article = article;
        _name = name ?? throw new ArgumentNullException(nameof(name));
        _unitPrice = unitPrice;
    }

    public override string ToString()
    {
        return $"артикль: {_article}; название: {_name}; цена за единицу: {_unitPrice}";
    }
}