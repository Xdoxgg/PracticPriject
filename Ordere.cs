namespace lab2;

[Serializable]
public class Ordere
{
    private int _number;
    private DateTime _creationDate;
    private string _adress;
    private bool _isExpressDelivery;
    private Customer _customer;
    private List<OrderLine> _orderLines;

    public Ordere(int number, DateTime creationDate, string adress, bool isExpressDelivery, Customer customer,
        List<OrderLine> orderLines)
    {
        Number = number;
        CreationDate = creationDate;
        Adress = adress;
        IsExpressDelivery = isExpressDelivery;
        Customer = customer;
        OrderLines = orderLines;
    }

    public Ordere()
    {
    }

    public int Number
    {
        get => _number;
        set
        {
            if (value <= 0) throw new ArgumentException("Невалидное значение Number");
            value = _number;
        }
    }

    public DateTime CreationDate
    {
        get => _creationDate;
        set => _creationDate = value;
    }

    public string Adress
    {
        get => _adress;
        set => _adress = value ?? throw new ArgumentException("Невалидное значение CreationDate");
    }

    public bool IsExpressDelivery
    {
        get => _isExpressDelivery;
        set => _isExpressDelivery = value;
    }

    public Customer Customer
    {
        get => _customer;
        set => _customer = value ?? throw new ArgumentException("Невалидное значение Customer");
    }

    public List<OrderLine> OrderLines
    {
        get => _orderLines;
        set => _orderLines = value ?? throw new ArgumentException("Невалидное значение OrderLines");
    }

    public double TotalCost
    {
        get
        {
            double sum = 0;
            _orderLines.ForEach(x => sum += x.Cost);
            if (_isExpressDelivery)
            {
                sum *= 1.25;
            }

            if (_customer.Privileged && sum >= 1500)
            {
                sum = sum - sum * 0.15;
            }

            return sum;
        }
    }
}