namespace lab2;

[Serializable]
public class Item
{
    private string _article;
    private string _name;
    private double _unitPrice;

    public Item()
    {
    }

    public string Article
    {
        get => _article;
        set
        {
            if (value.Length != 6) throw new ArgumentException("Невалидное значение Article");
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value == "" || value == null) throw new ArgumentException("Невалидное значение Name");
            _name = value;
        }
    }

    private bool CheckPrice(double value)
    {
        string formattedValue = value.ToString("F2");
        return formattedValue.Split('.')[1].Length == 2;
    }
    
    public double UnitPrice
    {
        get => _unitPrice;
        set
        {
            if (value <= 0 && CheckPrice(value)) throw new ArgumentException("Невалидное значение UnitPrice");
            _unitPrice = value;
        }
    }

    public Item(string article, string name, double unitPrice)
    {
        Article = article;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        UnitPrice = unitPrice;
    }

    public override string ToString()
    {
        return $"артикль: {_article}; название: {_name}; цена за единицу: {_unitPrice}";
    }
}